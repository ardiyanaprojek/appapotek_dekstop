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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pw = txtpassword.Text;

            db.crud($"select *from users where nama_user = '{user}' and password = SHA1('{pw}') ");
            int cekjumahbaris = db.ds.Tables[0].Rows.Count;
            Console.WriteLine(cekjumahbaris);

            if (cekjumahbaris == 1)
            {
                DataRow baris = db.ds.Tables[0].Rows[0];

                dashboard admin = new dashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username / password salah");
                
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnlogin.PerformClick();
            }
        }
    }
}
