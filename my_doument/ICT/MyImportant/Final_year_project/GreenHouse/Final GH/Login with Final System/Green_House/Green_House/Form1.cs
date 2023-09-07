using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Threading;


namespace Green_House
{
    public partial class Home : Form
    {
        bool prt_flag = false;
        String indata;
        String  ack_char;


        public Home()
        {
           
            InitializeComponent();
            this.Load += Form1_Load;
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
              
            }
            temp_val.Value = 30;
            hu_val.Value = 70;
            lux_val.Value = 50;
        }

     

     

     
        private void updt_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("T" + temp_val.Value.ToString());
            serialPort1.WriteLine("H" + hu_val.Value.ToString());
            serialPort1.WriteLine("L" + lux_val.Value.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (prt_flag)
            {
                lion.Enabled = false;
                lioff .Enabled = false;
                c_off .Enabled = false;
                c_on.Enabled = false;
                e_on.Enabled = false;
                e_of .Enabled = false;

                li_bar.Enabled = false;
                c_fan_bar.Enabled = false;
                e_fan_bar.Enabled = false;
                serialPort1.WriteLine("auto");
               
            }

        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {

            if (prt_flag)
            {

                lion.Enabled = true;
                lioff.Enabled = true;
                c_off.Enabled = true;
                c_on.Enabled = true;
                e_on.Enabled = true;
                e_of.Enabled = true;


                li_bar.Enabled = true;
                c_fan_bar.Enabled = true;
                e_fan_bar.Enabled = true;


                serialPort1.WriteLine("manual");
            }

        }

        private void lion_Click(object sender, EventArgs e)
        {
            if (prt_flag)
            {
             //   lion.BackColor = Colo
                lion.Font = new Font("Arial", 9, FontStyle.Bold);
                lioff.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                serialPort1.WriteLine("lihi");
            }
        }

        private void lioff_Click(object sender, EventArgs e)
        {
            if (prt_flag)
            {
                lioff.Font = new Font("Arial", 9, FontStyle.Bold);
                lion.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);

                serialPort1.WriteLine("lioff");
            }
        }

        private void c_on_Click(object sender, EventArgs e)
        {
            if (prt_flag)
            {
                c_on.Font = new Font("Arial", 9, FontStyle.Bold);
                c_off.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                serialPort1.WriteLine("cfhi");
            }
        }

        private void c_off_Click(object sender, EventArgs e)
        {
            if (prt_flag)
            {

                c_off.Font = new Font("Arial", 9, FontStyle.Bold);
                c_on.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);


                serialPort1.WriteLine("cfoff");
            }
        }

        private void e_on_Click(object sender, EventArgs e)
        {
            if (prt_flag)
            {

                e_on.Font = new Font("Arial", 9, FontStyle.Bold);
                e_of.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);

                serialPort1.WriteLine("efhi");
            }
        }

        private void e_of_Click(object sender, EventArgs e)
        {
            if (prt_flag)
            {
                e_of.Font = new Font("Arial", 9, FontStyle.Bold);
                e_on.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);


                serialPort1.WriteLine("efoff");
            }
        }

        private void hz1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;


            tim.Text = now.ToShortTimeString();
            if (now.Second == 0)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
            }
            try
            {
                if (prt_flag)
                {
                  
                    serialPort1.ReadTimeout = 10;
                   indata = serialPort1.ReadLine().ToString();
                  
                    if (indata.StartsWith("T"))
                    {
                        tmplb.Font = new Font("Charlemagne Std", 15, FontStyle.Italic);
                        hlbl.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        luxlbl.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        //Century Gothic

                        tmplb.ForeColor = Color.Black  ;
                        hlbl.ForeColor = Color.Blue;
                        luxlbl.ForeColor = Color.Blue;

                        indata = indata.Replace("T", "");
                        tmplb.Text  = "Temp :- "+indata ;
                        chart1.Series["Temp"].Points.AddXY(now.Second, (indata));
                      
                    }
                    else if (indata.StartsWith("H"))
                    {

                        tmplb.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        hlbl.Font = new Font("Charlemagne Std", 15, FontStyle.Italic);
                        luxlbl.Font = new Font("Century Gothic", 11, FontStyle.Regular);

                        tmplb.ForeColor = Color.Blue;
                        hlbl.ForeColor = Color.Black;
                        luxlbl.ForeColor = Color.Blue;

                        indata = indata.Replace("H", "");
                        hlbl.Text = "Humidity :- " + indata;
                        chart1.Series["Humidity"].Points.AddXY(now.Second, (indata));
                    }
                    else if (indata.StartsWith("L"))
                    {

                        tmplb.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        hlbl.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                        luxlbl.Font = new Font("Charlemagne Std", 15, FontStyle.Italic);

                        tmplb.ForeColor = Color.Blue;
                        hlbl.ForeColor = Color.Blue;
                        luxlbl.ForeColor = Color.Black;

                        indata = indata.Replace("L", "");
                        luxlbl .Text = "Lux Level :- " + indata;
                        chart1.Series["LuxLevel"].Points.AddXY(now.Second, (indata));
                    }
                  
                }
               
            }
            catch
            {

            }
           
            
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {

            lion.Enabled = false;
            lioff.Enabled = false;
            c_off.Enabled = false;
            c_on.Enabled = false;
            e_on.Enabled = false;
            e_of.Enabled = false;

           
           // cmbSerialPorts.Items.Add(port); 
            string[] ports = SerialPort.GetPortNames();
          
            foreach (string port in ports)
            {
        
                var prt = port;
                try
                {
                   
                    serialPort1.PortName = prt.ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    ack_char = serialPort1.ReadLine().ToString();

                    con_lbl.Text = "searching.....";
                    con_lbl.ForeColor = Color.Red;
                   


                    // serialPort1.WriteLine("ok");

                    if (ack_char.IndexOf("2") >= 0)
                    {

                        for (int i = 0; i < 10; i++)
                        {
                            serialPort1.WriteLine("1");
                            Thread.Sleep(100);
                        }
                           

                        timer1.Enabled = false;

                        con_lbl.Text = "Found " + prt.ToString() ;
                        con_lbl.ForeColor = Color.Blue;
                        serialPort1.WriteLine("ok");
                        prt_flag = true;
                        hz1.Enabled = true;
                    }
                }
                catch
                {

                }

            }

           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("T" + temp_val.Value.ToString());
            serialPort1.WriteLine("H" + hu_val.Value.ToString());
            serialPort1.WriteLine("L" + lux_val.Value.ToString());
        }

        private void li_bar_Scroll(object sender, EventArgs e)
        {
            int d = li_bar.Value;
            if (d ==0 && prt_flag==true )
            {
                serialPort1.WriteLine("lioff");
            }
            else  if (d ==1 && prt_flag == true)
            {
                serialPort1.WriteLine("lilow");
            }
            else if (d ==2 && prt_flag == true)
            {
                serialPort1.WriteLine("limid");
            }
            else if (d ==3 && prt_flag == true)
            {
                serialPort1.WriteLine("lihi");
            }
        }

        private void c_fan_bar_Scroll(object sender, EventArgs e)
        {
            int d = c_fan_bar .Value;
            if (d == 0 && prt_flag == true)
            {
                serialPort1.WriteLine("cfoff");
            }
            else if (d == 1 && prt_flag == true)
            {
                serialPort1.WriteLine("cflow");
            }
            else if (d == 2 && prt_flag == true)
            {
                serialPort1.WriteLine("cfmid");
            }
            else if (d == 3 && prt_flag == true)
            {
                serialPort1.WriteLine("cfhi");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void e_fan_bar_Scroll(object sender, EventArgs e)
        {
            int d = e_fan_bar.Value;
            if (d == 0 && prt_flag == true)
            {
                serialPort1.WriteLine("efoff");
            }
            else if (d == 1 && prt_flag == true)
            {
                serialPort1.WriteLine("eflow");
            }
            else if (d == 2 && prt_flag == true)
            {
                serialPort1.WriteLine("efmid");
            }
            else if (d == 3 && prt_flag == true)
            {
                serialPort1.WriteLine("efhi");
            }
        }

        private void lgout_Click(object sender, EventArgs e)
        {
            this.Hide(); //hiding form 1
            Login M1 = new Login();//ing user Name to Second form so we can user Logged user Name
            M1.Show();
        }

       
    }
}
