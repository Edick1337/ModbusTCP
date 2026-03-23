using System;
using System.Windows.Forms;
using EasyModbus;

namespace Modbus_TCP {
  public class Client {
    private readonly ModbusClient _modbusClient;
    private string _ip;
    private int _port;
    private int _startAddress;

    public Client(Control ipTb, Control portTb, Control addressTb) {
      ParseParams(ipTb, portTb, addressTb);
      _modbusClient = new ModbusClient(_ip, _port);
      _modbusClient.Connect();
    }

    private void ParseParams(Control ipTb, Control portTb, Control addressTb) {
      try {
        _ip = ipTb.Text;
        _port = int.Parse(portTb.Text);
        _startAddress = int.Parse(addressTb.Text);
      }
      catch (Exception) {
        MessageBox.Show("Failed to parse parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public float ReadHoldingRegisters() {
      var holdingRegisters = _modbusClient.ReadHoldingRegisters(_startAddress, 2);
      var data = ModbusClient.ConvertRegistersToFloat(holdingRegisters);
      return data;
    }

    public void Disconnect() {
      _modbusClient.Disconnect();
    }
  }
}