using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Add_Form : Form
    {
        string CS;
        public Add_Form()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Application.StartupPath, "Car rente.mdf");
             CS = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";

          }
      
        private string AddQ = "INSERT INTO Cars (Car_Model, Car_Color, Car_plate, Car_Compny) VALUES (@Car_Model,@Car_Color,@Car_plate,@Car_Compny)";

        private void Add_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_renteDataSet1.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.car_renteDataSet1.Cars);

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
            if(string.IsNullOrEmpty(txtName.Text)&& string.IsNullOrEmpty(txtcolor.Text)&& string.IsNullOrEmpty(txtcompny.Text)&& string.IsNullOrEmpty(txtplaet.Text))
            {
                MessageBox.Show("Please fill in all fields.","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();
                    SqlCommand cmd= new SqlCommand(AddQ, con);
                    cmd.Parameters.AddWithValue("@Car_Model", txtName.Text);
                    cmd.Parameters.AddWithValue("@Car_Color", txtcolor.Text);
                    cmd.Parameters.AddWithValue("@Car_plate", txtplaet.Text);
                    cmd.Parameters.AddWithValue("@Car_Compny", txtcompny.Text);
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtName.Text = "";
                txtplaet.Text = "";
                txtcompny.Text = "";
                txtcolor.Text = "";
                LoadCars();
                panel1.Enabled = false;
            }
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
    }
}
