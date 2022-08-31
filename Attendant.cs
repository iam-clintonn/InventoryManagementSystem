using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class Attendant : Form
    {
        public Attendant()
        {
            InitializeComponent();
        }

        private void Attendant_Load(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"");


        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendantName.Text == "" || AttendantId.Text == "" || AttendantAge.Text == "" || AttendantPhone.Text == "" || AttendantPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }

                else
                {
                    Con.Open();
                    string query = "update AttendantTbl set AttendantName='" + AttendantName.Text + "',AttendantAge='" + AttendantAge.Text + "'where AttendantId=" + AttendantId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Information Updated Successfully");
                    Con.Close();
                    //populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendantId.Text == "")
                {
                    MessageBox.Show("Select Attendant To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from AttenantTbl where AttendantId=" + AttendantId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Deleted Successfully");
                    Con.Close();
                    //populate();
                    AttendantId.Text = "";
                    AttendantName.Text = "";
                    AttendantAge.Text = "";
                    AttendantPhone.Text = "";
                    AttendantPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into AttendantTbl values(" + AttendantId.Text + ", '" + AttendantName.Text + "', '" + AttendantAge.Text + ", " + AttendantPhone.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendant Successefuly Added");
                Con.Close();
                //populate();
                Con.Close();
                //populate();
                AttendantId.Text = "";
                AttendantName.Text = "";
                AttendantAge.Text = "";
                AttendantPhone.Text = "";
                AttendantPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Product log = new Product();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Category log = new Category();
            this.Hide();
            log.Show();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendantId.Text = AttendantDGV.SelectedRows[0].Cells[0].Value.ToString();
            AttendantName.Text = AttendantDGV.SelectedRows[0].Cells[1].Value.ToString();
            AttendantAge.Text = AttendantDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttendantPhone.Text = AttendantDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttendantPassword.Text = AttendantDGV.SelectedRows[0].Cells[4].Value.ToString();
            
        }
    }
}
