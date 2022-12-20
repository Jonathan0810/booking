using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace booking
{
    public partial class confirm : Form
    {
        public confirm()
        {
            InitializeComponent();
        }

        private void confirm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment Confirmed!");
            Application.Exit();

        }
    }
}
