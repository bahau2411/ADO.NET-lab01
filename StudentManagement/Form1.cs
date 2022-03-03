using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
       
        SqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            string datasource = "BAHAU";
            string database = "STUDENT_MANAGEMENT";
            string username = "sa";
            string password = "2411";

            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            string query = "SELECT COUNT (*) FROM STUDENT WHERE ClassID = @ClassID";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", textBox1.Text);

            int result = (int) command.ExecuteScalar();

            textBox2.Text = result.ToString();
            connection.Close();
        }

        
    }
}