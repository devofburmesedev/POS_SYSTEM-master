﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PointOfSaleSystem
{
    public partial class CustomerCreditLists : Form
    {
        public CustomerCreditLists()
        {
            InitializeComponent();
            BindGrid();
        }

        private void CustomerCreditLists_Load(object sender, EventArgs e)
        {

        }
        private void BindGrid()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns.Clear();
                DataGridViewCellStyle style = dataGridView1.ColumnHeadersDefaultCellStyle;
                style.BackColor = Color.Green;
                style.ForeColor = Color.White;

                style.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                DataGridViewColumn id = new DataGridViewTextBoxColumn();
                id.Name = "id";
                id.HeaderText = "စဉ်";
                id.DataPropertyName = "No.";
                id.Width = 50;
                dataGridView1.Columns.Insert(0, id);
                DataGridViewColumn voucher = new DataGridViewTextBoxColumn();
                voucher.Name = "Id";
                voucher.HeaderText = "ဘောင်ချာနံပါတ်";
                voucher.DataPropertyName = "id";
                voucher.Width = 130;
                dataGridView1.Columns.Insert(1, voucher);
                DataGridViewColumn cname = new DataGridViewTextBoxColumn();
                cname.Name = "CName";
                cname.HeaderText = "ဝယ်ယူသူအမည်";
                cname.DataPropertyName = "CName";
                cname.Width = 150;
                dataGridView1.Columns.Insert(2, cname);

                DataGridViewColumn price = new DataGridViewTextBoxColumn();
                price.Name = "price";
                price.HeaderText = "ပေးချေငွေ";
                price.DataPropertyName = "price";
                price.Width = 150;
                dataGridView1.Columns.Insert(3, price);
                DataGridViewColumn Tprice = new DataGridViewTextBoxColumn();
                Tprice.Name = "price";
                Tprice.HeaderText = "စုစုပေါင်းငွေ";
                Tprice.DataPropertyName = "price";
                Tprice.Width = 150;
                dataGridView1.Columns.Insert(4, Tprice);
                DataGridViewColumn date = new DataGridViewTextBoxColumn();
                date.Name = "date";
                date.HeaderText = "ရက်စွဲ";
                date.DataPropertyName = "date";
                date.Width = 160;
                dataGridView1.Columns.Insert(5, date);
                dataGridView1.DataSource = null;
                SqlConnection con = new MyConnection().GetConnection();
                SqlCommand cmd;
                
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * From Voucher Where isCredit=@credit";
                    cmd.Parameters.AddWithValue("@credit", "true");
                    SqlDataReader reader = cmd.ExecuteReader();
                    int v_id=0;
                    if (reader.HasRows)
                    {
                        int i = 1;
                        while (reader.Read())
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataGridView1);
                            newRow.Cells[0].Value = i;
                            newRow.Cells[1].Value = reader["V_id"].ToString();
                            newRow.Cells[2].Value = reader["CustomerName"].ToString();
                            newRow.Cells[3].Value = Convert.ToDouble(reader["Paid_Amount"].ToString())+getMore(Convert.ToInt32(reader["V_id"].ToString()));
                            newRow.Cells[4].Value = reader["Total_Amount"].ToString();
                            newRow.Cells[5].Value = reader["DateAndTime"].ToString();
                            i++;
                            dataGridView1.Rows.Add(newRow);
                            
                        }
                    }

                }
                catch
                {


                }
                finally
                {
                    con.Close();
                }
                
            }
            catch
            {

            }

        }
        double amounts = 0;
        private double getMore(int p)
        {
            SqlConnection con = new MyConnection().GetConnection();
                SqlCommand cmd;
            
           try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * From HistoryPayment Where V_id=@v_id";
                    cmd.Parameters.AddWithValue("@v_id",p );
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        
                        while (reader.Read())
                        {
                           
                          
                            amounts +=Convert.ToDouble( reader["Amount"].ToString());
                            

                        }
                    }

                }
                catch
                {


                }
                finally
                {
                    con.Close();
                }
            return amounts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
