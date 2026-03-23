using System;
using System.IO;
using EasyModbus;

namespace Modbus_TCP_Server {
  internal abstract class Program {
    private static readonly string FilePath =
      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "data.csv");

    private static readonly string[] Lines = File.ReadAllLines(FilePath);
    private static int _currentLine;
    private static readonly ModbusServer _modbusServer = new ModbusServer();

    private static void Main(string[] args) {
      StartServer();
    }

    private static void StartServer() {
      _modbusServer.NumberOfConnectedClientsChanged += OnNumberOfConnectedClientsChanged;
      _modbusServer.Listen();
      Console.ReadKey();
      _modbusServer.StopListening();
    }

    private static void OnNumberOfConnectedClientsChanged() {
      var connections = _modbusServer.NumberOfConnections;
      var data = Lines[_currentLine];
      var distance = float.Parse(data);
      var registers = ModbusClient.ConvertFloatToRegisters(distance);
      _modbusServer.holdingRegisters[1] = (short)registers[0];
      _modbusServer.holdingRegisters[2] = (short)registers[1];
      _currentLine++;
      if (_currentLine >= Lines.Length) _currentLine = 0;
      Console.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss} | Connections: {connections} | Distance: {distance}");
    }
  }
}