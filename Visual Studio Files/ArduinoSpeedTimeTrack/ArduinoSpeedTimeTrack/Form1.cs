/*
 
         							Copyright (c) 2016 Conor Walsh
         						  Website: http://www.conorwalsh.net
	                            GitHub:  https://github.com/conorwalsh
	                     					Project: Arduino Speed Time Track

				Permission is hereby granted, free of charge, to any person obtaining a copy
				of this software and associated documentation files (the "Software"), to deal
				in the Software without restriction, including without limitation the rights
				to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
				copies of the Software, and to permit persons to whom the Software is
				furnished to do so, subject to the following conditions:
				
				The above copyright notice and this permission notice shall be included in all
				copies or substantial portions of the Software.
				
				THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
				IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
				FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
				AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
				LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
				OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
				SOFTWARE.
		    _____      ____                        __        __    _     _       ____   ___  _  __   
		   / ___ \    / ___|___  _ __   ___  _ __  \ \      / /_ _| |___| |__   |___ \ / _ \/ |/ /_  
		  / / __| \  | |   / _ \| '_ \ / _ \| '__|  \ \ /\ / / _` | / __| '_ \    __) | | | | | '_ \ 
		 | | (__   | | |__| (_) | | | | (_) | |      \ V  V / (_| | \__ \ | | |  / __/| |_| | | (_) |
		  \ \___| /   \____\___/|_| |_|\___/|_|       \_/\_/ \__,_|_|___/_| |_| |_____|\___/|_|\___/ 
		   \_____/                                                                                   

 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace ArduinoSerialTest
{
    public partial class Form1 : Form
    {

        SerialPort currentPort;
        bool portFound;

        double speed1f = 0;
        double speed2f = 0;
        double speed3f = 0;
        double speed4f = 0;

        double acc1f = 0;
        double acc2f = 0;
        double acc3f = 0;

        double time1 = 0;
        double time2 = 0;
        double time3 = 0;
        double time4 = 0;

        int testno = 0;

        private void SetComPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, 9600);
                    if (DetectArduino())
                    {
                        portFound = true;
                        break;
                    }
                    else
                    {
                        portFound = false;

                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        private bool DetectArduino()
        {
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[5];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                buffer[4] = Convert.ToByte(4);

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;

                currentPort.Open();
                currentPort.Write(buffer, 0, 5);
                Thread.Sleep(1000);

                int count = currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }

                currentPort.Close();

                if (returnMessage.Contains("HELLO FROM ARDUINO"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private string ReadArduino()
        {
            try
            {
                currentPort.Open();

                currentPort.DiscardInBuffer();
                currentPort.DiscardOutBuffer();

                int count = 1;
                string returnMessage = "";
                while (count > 0)
                {
                    returnMessage = returnMessage + currentPort.ReadLine();
                    count--;
                }

                currentPort.Close();

                return returnMessage;
            }
            catch (Exception e)
            {
                return "fail";
            }
        }

        private bool runTest()
        {
            button2.Enabled = false;
            button2.Text = "Test Running";
            String message1 = ReadArduino();
            testno++;

            if (message1.Contains("inf"))
            {
                speed1.Text = "Failed Test";
                speedk1.Text = "Failed Test";

                speed2.Text = "Failed Test";
                speedk2.Text = "Failed Test";

                speed3.Text = "Failed Test";
                speedk3.Text = "Failed Test";

                speed4.Text = "Failed Test";
                speedk4.Text = "Failed Test";

                timel1.Text = "Failed Test";
                timel2.Text = "Failed Test";
                timel3.Text = "Failed Test";
                timel4.Text = "Failed Test";

                acc1.Text = "Failed Test";
                acc2.Text = "Failed Test";
                acc3.Text = "Failed Test";

                textBox1.AppendText(testno.ToString() + ": Failed Test" + Environment.NewLine);
            }
            else
            {

                String[] speeds = message1.Split(':');
                speed1.Text = speeds[0] + "m/s";
                speedk1.Text = Math.Round((double.Parse(speeds[0]) * 3.6), 2).ToString() + "km/h";
                speed1f = double.Parse(speeds[0]);

                speed2.Text = speeds[1] + "m/s";
                speedk2.Text = Math.Round((double.Parse(speeds[1]) * 3.6), 2).ToString() + "km/h";
                speed2f = double.Parse(speeds[1]);

                speed3.Text = speeds[2] + "m/s";
                speedk3.Text = Math.Round((double.Parse(speeds[2]) * 3.6), 2).ToString() + "km/h";
                speed3f = double.Parse(speeds[2]);

                speed4.Text = speeds[3] + "m/s";
                speedk4.Text = Math.Round((double.Parse(speeds[3]) * 3.6), 2).ToString() + "km/h";
                speed4f = double.Parse(speeds[3]);

                time1 = double.Parse(speeds[4]) / 1000;
                time2 = (double.Parse(speeds[5]) / 1000) - time1;
                time3 = (double.Parse(speeds[6]) / 1000) - time1;
                time4 = (double.Parse(speeds[7]) / 1000) - time1;
                time1 = 0;

                timel1.Text = Math.Round(time1, 2).ToString() + "s";
                timel2.Text = Math.Round(time2, 2).ToString() + "s";
                timel3.Text = Math.Round(time3, 2).ToString() + "s";
                timel4.Text = Math.Round(time4, 2).ToString() + "s";


                //Alternate acceleration Calculation method using distance instead of time
                //distance between sensors in metres
                /*double sensordist = 0.26;
                acc1f = Math.Round(((speed2f * speed2f) - (speed1f * speed1f)) / (2 * sensordist), 2);
                acc1.Text = acc1f.ToString() + "m/s²";

                acc2f = Math.Round(((speed3f * speed3f) - (speed2f * speed2f)) / (2 * sensordist), 2);
                acc2.Text = acc2f.ToString() + "m/s²";

                acc3f = Math.Round(((speed4f * speed4f) - (speed3f * speed3f)) / (2 * sensordist), 2);
                acc3.Text = acc3f.ToString() + "m/s²";*/

                acc1f = Math.Round(((speed2f - speed1f) / (time2 - time1)), 2);
                acc1.Text = acc1f.ToString() + "m/s²";

                acc2f = Math.Round(((speed3f - speed2f) / (time3 - time2)), 2);
                acc2.Text = acc2f.ToString() + "m/s²";

                acc3f = Math.Round(((speed4f - speed3f) / (time4 - time3)), 2);
                acc3.Text = acc3f.ToString() + "m/s²";

                String formatedmsg = testno.ToString() + ": " + speed1.Text + ", " + speed2.Text + ", " + speed3.Text + ", " + speed4.Text + ", " + timel1.Text + ", " + timel2.Text + ", " + timel3.Text + ", " + timel4.Text + ", " + acc1.Text + ", " + acc2.Text + ", " + acc3.Text;

                textBox1.AppendText(formatedmsg + Environment.NewLine);

                chart1.Series["Series1"].Points.Clear();

                chart1.ChartAreas[0].AxisX.Maximum = time4;

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0.00}s";
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0.00}m/s";

                chart1.Series["Series1"].Points.AddXY(time1, speed1f);
                chart1.Series["Series1"].Points.AddXY(time2, speed2f);
                chart1.Series["Series1"].Points.AddXY(time3, speed3f);
                chart1.Series["Series1"].Points.AddXY(time4, speed4f);

                chart1.Visible = true;

                panel2.Visible = true;

                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }

            button2.Text = "Run Test";
            button2.Enabled = true;
            
            return true;
            
        }

        private bool runConnect()
        {
            statusConnection.Text = "Disconnected";
            SetComPort();
            if (portFound == true)
            {
                statusConnection.Text = "Connected";
                button2.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;
                button1.Visible = false;
                button3.Visible = true;
            }
            else
            {
                statusConnection.Text = "Disconnected - Failed";
            }
            return true;
        }

        private bool runDisconnect()
        {
            currentPort.Close();
            currentPort.Dispose();
            button3.Visible = false;
            button1.Visible = true;
            statusConnection.Text = "Disconnected";
            button2.Enabled = false;
            button4.Enabled = false;
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            runConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runTest();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            runDisconnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.T)
            {
                runTest();
            }
            else if (e.KeyCode == Keys.C)
            {
                runConnect();
            }
            else if (e.KeyCode == Keys.D)
            {
                runDisconnect();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";

            saveFileDialog.FileName = "Speed_Time_Graph_" + DateTime.Now.ToString("dd-MMM-yyyy_HH-mm-ss") + ".png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chart1.SaveImage(saveFileDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chart1.SaveImage(saveFileDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save Readout as Text File";

            saveFileDialog.FileName = "Speed_Time_Readout_" + DateTime.Now.ToString("dd-MMM-yyyy_HH-mm-ss") + ".txt";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://conorwalsh.net/");
        }
    }

}
