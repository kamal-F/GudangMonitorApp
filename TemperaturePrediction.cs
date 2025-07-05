using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace GudangMonitorApp;
public class TemperaturePrediction
{
    [ColumnName("PredictedLabel")]
    public string Prediction { get; set; }
}

