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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string CS = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\XPRISTO\\Desktop\\New folder (5)\\الجامعة\\OOP\\unv-ga\\WindowsFormsApp3\\Car rente.mdf\";Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            add_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Form delete_Form = new Delete_Form();
            delete_Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car_Rental car_Rental = new Car_Rental();
            car_Rental.Show();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(CS))
            {
                conn.Open();

                string query = @"
            UPDATE Cars
               SET 
                isRented = 0,
                Customer_ID = NULL,
                Customer_Name = NULL,
                Customer_Age = NULL,
                Start_Rented_Date = NULL,
                End_Rented_Date = NULL
            WHERE End_Rented_Date < GETDATE() AND isRented = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show($"تم إنهاء تأجير {affected} سيارة بسبب انتهاء المدة.");
                }
            }
        }
    }
}
