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

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
