using System.IO.Ports;
using System.Windows.Forms;

namespace AutoWireStripper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void log(string message)
        {

            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() =>
                {
                    txtLog.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                txtLog.AppendText(message + Environment.NewLine);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //obtention de tous les ports COM existants
            string[] ports = SerialPort.GetPortNames();
            //pour chaque port COM, on l'ajoute à la liste déroulante
            foreach (string port in ports)
            {
                cmboSerial.Items.Add(port);
            }
            cmboSerial.SelectedItem = cmboSerial.Items[cmboSerial.Items.Count - 1]; // sélectionne le dernier port par défaut
            cmboSpeed.SelectedItem = cmboSpeed.Items[0]; // sélectionne la première valeur par défaut

        }
        PrinterHandler serialPort;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        List<String> commands = new List<string>();
        void prepareCommand(string command)
        {
            commands.Add(command);
        }
        bool sending = false;
        bool error = false;


        private void btnConnect_Click(object sender, EventArgs e)
        {
            //get the selected port
            string selectedPort = cmboSerial.SelectedItem.ToString() ?? "";
            if (selectedPort == "")
            {
                return;
            }
            int speed = int.Parse(cmboSpeed.SelectedItem?.ToString() ?? "9600");
            try
            {
                serialPort = new PrinterHandler(selectedPort, speed);
                serialPort.DataReceived += SerialPort_DataReceived;
                log("Port ouvert. Pause 2 secondes...");
                Thread.Sleep(2000); // attendre que le firmware envoie "start" ou initialise
                serialPort.init();

            }
            catch (Exception ex)
            {
                log("Erreur : " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object? sender, string e)
        {
            log(">> " + e);
        }


        private void btnAutoStrip_Click(object sender, EventArgs e)
        {
            int leftStripLength = Convert.ToInt32(leftStripping.Value);
            int rightStripLength = Convert.ToInt32(rightStripping.Value);
            int totalLengthForWire = Convert.ToInt32(wireLength.Value);
            serialPort.strip(leftStripLength, totalLengthForWire, rightStripLength);
        }
    }
}