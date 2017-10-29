using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepTek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += new System.EventHandler(this.btnButton_Click);
            button2.Click += new System.EventHandler(this.exitBtnButton_Click);

            MyApp myApp = new MyApp();
        }


        void btnButton_Click(object sender, EventArgs e)
        {
            // your code goes here
        }

        void exitBtnButton_Click(object sender, EventArgs e)
        {
            // your exit button code goes here
            System.Windows.Forms.Application.ExitThread();
        }


    }    
}
