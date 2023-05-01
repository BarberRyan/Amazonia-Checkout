using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public partial class Form_splash : Form
    {
        Timer timer = new Timer();
        int timerMax;
        int timerInterval = 10;

        Random r = new Random();
        int indexToRemove;
        int messageTime;

        List<string> statusMessages = new List<string>()
        {
            "Turbocharging the matter compressor",
            "Performing Dimensional Drift",
            "Setting Bachman-Turners to Overdrive",
            "Drinking 100 cups of coffee",
            "Reconfoobling the energy-mo-tron",
        };


        public Form_splash()
        {         
            InitializeComponent();
            versionLabel.Text += ConfigurationManager.AppSettings["appVersion"];
            timerMax = statusMessages.Count * 1000;
            messageTime = timerMax / statusMessages.Count;
        }

        private void splash_Load(object sender, EventArgs e)
        {
            progressBar.Maximum = timerMax;

            

            timer.Interval = timerInterval;
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }


        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value == timerMax)
            {
                timer.Stop();
                this.Close();
            }
            else
            {
                progressBar.Value += timerInterval;
            }
            
            if(progressBar.Value == 10 || (progressBar.Value % messageTime == 0 && progressBar.Value < timerMax))
            {
                statusLabel.Text = GetMessage();
            }
        }

        private string GetMessage()
        {
            indexToRemove = r.Next(0, statusMessages.Count);
            string output = statusMessages[indexToRemove];
            statusMessages.Remove(statusMessages[indexToRemove]);
            return output;
        }
    }
}
