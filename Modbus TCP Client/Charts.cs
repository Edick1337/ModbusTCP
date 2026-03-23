using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modbus_TCP {
  public class Charts {
    private readonly Chart[] _charts;
    private readonly Chart _distance;
    private readonly Chart _speed;

    public Charts(Chart distanceChart, Chart speedChart) {
      _distance = distanceChart;
      _speed = speedChart;
      _charts = new[] { _distance, _speed };
    }

    public void Setup() {
      foreach (var chart in _charts) {
        var chartArea = chart.ChartAreas[0];
        chartArea.AxisY.LabelStyle.TruncatedLabels = true;
        chartArea.AxisX.LabelStyle.Format = "H:mm:ss";
        chartArea.AxisX.IntervalType = DateTimeIntervalType.Milliseconds;
        chart.Series[0].XValueType = ChartValueType.DateTime;
        chart.Series[0].ToolTip = "#VALX{H:mm:ss}";
      }
    }

    public void PlotDistance(float distance) {
      _distance.Series[0].Points.AddXY(DateTime.Now, Math.Round(distance, 2));
    }

    public void PlotSpeed() {
      var speedCoords = CalculateSpeed();
      var speedX = speedCoords[0];
      var speedY = speedCoords[1];
      _speed.Series[0].Points.AddXY(speedX, Math.Round(speedY, 2));
    }

    private double[] CalculateSpeed() {
      var distancePoints = _distance.Series[0].Points;
      var pointsCount = distancePoints.Count;
      var dateTime = DateTime.Now.ToOADate();
      if (pointsCount < 2) return new[] { dateTime, 0.0 };
      var latestPoint = distancePoints[pointsCount - 1];
      var penultimatePoint = distancePoints[pointsCount - 2];
      if (penultimatePoint == null) return new[] { dateTime, 0.0 };
      var latestT = DateTime.FromOADate(latestPoint.XValue);
      var penultimateT = DateTime.FromOADate(penultimatePoint.XValue);
      var deltaT = Math.Round(latestT.Subtract(penultimateT).TotalSeconds);
      var deltaS = latestPoint.YValues[0] - penultimatePoint.YValues[0];
      var y = deltaS / deltaT;
      return new[] { latestT.ToOADate(), y };
    }

    public void SetCurrentDateAsMinX() {
      foreach (var chart in _charts)
        chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
    }

    public void ChangeInterval(int interval) {
      foreach (var chart in _charts)
        chart.ChartAreas[0].AxisX.Interval = interval;
    }

    public void ChangeWidth() {
      foreach (var chart in _charts)
        chart.Width += 25;
    }

    public void Clear() {
      foreach (var chart in _charts) {
        chart.Series[0].Points.Clear();
        chart.Size = new Size(960, 270);
      }
    }
  }
}