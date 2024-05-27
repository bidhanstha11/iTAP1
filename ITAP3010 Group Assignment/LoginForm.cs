using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITAP3010_Group_Assignment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.LoginButtonClick.Click += new System.EventHandler(this.LoginButtonClick);
        }

        // Replace with your actual connection string details
        private string connectionString = "Data Source=ICHIGO\\MSSQLSERVER01;Initial Catalog=MilkBarRetail;Integrated Security=True";

        private void LoginButtonClick(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection opened successfully."); // Debug message

                    // Example query to validate credentials and retrieve role
                    string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";

                    // Use parameterized queries for security
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    string userRole = (string)command.ExecuteScalar();
                    MessageBox.Show("Query executed."); // Debug message

                    if (userRole != null) // Login successful
                    {
                        MessageBox.Show("Login successful! User role: " + userRole); // Debug message
                        Form nextForm;

                        switch (userRole)
                        {
                            case "Manager":
                                nextForm = new Form2(); // Replace with actual form name
                                break;
                            case "Cashier":
                                nextForm = new OpenCashierDashboard(); // Replace with actual form name
                                break;
                            default:
                                nextForm = null; // Handle invalid role
                                MessageBox.Show("Invalid user role. Please contact administrator.");
                                break;
                        }

                        if (nextForm != null)
                        {
                            nextForm.Show();
                            this.Hide(); // Hide the current form instead of closing it abruptly
                        }
                    }
                    else
                    {
                        // Display error message
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (SqlException ex)
                {
                    // Handle database connection or query execution errors
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close(); // Ensure connection is closed
                        MessageBox.Show("Database connection closed."); // Debug message
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
