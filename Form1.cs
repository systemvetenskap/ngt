using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;
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


            using (SqlConnection conn = new SqlConnection())
            {   //port och ssl kan inte användas uppkoppling fungerar =)
                conn.ConnectionString = "Server=weblabb.miun.se;Database=pgmvaru_g4;User Id=pgmvaru_g4;Password=trapets;";
                MessageBox.Show("Connection successful");
            }
            
            
    
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connection successful");
        }
    }
}
