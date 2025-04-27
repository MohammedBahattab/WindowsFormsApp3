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

   
    public partial class Delete_Form : Form
    {
        public Delete_Form()
        {
            InitializeComponent();
        }
        private string CS = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\XPRISTO\\Desktop\\New folder (5)\\الجامعة\\OOP\\unv-ga\\WindowsFormsApp3\\Car rente.mdf\";Integrated Security=True";
        private string deletQ = "DELETE FROM Cars WHERE Id = @Id";
        private int selectedId = -1;


        private void Delete_Form_Load(object sender, EventArgs e)
        {
            LoadCars();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["Car_Model"].Value.ToString();
                txtplaet.Text = row.Cells["Car_Plate"].Value.ToString();
                txtcompny.Text = row.Cells["Car_Compny"].Value.ToString();
                txtcolor.Text = row.Cells["Car_Color"].Value.ToString();
                txtcusN.Text = row.Cells["Customer_Name"].Value.ToString();
                chIs.Checked = row.Cells["isRented"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["isRented"].Value);
                dataGridView1.AutoGenerateColumns = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chIs.Checked)
            {
                MessageBox.Show("A rental car cannot be deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(result == DialogResult.Yes)
                {
                    using (var con = new SqlConnection(CS))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(deletQ, con);
                        cmd.Parameters.AddWithValue("@id",selectedId);
                        cmd.ExecuteNonQuery();

                    }
                    txtName.Text = "";
                    txtplaet.Text = "";
                    txtcompny.Text = "";
                    txtcolor.Text = "";
                    txtcusN.Text = "";
                    chIs.Checked = false;
                    LoadCars();
                }
                else
                {
                    MessageBox.Show("The operation failed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
