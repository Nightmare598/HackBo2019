using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SafetyTech
{
    public partial class Form2 : Form
    {
        string dato;
        string puertoseleccionado;
        public Form2()
        {
            InitializeComponent();
            string[] puertos = SerialPort.GetPortNames();
            foreach (string mostrar in puertos) { comboBox1.Items.Add(mostrar); }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            Close();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            puertoseleccionado = comboBox1.Text;
            serialPort1.PortName = puertoseleccionado;
            serialPort1.Open();
            CheckForIllegalCrossThreadCalls = false;
            if (serialPort1.IsOpen == true) { label2.Text = "Puerto Encontrado"; }
            else return;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            dato = serialPort1.ReadLine();
            Arduino.Text = dato.ToString();
        }
    }
}
