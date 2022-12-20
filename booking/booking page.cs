using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace booking
{
    public partial class booking_page : Form
    {
        public booking_page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-B0GKAUGQ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            CHECK check = new CHECK();
            check.Show();
            Visible = false;
        }
    }
}
