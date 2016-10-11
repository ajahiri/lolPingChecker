using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace pingChecker_LOL
{
    public partial class Form1 : Form
    {
        //Variables
        //IP Adresses for LOL servers to ping. 
        string lolOceanicIP = "104.160.156.1";
        string lolNAIP = "104.160.131.3";
        string lolEUWIP = "104.160.141.3";
        string lolEUNEIP = "104.160.142.3";

        //Boolean values to determine whether or not to ping the server, also allows to toggle for each server.
        bool pingOCE = false;
        bool pingNA = false;
        bool pingEUW = false;
        bool pingEUNE = false;

        //String for SelectedServer Log Check (Specifically used in Streamwriter and savefile
        string selectedServer = "";

        //PingTime that can be calculated upon
        int pingNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OCEANIC PINGING
        /// </summary>
        public void pingOCEServer()
        {
            //Listener that will wait for the booleans to be triggered by the start/stop button.

            if (pingOCE == true)
            {
                Ping pingOCESender = new Ping();
                PingReply pingOCEReply = pingOCESender.Send(lolOceanicIP, 120);

                if (pingOCEReply.Status == IPStatus.Success)
                {
                    lolOceanicPing.Text = pingOCEReply.RoundtripTime + " ms";
                    if (logOceanic.Checked)
                    {
                        logPing(pingOCEReply.RoundtripTime + " ms \n");
                    }
                    if (pingOCEReply.RoundtripTime <= 100)
                    {
                        lolOceanicPing.ForeColor = Color.Green;
                    }
                    else if ((pingOCEReply.RoundtripTime > 100) &&(pingOCEReply.RoundtripTime <= 200))
                    {
                        lolOceanicPing.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        lolOceanicPing.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lolOceanicPing.Text = "Loss";
                    if (logOceanic.Checked)
                    {
                        logLoss();
                    }
                }
            }
        }

        private void lolOCETimer_Tick(object sender, EventArgs e)
        {
            pingOCEServer();
        }

        public void lolOceanicStart_Click(object sender, EventArgs e)
        {
            lolOCETimer.Enabled = true;
            pingOCE = true;
        }

        private void lolOceanicStop_Click(object sender, EventArgs e)
        {
            lolOCETimer.Enabled = false;
            pingOCE = false;
        }

        /// <summary>
        /// lolNA SERVER PINGING
        /// </summary>
        public void pingNAServer()
        {
            //Listener that will wait for the booleans to be triggered by the start/stop button.

            if (pingNA == true)
            {
                Ping pingNASender = new Ping();
                PingReply pingNAReply = pingNASender.Send(lolNAIP, 120);

                if (pingNAReply.Status == IPStatus.Success)
                {
                    lolNAPing.Text = pingNAReply.RoundtripTime + " ms";
                    if (logNA.Checked) { 
                        logPing(pingNAReply.RoundtripTime + " ms \n");
                    }
                    if (pingNAReply.RoundtripTime <= 100)
                    {
                        lolNAPing.ForeColor = Color.Green;
                    }
                    else if ((pingNAReply.RoundtripTime > 100) && (pingNAReply.RoundtripTime <= 200))
                    {
                        lolNAPing.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        lolNAPing.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lolNAPing.Text = "Loss";
                    if (logNA.Checked)
                    {
                        logLoss();
                    }
                }
            }
        }

        private void lolNATimer_Tick(object sender, EventArgs e)
        {
            pingNAServer();
        }

        public void lolNAStart_Click(object sender, EventArgs e)
        {
            lolNATimer.Enabled = true;
            pingNA = true;
        }

        private void lolNAStop_Click(object sender, EventArgs e)
        {
            lolNATimer.Enabled = false;
            pingNA = false;
            
        }

        /// <summary>
        /// lolEUW SERVER PINGING
        /// </summary>
        public void pingEUWServer()
        {
            //Listener that will wait for the booleans to be triggered by the start/stop button.

            if (pingEUW == true)
            {
                Ping pingEUWSender = new Ping();
                PingReply pingEUWReply = pingEUWSender.Send(lolEUWIP, 120);

                if (pingEUWReply.Status == IPStatus.Success)
                {
                    lolEUWPing.Text = pingEUWReply.RoundtripTime + " ms";
                    if (logEUW.Checked)
                    {
                        logPing(pingEUWReply.RoundtripTime + " ms \n");
                    }
                    if (pingEUWReply.RoundtripTime <= 100)
                    {
                        lolEUWPing.ForeColor = Color.Green;
                    }
                    else if ((pingEUWReply.RoundtripTime > 100) && (pingEUWReply.RoundtripTime <= 200))
                    {
                        lolEUWPing.ForeColor = Color.GreenYellow;
                    }
                    else
                    {
                        lolEUWPing.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lolEUWPing.Text = "Loss";
                    if (logEUW.Checked)
                    {
                        logLoss();
                    }
                }
            }
        }

        private void lolEUWTimer_Tick(object sender, EventArgs e)
        {
            pingEUWServer();
        }

        public void lolEUWStart_Click(object sender, EventArgs e)
        {
            lolEUWTimer.Enabled = true;
            pingEUW = true;
        }

        private void lolEUWStop_Click(object sender, EventArgs e)
        {
            lolEUWTimer.Enabled = false;
            pingEUW = false;
        }

        /// <summary>
        /// lolEUNE SERVER PINGING
        /// </summary>
        public void pingEUNEServer()
        {
            //Listener that will wait for the booleans to be triggered by the start/stop button.

            if (pingEUNE == true)
            {
                Ping pingEUNESender = new Ping();
                PingReply pingEUNEReply = pingEUNESender.Send(lolEUNEIP, 120);

                if (pingEUNEReply.Status == IPStatus.Success)
                {
                    lolEUNEPing.Text = pingEUNEReply.RoundtripTime + " ms";
                    if (logEUNE.Checked)
                    {
                        logPing(pingEUNEReply.RoundtripTime + " ms \n");
                    }
                    if (pingEUNEReply.RoundtripTime <= 100)
                    {
                        lolEUNEPing.ForeColor = Color.Green;
                    }
                    else if ((pingEUNEReply.RoundtripTime > 100) && (pingEUNEReply.RoundtripTime <= 200))
                    {
                        lolEUNEPing.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        lolEUNEPing.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lolEUNEPing.Text = "Loss";
                    if (logEUNE.Checked)
                    {
                        logLoss();
                    }
                }
            }
        }

        private void lolEUNETimer_Tick(object sender, EventArgs e)
        {
            pingEUNEServer();
        }

        public void lolEUNEStart_Click(object sender, EventArgs e)
        {
            lolEUNETimer.Enabled = true;
            pingEUNE = true;
        }

        private void lolEUNEStop_Click(object sender, EventArgs e)
        {
            lolEUNETimer.Enabled = false;
            pingEUNE = false;
        }


        /// <summary>
        /// Link to website
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://arian.tech/");
        }


        /// <summary>
        /// This function will exit the app when exit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Function will show information about the program when clicking about button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This simple program allows players to get an estimate of their ping before joining a LoL match. This program was made by Arian Jahiri (https://arian.tech).");
        }

        /// <summary>
        /// Logging Functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void logPing(string pingTime)
        {
            logBox.AppendText(pingTime + "| T: " + pingNumber + " s\n");
            pingNumber++;
        }


        private void logLoss()
        {
            logBox.AppendText("Loss | T: " + pingNumber + "\n");
            pingNumber++;
        }

        private void logOceanic_CheckedChanged(object sender, EventArgs e)
        {
            logBox.Clear();
            selectedServer = "Oceanic";
            pingNumber = 0;
        }

        private void logNA_CheckedChanged(object sender, EventArgs e)
        {
            logBox.Clear();
            selectedServer = "NorthAmerica";
            pingNumber = 0;
        }

        private void logEUW_CheckedChanged(object sender, EventArgs e)
        {
            logBox.Clear();
            selectedServer = "EUWest";
            pingNumber = 0;
        }

        private void logEUNE_CheckedChanged(object sender, EventArgs e)
        {
            logBox.Clear();
            selectedServer = "EU-NE";
            pingNumber = 0;
        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "LoL_Ping_Checker_" + selectedServer + "_" + dateTime.ToString("dd-MM-yyyy");
            sfd.Title = "Save Log File";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string saveLocation = sfd.FileName;
                StreamWriter sw = new StreamWriter(saveLocation);
                sw.WriteLine(logBox.Text);
                sw.Close();
            }


        }
    }
}
