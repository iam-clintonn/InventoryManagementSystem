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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryId.Text == "")
                {
                    MessageBox.Show("Select Category To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CategoryId=" + CategoryId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                }
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
            Product F1 = new Product();
            this.Hide();
            F1.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Attendant log = new Attendant();
            this.Hide();
            log.Show();
        }

        SqlConnection Con = new SqlConnection(@""); 
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try 
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + CategoryId.Text + ", '"+ CategoryName.Text + "', '" + CategoryDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successefuly Added");
                Con.Close();
                populate();
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); 
            sda.Fill(ds);
            CategoryDGV.DataSource = ds.Tables[0];    
            Con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryId.Text = CategoryDGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryName.Text = CategoryDGV.SelectedRows[0].Cells[1].Value.ToString();
            CategoryDesc.Text = CategoryDGV.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try 
            {
                if (CategoryId.Text == "" || CategoryName.Text == "" || CategoryDesc.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }

                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CategoryName='" + CategoryName.Text + "',CategoryDesc='" + CategoryDesc.Text + "'where CategoryId=" + CategoryId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully");
                    Con.Close();
                    populate();
                }
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
    }
}
