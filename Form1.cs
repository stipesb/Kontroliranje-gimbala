using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Input;




namespace Kontroliranje_gimbala
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Port;
        System.Windows.Input.ICommand command;

        bool IsClosed = false;




        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            foreach (string comport in ports)
            {
                Select_port.Items.Add(comport);
            }


        }

    



        private void Serijska_komunikacija(string port)
        {
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = port;
            Port.BaudRate = 9600;
            Port.ReadTimeout = 1;


            try
            {
                Port.Open();
            }

            catch { }

        }


         private void Posalji(String komanda)
        {
        
                try
                {
                    byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(komanda);

                    Port.Write(MyMessage, 0, MyMessage.Length);
              

                }
                catch { }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Select_port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pretrazi_Click(object sender, EventArgs e)
        {
            Select_port.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            foreach (string comport in ports)
            {
                Select_port.Items.Add(comport);
            }
        }

        private void gore_Click(object sender, EventArgs e)
        {

            Posalji("w");

        }

        private void Zapocni_Click(object sender, EventArgs e)
        {

           

            Serijska_komunikacija(Select_port.Text);
         
        }

        private void lijevo_Click(object sender, EventArgs e)
        {
            Posalji("a");
        }

        private void desno_Click(object sender, EventArgs e)
        {
            Posalji("d");
        }

        private void dole_Click(object sender, EventArgs e)
        {
            Posalji("s");
        }

        private void form1_KeyDown(object sender, KeyEventArgs e)
        {
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Posalji(e.KeyChar.ToString());

            textBox1.Text = e.KeyChar.ToString();
        }
    }
}
