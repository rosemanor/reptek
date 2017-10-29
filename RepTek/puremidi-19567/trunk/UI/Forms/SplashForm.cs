using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.geekpedia.com");
            Thread.Sleep(2000);
        }

        
    }
}