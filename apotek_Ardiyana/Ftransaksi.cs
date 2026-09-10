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
    public partial class Ftransaksi : Form
    {
        public Ftransaksi()
        {
            InitializeComponent();
        }

        private void HitungTotal()
        {
            int total = 0;

            foreach (DataGridViewRow row in dgvtransaksi.Rows)
            {
                if (row.IsNewRow)
                    continue;

                total += Convert.ToInt32(row.Cells["subtotal"].Value);
            }

            txttotal.Text = total.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (dgvtransaksi.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada obat yang ditambahkan!");
                return;
            }


            string kode = txtkodetransaksi.Text;
            string tanggal = date.Value.ToString("yyyy-MM-dd");
            string user_id = txtkasir.Text;
            string total = txttotal.Text;

            // Simpan ke tabel transaksi
            string sqlTransaksi = "INSERT INTO transaksi " + "(kode_transaksi, tanggal, user_id, total_harga) " + "VALUES ('" + kode + "', '" + tanggal + "', '" + user_id + "', '" + total + "')";

            db.crud(sqlTransaksi);

            // Ambil ID transaksi yang baru saja disimpan
            db.crud("SELECT id FROM transaksi WHERE kode_transaksi = '" + kode + "'");

            int transaksi_id = Convert.ToInt32(db.ds.Tables[0].Rows[0]["id"]);

            // Simpan semua obat ke detail_transaksi
            foreach (DataGridViewRow row in dgvtransaksi.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int obat_id = Convert.ToInt32(row.Cells["obat_id"].Value);
                int jumlah = Convert.ToInt32(row.Cells["jumlah"].Value);
                int harga = Convert.ToInt32(row.Cells["harga"].Value);
                int subtotal = Convert.ToInt32(row.Cells["subtotal"].Value);

                string sqlDetail = "INSERT INTO detail_transaksi " +
                "(transaksi_id, obat_id, jumlah, harga, subtotal) " +
                "VALUES ('" + transaksi_id + "', '" + obat_id + "', '" +
                jumlah + "', '" + harga + "', '" + subtotal + "')";

                db.crud(sqlDetail);
            }

            MessageBox.Show("Transaksi berhasil disimpan!");

            dgvtransaksi.Rows.Clear();
            txttotal.Clear();
        }

        private void cmbobat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbobat.SelectedIndex == -1)
                return;

            DataRowView row = cmbobat.SelectedItem as DataRowView;

            if (row != null)
            {
                textharga.Text = row["harga"].ToString();
            }
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if (cmbobat.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih obat terlebih dahulu!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textqty.Text))
            {
                MessageBox.Show("Silakan masukkan QTY!");
                return;
            }

            int qty;

            if (!int.TryParse(textqty.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("QTY harus berupa angka!");
                return;
            }

            // Ambil data obat dari ComboBox
            DataRowView obat = (DataRowView)cmbobat.SelectedItem;

            int idObat = Convert.ToInt32(obat["id"]);
            string namaObat = obat["nama_obat"].ToString();
            int harga = Convert.ToInt32(obat["harga"]);

            int subtotal = harga * qty;

            // Masukkan ke DataGridView
            dgvtransaksi.Rows.Add(
                idObat,
                namaObat,
                qty,
                harga,
                subtotal
                
            );

            // Hitung total
            HitungTotal();

            // Kosongkan input obat
            cmbobat.SelectedIndex = -1;
            textharga.Clear();
            textqty.Clear();
        }

        private void cmbobat_DropDown(object sender, EventArgs e)
        {
            db.crud("SELECT id, nama_obat, harga  FROM obat");

            cmbobat.DataSource = db.ds.Tables[0];
            cmbobat.DisplayMember = "nama_obat";
            cmbobat.ValueMember = "id";
        }

        private void textqty_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textqty.Text) || string.IsNullOrWhiteSpace(textharga.Text))
            {
                txtsubtotal.Clear();
                return;
            }

            int harga;
            int qty;

            if (int.TryParse(textharga.Text, out harga) &&
                int.TryParse(textqty.Text, out qty))
            {
                int subtotal = harga * qty;
                txtsubtotal.Text = subtotal.ToString();
            }
        }
    }
}
