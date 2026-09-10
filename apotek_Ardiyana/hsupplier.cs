using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek_Ardiyana
{
    public partial class hsupplier : Form
    {
        public hsupplier()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM supplier;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id"];
                string nm = "" + baris["nama_supplier"];
                string al = "" + baris["alamat"];
                string hp = "" + baris["no_hp"];
                string em = "" + baris["email"];

                dataGridView1.Rows.Add(id, nm, al, hp, em);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Nama supplier wajib diisi!");
                txtname.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtalamat.Text))
            {
                MessageBox.Show("alamat wajib diisi!");
                txtalamat.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtnohp.Text))
            {
                MessageBox.Show("no hp wajib diisi!");
                txtnohp.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("email wajib diisi!");
                txtemail.Focus();
                return;
            }


            string nm = txtname.Text;
            string al = txtalamat.Text;
            string hp = txtnohp.Text;
            string em = txtemail.Text;



            db.crud($"INSERT INTO supplier VALUES(null,'{nm}','{al}','{hp}','{em}');");

            txtname.Clear();
            txtalamat.Clear();
            txtnohp.Clear();
            txtemail.Clear();
            tampildata();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string nm = txtname.Text;
            string al = txtalamat.Text;
            string hp = txtnohp.Text;
            string em = txtemail.Text;

            db.crud($"UPDATE supplier SET nama_supplier = '{nm}', alamat = '{al}', no_hp = '{hp}',email = '{em}' WHERE id = '{labelid.Text}';");

            txtname.Clear();
            txtalamat.Clear();
            txtnohp.Clear();
            txtemail.Clear();
            tampildata();
        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 5)
            {
                db.crud($"SELECT * FROM supplier WHERE id = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id"];
                    string nm = "" + bariss["nama_supplier"];
                    string al = "" + bariss["alamat"];
                    string hp = "" + bariss["no_hp"];
                    string em = "" + bariss["email"];


                    labelid.Text = id;
                    txtname.Text = nm;
                    txtalamat.Text = al;
                    txtnohp.Text = hp;
                    txtemail.Text = em;
                    tampildata();
                }
            }

            if (kolom == 6)
            {
                MessageBox.Show("Apakah mau dihapus?" + idnya);
                db.crud($"DELETE FROM supplier WHERE id = '{idnya}';");
                tampildata();
            }
        }

        private void hsupplier_Load(object sender, EventArgs e)
        {
            
                txtname.Focus();
               
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtalamat.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtalamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnohp.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtnohp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpan.PerformClick();
            }
        }

        private void txtnohp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }
    
