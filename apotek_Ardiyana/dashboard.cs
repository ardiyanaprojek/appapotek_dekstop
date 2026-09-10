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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            husers form = new husers() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hrole form = new hrole() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hkategori form = new hkategori() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hsatuan form = new hsatuan() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hsupplier form = new hsupplier() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hobat form = new hobat() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ftransaksi form = new Ftransaksi() { TopLevel = false, TopMost = true };
            kf.untukForm(form, panel3);
        }
    }
}
