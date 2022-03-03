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

namespace StudentManagement {
    public partial class Form4 : Form
    {
        string datasource = "BAHAU";
        string database = "STUDENT_MANAGEMENT";
        string username = "sa";
        string password = "2411";
        SqlConnection connection = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            string query = "SELECT * FROM CLASS";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetInt32(2));
            }
            connection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentsView.Columns.Clear();
            studentsView.Items.Clear();

            studentsView.GridLines = true;
            studentsView.FullRowSelect = true;
            studentsView.View = View.Details;

            studentsView.Columns.Add("Student ID", 130);
            studentsView.Columns.Add("Student Name", 200);
            studentsView.Columns.Add("Class ID", 130);

            if (listBox1.SelectedIndex == -1) return;

            string line = listBox1.SelectedItem.ToString();
            string[] arr = line.Split('-');
            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            string query = "SELECT * FROM STUDENT WHERE ClassID = @ClassID";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", arr[0].Trim());
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classID = reader.GetString(2);

                ListViewItem item = studentsView.Items.Add(studentID);
                item.SubItems.Add(studentName);
                item.SubItems.Add(classID);
            }
            connection.Close();
        }
    }
}


