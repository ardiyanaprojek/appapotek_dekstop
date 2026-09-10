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
    public partial class hrole : Form
    {
        public hrole()
        {
            InitializeComponent();
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM role;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string nm = "" + baris["nama_role"];
                string dk = "" + baris["deskripsi"];
               
                dataGridView1.Rows.Add(id, nm, dk);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Nama role wajib diisi!");
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


            db.crud($"INSERT INTO role VALUES(null,'{nm}','{ps}');");

            txtname.Clear();
            txtdesk.Clear();

            tampildata();
        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string nm = txtname.Text;
            string dk = txtdesk.Text;
            

            db.crud($"UPDATE role SET nama_role = '{nm}', deskripsi = '{dk}' WHERE id_role = '{labelid.Text}';");

            txtname.Clear();
            txtdesk.Clear();
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 3)
            {
                db.crud($"SELECT * FROM role WHERE id_role = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id_role"];
                    string nm = "" + bariss["nama_role"];
                    string dk = "" + bariss["deskripsi"];
                    

                    labelid.Text = id;
                    txtname.Text = nm;
                    txtdesk.Text = dk;
                    
                }
            }

            if (kolom == 4)
            {
                MessageBox.Show("Apakah mau dihapus?" + idnya);
                db.crud($"DELETE FROM role WHERE id_role = '{idnya}';");
                tampildata();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelid_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void deskripsi_Click(object sender, EventArgs e)
        {

        }

        private void hrole_Load(object sender, EventArgs e)
        {
            
                txtname.Focus();
               
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdesk.Focus();
                e.SuppressKeyPress = true;
            }
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
