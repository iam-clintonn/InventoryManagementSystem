using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Product log = new Product();
            this.Hide();
            log.Show(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Attendant log = new Attendant();
            this.Hide();
            log.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Category log = new Category();
            this.Hide();
            log.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Interface.FrmMain log = new Interface.FrmMain();
            this.Hide();
            log.Show();
        }
    }
}
