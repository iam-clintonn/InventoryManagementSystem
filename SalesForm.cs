﻿using System;
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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent("SalesForm");
        }

        private void InitializeComponent(string v)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (BillId.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values(" + BillId.Text + ", '" + AttendantNameLbl.Text + "', '" + DateLbl.Text + "', " + AmountLbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successefuly Added");
                    Con.Close();
                    populatebill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ProductQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"");
        private void populate()
        {
            Con.Open();
            string query = "select ProductName, ProductQty  from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populatebill()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void SalesForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1; 
        }

        int flag = 0;
        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductName.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductPrice.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        int Grdtotal = 0, n = 0;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            if (ProductName.Text == "" || ProductQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProductPrice.Text) * Convert.ToInt32(ProductQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProductName.Text;
                newRow.Cells[2].Value = ProductPrice.Text;
                newRow.Cells[3].Value = ProductQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProductPrice.Text) * Convert.ToInt32(ProductQty.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                AmountLbl.Text = "" + Grdtotal;
            }

        }

        private void ORDERDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
