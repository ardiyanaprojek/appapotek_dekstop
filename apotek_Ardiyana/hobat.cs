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
    public partial class hobat : Form
    {
        public hobat()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM obat;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id"];
                string ki = "" + baris["kategori_id"];
                string nm = "" + baris["nama_obat"];
                string kd = "" + baris["kandungan"];
                string dk = "" + baris["deskripsi"];
                string hg = "" + baris["harga"];
                string st = "" + baris["stok"];
                string ss = "" + baris["status"];
                


                dataGridView1.Rows.Add(id, ki, nm, kd, dk, hg, st, ss);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Nama Obat wajib diisi!");
                txtname.Focus();
                return;
            }
            
            else if (string.IsNullOrWhiteSpace(txtkandungan.Text))
            {
                MessageBox.Show("Kandungan wajib diisi!");
                txtkandungan.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtdeskripsi.Text))
            {
                MessageBox.Show("Deskripsi wajib diisi!");
                txtdeskripsi.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtharga.Text))
            {
                MessageBox.Show("Harga wajib diisi!");
                txtharga.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtstok.Text))
            {
                MessageBox.Show("Stok wajib diisi!");
                txtstok.Focus();
                return;
            }
            if (cmbstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih status");
                cmbstatus.Focus();
                return;
            }
            if (cmbkategori.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih kategori");
                cmbkategori.Focus();
                return;
            }

            string nm = txtname.Text;
            string kd = txtkandungan.Text;
            string dk = txtdeskripsi.Text;
            string ha = txtharga.Text;
            string sk = txtstok.Text;
            string st = cmbstatus.SelectedItem.ToString();
            string kt = cmbkategori.SelectedValue.ToString();


            db.crud($"INSERT INTO obat VALUES(null,'{kt}','{nm}','{kd}','{dk}','{ha}','{sk}','{st}');");

            txtname.Clear();
            txtkandungan.Clear();
            txtdeskripsi.Clear();
            txtharga.Clear();
            txtstok.Clear();
            cmbstatus.ResetText();
            cmbkategori.ResetText();

            tampildata();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtkandungan.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtkandungan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdeskripsi.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtdeskripsi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtharga.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtharga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtstok.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtstok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbstatus.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbstatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpan.PerformClick();
            }
        }

        private void hobat_Load(object sender, EventArgs e)
        {
            cmbstatus.Focus();
        }

        private void cmbstatus_DropDown(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("resep");
            cmbstatus.Items.Add("non resep");
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string nm = txtname.Text;
            string kd = txtkandungan.Text;
            string dk = txtdeskripsi.Text;
            int ha = int.Parse(txtharga.Text);
            string sk = txtstok.Text;
            string st = cmbstatus.SelectedItem.ToString();
            string kt = cmbkategori.SelectedValue.ToString();


            db.crud($"UPDATE obat SET kategori_id = '{kt}',nama_obat = '{nm}', kandungan = '{kd}', deskripsi = '{dk}',harga = '{ha}', stok = '{sk}', status = '{st}' WHERE id = '{labelid.Text}';");

            txtname.Clear();
            txtkandungan.Clear();
            txtdeskripsi.Clear();
            txtharga.Clear();
            txtname.Clear();
            txtkandungan.Clear();
            cmbstatus.ResetText();
            cmbkategori.ResetText();

            tampildata();
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbkategori_DropDown(object sender, EventArgs e)
        {
            db.crud("SELECT id, nama_kategori FROM kategori");

            cmbkategori.DataSource = db.ds.Tables[0];
            cmbkategori.DisplayMember = "nama_kategori";
            cmbkategori.ValueMember = "id";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 8)
            {
                db.crud($"SELECT * FROM obat WHERE id = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id"];
                    string ki = "" + bariss["kategori_id"];
                    string nm = "" + bariss["nama_obat"];
                    string kd = "" + bariss["kandungan"];
                    string dk = "" + bariss["deskripsi"];
                    string hg = "" + bariss["harga"];
                    string st = "" + bariss["stok"];
                    string ss = "" + bariss["status"];


                    labelid.Text = id;
                    cmbkategori.Text = ki;
                    txtname.Text = nm;
                    txtkandungan.Text = kd;
                    txtdeskripsi.Text = dk;
                    txtharga.Text = hg;
                    txtstok.Text = st;
                    cmbstatus.Text = ss;


                }
            }

            if (kolom == 9)
            {
                DialogResult hasil = MessageBox.Show("Apakah mau dihapus? " + idnya, "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);

                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM obat WHERE id = '{idnya}'");
                    tampildata();
                }
            }
        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
