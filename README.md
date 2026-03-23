# ModbusTCP
Modbus TCP server and client

The essence is to create a program that will poll the device via the Modbus TCP protocol and, based on the received data (coordinates and time), build graphs of the dependence of coordinates and speed on time.
First of all, we will create a "server" to which we will connect for debugging. This program opens a socket for listening and, when the main program accesses it, begins to send values ​​(for example, from a file), each time moving to the next value in the file. The file itself can be generated in Excel (.csv format).

![Server](/Server.png?raw=true "Server")

The main program (client) contains two panels with graphs, as well as a connection control panel. It is possible to set the device polling interval, as well as the starting address of the register whose value should be received. If the connection is successful, the message "OK!" appears. in the panel on the right, and if unsuccessful - an error notification.

![Client](/Client.png?raw=true "Client")
