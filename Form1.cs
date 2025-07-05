using Microsoft.ML;
using System.IO.Ports;
using System.Security.Policy;

namespace GudangMonitorApp
{
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        private PredictionEngine<TemperatureData, TemperaturePrediction> predEngine;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPort.Items.AddRange(ports);

            if (ports.Length > 0)
                cmbPort.SelectedIndex = 0; // pilih port pertama secara default
            else
                MessageBox.Show("Tidak ada COM port terdeteksi.\nPastikan ESP32 atau perangkat lain sudah terhubung.");

            var context = new MLContext();
            var model = context.Model.Load("TemperatureModel.zip", out var inputSchema);
            predEngine = context.Model.CreatePredictionEngine<TemperatureData, TemperaturePrediction>(model);

            //test
            var hasil = predEngine.Predict(new TemperatureData { Temperature = 25 });
            lblKlasifikasi.Text = hasil.Prediction;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serial.PortName = cmbPort.SelectedItem.ToString();
            serial.BaudRate = 9600;
            serial.DataReceived += Serial_DataReceived;
            serial.Open();
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*
            string data = serial.ReadLine();
            this.Invoke(new MethodInvoker(() =>
            {
                lblSuhu.Text = data;
                txtLog.AppendText($"{DateTime.Now}: {data}\r\n");
            }));
            */

            string data = serial.ReadLine();

            this.Invoke(new MethodInvoker(() =>
            {
                lblSuhu.Text = data;
                txtLog.AppendText($"{DateTime.Now}: {data}\r\n");

                // Prediksi suhu
                float suhu = float.Parse(data.Replace("Suhu:", "").Trim());
                var hasil = predEngine.Predict(new TemperatureData { Temperature = suhu });
                lblKlasifikasi.Text = hasil.Prediction;
            }));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void testTxt_TextChanged(object sender, EventArgs e)
        {
            //prediksi isi dari testTxt
            var input = new TemperatureData { Temperature = float.Parse(testTxt.Text) };
            var hasil = predEngine.Predict(input);
            lblKlasifikasi.Text = hasil.Prediction;
        }

        private void btnManualOn_Click(object sender, EventArgs e)
        {
            serial.WriteLine("FAN_ON");
        }

        private void btnManualOff_Click(object sender, EventArgs e)
        {
            serial.WriteLine("FAN_OFF");
        }

        private void trackPWM_Scroll(object sender, EventArgs e)
        {
            int pwm = trackPWM.Value;
            serial.WriteLine($"PWM:{pwm}");

        }

        private void chkOtomatis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtomatis.Checked)
            {
                if (lblKlasifikasi.Text == "Danger")
                    serial.WriteLine("ALARM");
                else
                    serial.WriteLine("FAN_OFF");
            }

        }
    }
}
