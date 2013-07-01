using System;
using System.Windows.Forms;

namespace JenkinsTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                Environment.Exit(0);
            }
            else
            {
                progressBar1.Value++;
                Update();
            }
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonFail_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
