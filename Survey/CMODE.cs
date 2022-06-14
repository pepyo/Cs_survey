using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Survey
{
    public partial class CMODE : MetroForm
    {
        public CMODE()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Control control = new Control(metroTextBox1.Text);
            flowLayoutPanel1.Controls.Add(control);
            
        }

        private void CMODE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
