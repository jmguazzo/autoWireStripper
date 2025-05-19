using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWireStripper
{
    internal class PrinterHandler
    {
        SerialPort serialPort;
        public event EventHandler<string> DataReceived;
        public PrinterHandler(string portName, int baudRate)
        {
            serialPort = new SerialPort(portName, baudRate);
            serialPort.DataReceived += DataReceivedHandler;
            serialPort.DtrEnable = true; // important pour forcer le reset de certains firmwares
            serialPort.Open();

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();
            if (this.DataReceived != null)
            {
                this.DataReceived(this, data);
            }
        }
        public void init()
        {
            sendCommand(@"
M302 S0 ;autoriser extrusion à froid
G91 ; Activer le mode relatif
N0 M110 N0*125
N1 M115*39
N2 M21*18");

        }
        void sendCommand(String command)
        {
            serialPort.Write(command + "\n");
        }

        public void strip(int leftStripLengthInMm, int totalLengthInMmm, int rightStripLengthInMm)
        {
            sendCommand($@"
; extraire fil gauche
G1 E{leftStripLengthInMm} F300 
; dénuder
G1 Z-3 F600; Descend de 3 mm
G1 Z3 F600; Monte de 3 mm
;extraire restant du fil sauf right
G1 E{totalLengthInMmm - leftStripLengthInMm - rightStripLengthInMm} F300
; dénuder
G1 Z-3 F600; Descend de 3 mm
G1 Z3 F600; Monte de 3 mm
; extraire fil droit
G1 E{rightStripLengthInMm} F300 
; couper fil
G1 Z-10 F600 ; Descend de 10 mm
G1 Z10 F600  ; Monte de 10 mm
");

        }
    }
}
