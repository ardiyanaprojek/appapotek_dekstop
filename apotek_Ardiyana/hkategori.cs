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
    public partial class hkategori : Form
    {
        public hkategori()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM kategori;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id"];
                string nm = "" + baris["nama_kategori"];
                string dk = "" + baris["keterangan"];

                dataGridView1.Rows.Add(id, nm, dk);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Nama Kategori wajib diisi!");
                txtname.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtdesk.Text))
            {
                MessageBox.Show("deskripsi wajib diisi!");
                txtdesk.Focus();
                return;
            }

            string nm = txtname.Text;
            string ps = txtdesk.Text;


            db.crud($"INSERT INTO kategori VALUES(null,'{nm}','{ps}');");

            txtname.Clear();
            txtdesk.Clear();

            tampildata();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string nm = txtname.Text;
            string dk = txtdesk.Text;


            db.crud($"UPDATE kategori SET nama_kategori = '{nm}', keterangan = '{dk}' WHERE id = '{labelid.Text}';");

            txtname.Clear();
            txtdesk.Clear();
            tampildata();
        }

        private void labelid_Click(object sender, EventArgs e)
        {

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

            if (kolom == 2)
            {
                db.crud($"SELECT * FROM kategori WHERE id = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id"];
                    string nm = "" + bariss["nama_kategori"];
                    string dk = "" + bariss["keterangan"];


                    labelid.Text = id;
                    txtname.Text = nm;
                    txtdesk.Text = dk;

                }
            }

            if (kolom == 3)
            {
                MessageBox.Show("Apakah mau dihapus?" + idnya);
                db.crud($"DELETE FROM kategori WHERE id = '{idnya}';");
                tampildata();
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdesk.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void hkategori_Load(object sender, EventArgs e)
        {
            
                txtname.Focus();
               
        }

        private void txtdesk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpan.PerformClick();
            }
        }
    }
}
