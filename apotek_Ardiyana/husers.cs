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
    public partial class husers : Form
    {
        public husers()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT users.id, users.nama_user, users.password, role.nama_role FROM users INNER JOIN role ON users.id_role = role.id_role; ");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id"];
                string nm = "" + baris["nama_user"];
                string pw = "" + baris["password"];
                string rl = "" + baris["nama_role"];
                dataGridView1.Rows.Add(id, nm, pw, rl);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (string.IsNullOrWhiteSpace(txtuser.Text))
            {
                MessageBox.Show("Nama user wajib diisi!");
                txtuser.Focus();
                return;
            }else if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Paaword wajib diisi!");
                txtpassword.Focus();
                return;
            }

            if (cmbhak.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih hak akses!");
                cmbhak.Focus();
                return;
            }
            string nm = txtuser.Text;
            string ps = txtpassword.Text;
            string hk = cmbhak.SelectedValue.ToString();
           

            db.crud($"INSERT INTO users VALUES(null,'{nm}',SHA1('{ps}'),'{hk}');");

            txtuser.Clear();
            txtpassword.Clear();
            cmbhak.ResetText();
            tampildata();
        }

        private void cmbhak_DropDown(object sender, EventArgs e)
        {
            db.crud("SELECT id_role, nama_role FROM role");

            cmbhak.DataSource = db.ds.Tables[0];
            cmbhak.DisplayMember = "nama_role";
            cmbhak.ValueMember = "id_role";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 4)
            {
                db.crud($"SELECT * FROM users WHERE id = '{idnya}'");
                foreach (DataRow bariss in db.ds.Tables[0].Rows)
                {
                    string id = "" + bariss["id"];
                    string nm = "" + bariss["nama_user"];
                    string pw = "" + bariss["password"];
                    string hk = "" + bariss["id_role"];

                    labelid.Text = id;
                    txtuser.Text = nm;
                    txtpassword.Text = pw;
                    cmbhak.Text = hk;
                }
            }

            if (kolom == 5)
            {
                MessageBox.Show("Apakah mau dihapus?" + idnya);
                db.crud($"DELETE FROM users WHERE id = '{idnya}';");
                tampildata();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string nm = txtuser.Text;
            string pw = txtpassword.Text;
            string hk = cmbhak.SelectedValue.ToString();

            db.crud($"UPDATE users SET nama_user = '{nm}', password = '{pw}', id_role = '{hk}' WHERE id = '{labelid.Text}';");

            txtuser.Clear();
            txtpassword.Clear();
            cmbhak.ResetText();
            tampildata();
        }

        private void cmbhak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void husers_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelid_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void hak_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpan.PerformClick();
            }
        }

        private void cmbhak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpan.PerformClick();
            }
        }
    }
}
