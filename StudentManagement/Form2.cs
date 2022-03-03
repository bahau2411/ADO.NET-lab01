using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form2 : Form
    {
        SqlConnection connection = null;
        
        public Form2()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string datasource = "BAHAU";
            string database = "STUDENT_MANAGEMENT";
            string username = "sa";
            string password = "2411";
            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Successfully!");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open) { 
                connection.Close();
                MessageBox.Show("Disconnect Successfully");
            }
        }

        
    }
}
