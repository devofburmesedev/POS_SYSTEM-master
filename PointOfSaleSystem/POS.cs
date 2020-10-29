﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Dashboard dForm = null;
        private Stocks sForm = null;
        private BuyList bForm = null;
        private UseCost usecostForm = null;
        private CreditList creditForm = null;
        private Stores storeForm = null;
        private SaleLiatMainForm saleForm = null;
        private BackUpAndRestore backForm = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.TopLevel = true;
            this.WindowState = FormWindowState.Maximized;
            this.Cursor = Cursors.Arrow;
            viewSaleList();
            
        }

        private void viewSaleList()
        {
            if (saleForm == null)
            {
                saleForm = new SaleLiatMainForm();
                saleForm.TopLevel = false;
                panel1.Controls.Add(saleForm);
                saleForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                saleForm.Dock = DockStyle.Fill;
                saleForm.Show();
            }
            else
            {
                saleForm.BringToFront();
            }
            button1.BackColor = Color.LightBlue;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
          
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
        }

        private void viewForm()
        {
            if (this.dForm == null)
            {
                dForm = new Dashboard();
                dForm.TopLevel = false;
                panel1.Controls.Add(dForm);
                dForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                dForm.Dock = DockStyle.Fill;
                dForm.Show();
            }
            else
            {
                dForm.BringToFront();
            }
        }

     

        
        private void button1_Click(object sender, EventArgs e)
        {
            viewSaleList();
        }
      

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (sForm == null)
            {
                sForm = new Stocks();
                sForm.TopLevel = false;
                panel1.Controls.Add(sForm);
                sForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                sForm.Dock = DockStyle.Fill;
                sForm.Show();
            }
            else
            {
                sForm.BringToFront();
            }
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightBlue;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
        }
        private void button3_Click(object sender, EventArgs e)
        {



            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightBlue;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
           
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
            viewForm();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (bForm == null)
            {
                bForm = new BuyList();
                bForm.TopLevel = false;
                panel1.Controls.Add(bForm);
                bForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                bForm.Dock = DockStyle.Fill;
                bForm.Show();
            }
            else
            {
                bForm.BringToFront();
            }
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightGray;
            
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (usecostForm == null)
            {
                usecostForm = new UseCost();
                usecostForm.TopLevel = false;
                panel1.Controls.Add(usecostForm);
                usecostForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                usecostForm.Dock = DockStyle.Fill;
                usecostForm.Show();
            }
            else
            {
                usecostForm.BringToFront();
            }
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightBlue;
           
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (creditForm == null)
            {
                creditForm = new CreditList();
                creditForm.TopLevel = false;
                panel1.Controls.Add(creditForm);
                creditForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                creditForm.Dock = DockStyle.Fill;
                creditForm.Show();
            }
            else
            {
                creditForm.BringToFront();
            }
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
           
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (storeForm == null)
            {
                storeForm = new Stores();
                storeForm.TopLevel = false;
                panel1.Controls.Add(storeForm);
                storeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                storeForm.Dock = DockStyle.Fill;
                storeForm.Show();
            }
            else
            {
                storeForm.BringToFront();
            }
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            
            button7.BackColor = Color.LightBlue;
            button8.BackColor = Color.LightGray;
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            if (backForm == null)
            {
                backForm = new BackUpAndRestore();
                backForm.TopLevel = false;
                panel1.Controls.Add(backForm);
                backForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                backForm.Dock = DockStyle.Fill;
                backForm.Show();
            }
            else
            {
                backForm.BringToFront();
            }
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightBlue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

     
    }
}
