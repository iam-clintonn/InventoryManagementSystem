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
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
