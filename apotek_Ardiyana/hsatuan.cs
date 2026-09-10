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
    public partial class hsatuan : Form
    {
        public hsatuan()
        {
            InitializeComponent();
        }

        private void hobat_Load(object sender, EventArgs e)
        {         
                txtname.Focus();
        }
        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM satuan;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id"];
                string nm = "" + baris["nama_satuan"];

                dataGridView1.Rows.Add(id, nm);
            }
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Nama Satuan wajib diisi!");
                txtname.Focus();
                return;
            }
            

            string nm = txtname.Text;
            


            db.crud($"INSERT INTO satuan VALUES(null,'{nm}')");

            txtname.Clear();
  

            tampildata();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string nm = txtname.Text;
           


            db.crud($"UPDATE satuan SET nama_satuan = '{nm}' WHERE id = '{labelid.Text}';");

            txtname.Clear();
            
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

            if (kolom == 2)
            {
                db.crud($"SELECT * FROM satuan WHERE id = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id"];
                    string nm = "" + bariss["nama_satuan"];


                    labelid.Text = id;
                    txtname.Text = nm;

                }
            }

            if (kolom == 3)
            {
                MessageBox.Show("Apakah mau dihapus?" + idnya);
                db.crud($"DELETE FROM satuan WHERE id = '{idnya}';");
                tampildata();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpan.PerformClick();
            }
        }
    }
    }
    

