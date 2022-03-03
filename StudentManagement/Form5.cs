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
    public partial class Form5 : Form
    {
        string datasource = "BAHAU";
        string database = "STUDENT_MANAGEMENT";
        string username = "sa";
        string password = "2411";
        string query = "";
        SqlConnection connection = null;
        SqlCommand command = null;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Select();

            ViewListOfStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO STUDENT VALUES (@StudentID, @StudentName, @ClassID)";
            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", textBox1.Text);
            command.Parameters.AddWithValue("@StudentName", textBox2.Text);
            command.Parameters.AddWithValue("@ClassID", textBox3.Text);

            try
            {
                connection.Open();

                var rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    connection.Close();
                    ViewListOfStudents();
                    Clear();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Insert Failed");
            }
            finally
            {
                connection.Close();
            }
        }

        public void ViewListOfStudents()
        {
            studentsView.Columns.Clear();
            studentsView.Items.Clear();

            studentsView.GridLines = true;
            studentsView.FullRowSelect = true;
            studentsView.View = View.Details;

            studentsView.Columns.Add("Student ID", 130);
            studentsView.Columns.Add("Student Name", 200);
            studentsView.Columns.Add("Class ID", 130);

            query = "SELECT * FROM STUDENT";
            connection = DBUtils.GetDBConnection(datasource, database, username, password);

            command = new SqlCommand(query, connection);
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

        public void Clear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "UPDATE STUDENT             \n" +
                    "SET Name = @StudentName,   \n" +
                        "ClassID = @ClassID     \n" +
                    "WHERE StudentID = @StudentID";

            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", textBox1.Text);
            command.Parameters.AddWithValue("@StudentName", textBox2.Text);
            command.Parameters.AddWithValue("@ClassID", textBox3.Text);

            connection.Open();
            var rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                connection.Close();
                ViewListOfStudents();
                Clear();
            }
            else
            {
                MessageBox.Show("Insert Failed");
            }
            connection.Close();
        }

        private void studentsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(studentsView.SelectedItems.Count > 0)
            {
                textBox1.Text = studentsView.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = studentsView.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = studentsView.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM STUDENT WHERE StudentID = @StudentID";
            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", textBox1.Text);
            connection.Open();
            var rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                connection.Close();
                MessageBox.Show("Delete successfully");
                ViewListOfStudents();

                Clear();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            connection.Close(); 
        }
    }
}
