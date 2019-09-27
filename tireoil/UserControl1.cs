using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tireoil
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=oiltiredb;Integrated Security=True");
        int id;

        public UserControl1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnAdditem_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboName.Text!="" && comboCompany.Text!="" && txtCalibre.Text!="" && txtPrice.Text!=""&& txtCost.Text!="")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into product values('" + comboName.Text + "','" + comboCompany.Text + "','" + txtCalibre.Text + "','" + txtQuantity.Text + "','" + txtCost.Text + "','" + txtPrice.Text + "','" + txtNote.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();

                }
                else
                {
                    MessageBox.Show("Please enter all your data first");
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dataGridView1.Rows[index];
                txtpid.Text = selectedrow.Cells[0].Value.ToString();
                comboName.Text = selectedrow.Cells[1].Value.ToString();
                comboCompany.Text = selectedrow.Cells[2].Value.ToString();
                txtCalibre.Text = selectedrow.Cells[3].Value.ToString();
                txtQuantity.Text = selectedrow.Cells[4].Value.ToString();
                txtCost.Text = selectedrow.Cells[5].Value.ToString();
                txtPrice.Text = selectedrow.Cells[6].Value.ToString();
                txtNote.Text = selectedrow.Cells[7].Value.ToString();
            }
            catch 
            {
           
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpid.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update product set product='" + comboName.Text + "',company='" + comboCompany.Text + "',calibre='" + txtCalibre.Text + "',quantity='" + txtQuantity.Text + "',cost='" + txtCost.Text + "',price='" + txtPrice.Text + "',note='" + txtNote.Text + "' where pid='" + txtpid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                    MessageBox.Show("Product update Successfulyy");
                    txtpid.Text = "";
                    comboName.SelectedItem = null;
                    comboCompany.SelectedItem = null;
                    txtCalibre.Text = "";
                    txtQuantity.Text = "";
                    txtCost.Text = "";
                    txtPrice.Text = "";
                    txtNote.Text = "";
                }
                else
                {
                    MessageBox.Show("please double click on your row first ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDelteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpid.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from product where pid='" + txtpid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                    MessageBox.Show("Product delete Successfulyy");
                    txtpid.Text = "";
                    comboName.SelectedItem = null;
                    comboCompany.SelectedItem = null;
                    txtCalibre.Text = "";
                    txtQuantity.Text = "";
                    txtCost.Text = "";
                    txtPrice.Text = "";
                    txtNote.Text = "";
                }
                else
                {
                    MessageBox.Show("please double click on your row first ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpid.Text != "")
                {
                    id = int.Parse(txtpid.Text);
                    Form2 rc = new Form2();
                    rc.get(id.ToString());
                    rc.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
                    rc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("please double click on your row first ");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            comboName.SelectedItem = null;
            comboCompany.SelectedItem = null;
            txtCalibre.Text = "";
            txtQuantity.Text = "";
            txtCost.Text = "";
            txtPrice.Text = "";
            txtNote.Text = "";
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpid.Text = "";
            comboName.SelectedItem = null;
            comboCompany.SelectedItem = null;
            comboSearchName.SelectedItem = null;
            ComboSerachCompany.SelectedItem = null;
            txtCalibre.Text = "";
            txtQuantity.Text = "";
            txtCost.Text = "";
            txtPrice.Text = "";
            txtNote.Text = "";
            LoadData();
        }

        private void comboSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboSearchName.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where product = '" + comboSearchName.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                ComboSerachCompany.SelectedItem = null;
            }
        }

        private void ComboSerachCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( ComboSerachCompany.Text != "" && comboSearchName.Text!="")
            {
                con.Open();
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where company = '" + ComboSerachCompany.Text + "'  and product='"+comboSearchName.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

           

        }

        private void txtSerachcalibre_TextChanged(object sender, EventArgs e)
        {
            if (ComboSerachCompany.Text != "" && comboSearchName.Text != "" && txtSerachcalibre.Text!="")
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where company = '" + ComboSerachCompany.Text + "'  and product='" + comboSearchName.Text + "' and calibre='"+txtSerachcalibre.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
    }
}
