using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp3
{
    public partial class Car_Rental : Form
    {
        public Car_Rental()
        {
            InitializeComponent();
            LoadAvailableCars();
        }
        private string CS = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\XPRISTO\\Desktop\\New folder (5)\\الجامعة\\OOP\\unv-ga\\WindowsFormsApp3\\Car rente.mdf\";Integrated Security=True";
        private string re = "UPDATE Cars SET isRented = 1, Start_Rented_Date = @StartDate, End_Rented_Date = @EndDate, Customer_ID = @CustomerId, Customer_Name = @CustomerName,Customer_Age=@CustomerAge WHERE Id = @CarID";
        private void Car_Rental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_renteDataSet2.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.car_renteDataSet2.Cars);
            LoadAvailableCars();
            LoadCars();

        }
        private void LoadCars()
        {

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cars", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void LoadAvailableCars()
        {
            
            using (SqlConnection conn = new SqlConnection(CS))
            {
              
                    conn.Open();

                    string query = "SELECT Id, (Car_Model + ' - ' + Car_plate) AS Display FROM Cars WHERE ISNULL(isRented, 0) = 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    comboBox1.DisplayMember = "Display";
                    comboBox1.ValueMember = "Id";
                    comboBox1.DataSource = table;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text)&& string.IsNullOrEmpty(textBox1.Text)&& string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int carId = Convert.ToInt32(comboBox1.SelectedValue);

                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(re, con);
                   cmd.Parameters.AddWithValue("@CarID", carId);
                   cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);
                   cmd.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);
                   cmd.Parameters.AddWithValue("@CustomerId", textBox3.Text);
                   cmd.Parameters.AddWithValue("@CustomerName", textBox1.Text);
                   cmd.Parameters.AddWithValue("@CustomerAge", textBox2.Text);
                    cmd.ExecuteNonQuery();

                }
                LoadCars();
            }
        }
    }
}
