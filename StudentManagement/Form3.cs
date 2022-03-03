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
    public partial class Form3 : Form
    {
        string datasource = "BAHAU";
        string database = "STUDENT_MANAGEMENT";
        string username = "sa";
        string password = "2411";
        SqlConnection connection = null;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            enteredClassID.Text = "";
            classIDTextBox.Text = "";
            nameTextBox.Text = "";
            yearTextBox.Text = "";
        }

        private void viewDetailsBtn_Click(object sender, EventArgs e)
        {
            
            string query = "select * from CLASS WHERE ClassID = @ClassID";
            connection = DBUtils.GetDBConnection(datasource, database, username, password);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassID", enteredClassID.Text);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader(); 

            if(reader.Read())
            {
                classIDTextBox.Text = reader.GetString(0);
                nameTextBox.Text = reader.GetString(1);
                yearTextBox.Text = reader.GetInt32(2).ToString();
            }
            else
            {
                MessageBox.Show("Not found the class with ID " + enteredClassID.Text);
            }
        }

        private void viewListBtn_Click(object sender, EventArgs e)
        {
            
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Student ID", 100);
            listView1.Columns.Add("Student Name", 200);
            listView1.Columns.Add("Class ID", 130);

            string[] arr = new string[3];
            string query = "SELECT * FROM STUDENT WHERE ClassID = @ClassID";
            connection = DBUtils.GetDBConnection(datasource, database, username, password);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassID", enteredClassID.Text);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                string studentID = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classID = reader.GetString(2);

                ListViewItem item = listView1.Items.Add(studentID);
                item.SubItems.Add(studentName);
                item.SubItems.Add(classID);

            }
            
            connection.Close();
        }
    }
}
