using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modbus_TCP {
  public partial class Form1 : Form {
    private readonly Panel[] _chartPanels;
    private readonly Charts _charts;
    private int _interval;
    private bool _justStarted = true;
    private Client _modbusClient;
    private bool _paused;

    public Form1() {
      InitializeComponent();
      _charts = new Charts(distanceChart, speedChart);
      _charts.Setup();
      _chartPanels = new[] { distanceChartPanel, speedChartPanel };
    }

    private void ReadRegistersAndPlot() {
      try {
        var data = _modbusClient.ReadHoldingRegisters();
        _charts.PlotDistance(data);
        _charts.PlotSpeed();
      }
      catch (Exception ex) {
        timer1.Stop();
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void startButton_Click(object sender, EventArgs e) {
      try {
        if (_justStarted) {
          _charts.SetCurrentDateAsMinX();
          _justStarted = false;
        }

        pauseButton.Enabled = true;
        abortButton.Enabled = true;
        startButton.Enabled = false;
        _interval = int.Parse(intervalTextBox.Text) * 1000;
        _charts.ChangeInterval(_interval);
        timer1.Interval = _interval;
        _modbusClient = new Client(ipTextBox, portTextBox, startAdressTextBox);
        timer1.Start();
        ShowOkMessage();
      }
      catch (Exception ex) {
        timer1.Stop();

        var result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        if (result == DialogResult.Retry) {
          _justStarted = true;
          startButton_Click(this, EventArgs.Empty);
        }
      }
    }

    private void ShowOkMessage() {
      okLabel.Visible = true;

      var timer = new Timer();
      timer.Interval = _interval;
      timer.Tick += (sender, e) => {
        okLabel.Visible = false;
        timer.Stop();
      };
      timer.Start();
    }

    private void timer1_Tick(object sender, EventArgs e) {
      _charts.ChangeWidth();
      ScrollPanelsToTheEnd();
      ReadRegistersAndPlot();
    }

    private void ScrollPanelsToTheEnd() {
      foreach (var panel in _chartPanels)
        panel.AutoScrollPosition = new Point(panel.HorizontalScroll.Maximum, panel.VerticalScroll.Maximum);
    }

    private void pauseButton_Click(object sender, EventArgs e) {
      if (_paused) {
        timer1.Start();
        pauseButton.Text = "Pause";
      }
      else {
        timer1.Stop();
        pauseButton.Text = "Resume";
      }

      _paused = !_paused;
    }

    private void abortButton_Click(object sender, EventArgs e) {
      pauseButton.Text = "Pause";
      timer1.Stop();
      _charts.Clear();
      _justStarted = true;
      _paused = false;
      okLabel.Visible = false;
      startButton.Enabled = true;
      abortButton.Enabled = pauseButton.Enabled = false;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
        e.Cancel = true;
    }
  }
}