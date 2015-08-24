using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("develop branch. Erik lägger till text");
            MessageBox.Show("develop branch. john lägger till text");
            MessageBox.Show("Erik");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
