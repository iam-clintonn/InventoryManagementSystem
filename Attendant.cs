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

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
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
            Category log = new Category();
            this.Hide();
            log.Show();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
