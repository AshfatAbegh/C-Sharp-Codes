using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_Project_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            eProduct.Name = txtName.Text;

            OProduct oProduct = new OProduct();
            int check = oProduct.insert(eProduct);

            if(check >= 0)
            {
                MessageBox.Show("Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            eProduct.Name = txtName.Text;

            OProduct oProduct = new OProduct();
            int check = oProduct.delete(eProduct);

            if (check >= 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }*/
    }
}
