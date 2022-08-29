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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"");
        private void fillcombo()
        {
            // This method seeks to bond the CombpBox and the Datatbase
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CategoryName from CategoryTbl", Con);
            SqlDataReader rdr; 
            rdr = cmd.ExecuteReader();  
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CategoryName";
            CatCb.DataSource = dt;
           Con.Close();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            fillcombo();
            
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "")
                {
                    MessageBox.Show("Select Product To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProductId=" + ProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    //populate();
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        
            Category log = new Category();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Attendant log = new Attendant();
            this.Hide();
            log.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductPrice.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductQty.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();  

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values(" + ProductId.Text + ", '" + ProductName.Text + "', '" +ProductQty.Text + ", "+ProductPrice.Text+",'"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successefuly Added");
                Con.Close();
                //populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "" || ProductName.Text == "" || ProductPrice.Text == "" || ProductQty.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }

                else
                {
                    Con.Open();
                    string query = "update ProductTbl set CategoryName='" + ProductName.Text + "',ProductPrice='" + ProductPrice.Text + "'where ProductId=" + ProductId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    Con.Close();
                    //populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
