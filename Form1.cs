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
            Port.BaudRate = 115200;
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

            timer1.Start();         
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

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         

            int x = Cursor.Position.X - 960;
            int y = 540 - Cursor.Position.Y;
            label1.Text = "X = " + x +  "Y = " + y ;

            String podatak ="<" + x.ToString() + " " + y.ToString() + ">";

            Posalji(podatak);// mozda treba pokusati sa slanjem integera
            textBox1.Text = podatak; 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = e.Graphics;
            Pen p = new Pen(Color.Black, 3);
            line.DrawLine(p, 960, 0, 960, 1080);
            line.DrawLine(p, 0, 518, 1920, 518);
        }
    }
}
