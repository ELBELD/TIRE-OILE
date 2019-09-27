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

namespace tireoil
{
    public partial class Form2 : Form
    {
        string b;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=oiltiredb;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
            
        }
        public void LoadQuantity()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select product,company,calibre,quantity,price from product where pid='" + txtpid.Text + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtname.Text= ((myreader[0].ToString()));
                    txtcompany.Text = ((myreader[1].ToString()));
                    txtCalibre.Text = ((myreader[2].ToString()));
                    txtStockQuantity.Text = ((myreader[3].ToString()));
                    txtPrice.Text = (myreader[4].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void get(string x)
        {
            b = x.ToString();
            txtpid.Text = b;
            LoadQuantity();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text != "")
                {
                    int x = int.Parse(txtQuantity.Text);
                    int y = int.Parse(txtPrice.Text);
                    int z = x * y;
                    lbltotalPrice.Text = z.ToString();
                }
                else
                {
                    if(txtQuantity.Text=="")
                    {
                        lbltotalPrice.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtQuantity.Text!="")
                {
                    int x = int.Parse(txtStockQuantity.Text);
                    int y = int.Parse(txtQuantity.Text);
                    int z = x - y;
                    if (x>=y)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update product set quantity='" + z +"' where pid = '"+txtpid.Text+"' ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("out of stock ");
                    }
                }
                else
                {
                    MessageBox.Show("please enter your quantity first ");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
