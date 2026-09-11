
namespace apotek_Ardiyana
{
    partial class Ftransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbobat = new System.Windows.Forms.ComboBox();
            this.labelid = new System.Windows.Forms.Label();
            this.btntambah = new System.Windows.Forms.Button();
            this.kode_transaksi = new System.Windows.Forms.Label();
            this.txtkodetransaksi = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.kasir = new System.Windows.Forms.Label();
            this.txtkasir = new System.Windows.Forms.TextBox();
            this.tanggal = new System.Windows.Forms.Label();
            this.dgvtransaksi = new System.Windows.Forms.DataGridView();
            this.obat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.obat = new System.Windows.Forms.Label();
            this.textharga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txp = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbobat
            // 
            this.cmbobat.FormattingEnabled = true;
            this.cmbobat.Location = new System.Drawing.Point(85, 65);
            this.cmbobat.Name = "cmbobat";
            this.cmbobat.Size = new System.Drawing.Size(150, 21);
            this.cmbobat.TabIndex = 90;
            this.cmbobat.DropDown += new System.EventHandler(this.cmbobat_DropDown);
            this.cmbobat.SelectedIndexChanged += new System.EventHandler(this.cmbobat_SelectedIndexChanged);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 2);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(37, 13);
            this.labelid.TabIndex = 78;
            this.labelid.Text = "labelid";
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.LightCyan;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.Location = new System.Drawing.Point(719, 65);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 26);
            this.btntambah.TabIndex = 74;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // kode_transaksi
            // 
            this.kode_transaksi.AutoSize = true;
            this.kode_transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_transaksi.Location = new System.Drawing.Point(12, 27);
            this.kode_transaksi.Name = "kode_transaksi";
            this.kode_transaksi.Size = new System.Drawing.Size(82, 13);
            this.kode_transaksi.TabIndex = 72;
            this.kode_transaksi.Text = "No Transaksi";
            // 
            // txtkodetransaksi
            // 
            this.txtkodetransaksi.Location = new System.Drawing.Point(130, 20);
            this.txtkodetransaksi.Name = "txtkodetransaksi";
            this.txtkodetransaksi.Size = new System.Drawing.Size(150, 20);
            this.txtkodetransaksi.TabIndex = 71;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(729, 196);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 70;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // kasir
            // 
            this.kasir.AutoSize = true;
            this.kasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasir.Location = new System.Drawing.Point(588, 23);
            this.kasir.Name = "kasir";
            this.kasir.Size = new System.Drawing.Size(35, 13);
            this.kasir.TabIndex = 82;
            this.kasir.Text = "Kasir";
            // 
            // txtkasir
            // 
            this.txtkasir.Location = new System.Drawing.Point(638, 20);
            this.txtkasir.Name = "txtkasir";
            this.txtkasir.Size = new System.Drawing.Size(150, 20);
            this.txtkasir.TabIndex = 81;
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(304, 23);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(112, 13);
            this.tanggal.TabIndex = 80;
            this.tanggal.Text = "Tanggal Transaksi";
            // 
            // dgvtransaksi
            // 
            this.dgvtransaksi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obat_id,
            this.nama_obat,
            this.jumlah,
            this.harga,
            this.subtotal,
            this.image});
            this.dgvtransaksi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvtransaksi.Location = new System.Drawing.Point(0, 226);
            this.dgvtransaksi.Name = "dgvtransaksi";
            this.dgvtransaksi.Size = new System.Drawing.Size(800, 224);
            this.dgvtransaksi.TabIndex = 79;
            // 
            // obat_id
            // 
            this.obat_id.HeaderText = "obat_id";
            this.obat_id.Name = "obat_id";
            this.obat_id.Visible = false;
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.Name = "nama_obat";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // image
            // 
            this.image.HeaderText = "";
            this.image.Name = "image";
            // 
            // obat
            // 
            this.obat.AutoSize = true;
            this.obat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obat.Location = new System.Drawing.Point(10, 69);
            this.obat.Name = "obat";
            this.obat.Size = new System.Drawing.Size(70, 13);
            this.obat.TabIndex = 84;
            this.obat.Text = "Nama Obat";
            // 
            // textharga
            // 
            this.textharga.Location = new System.Drawing.Point(294, 65);
            this.textharga.Name = "textharga";
            this.textharga.Size = new System.Drawing.Size(150, 20);
            this.textharga.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Harga";
            // 
            // textqty
            // 
            this.textqty.Location = new System.Drawing.Point(506, 65);
            this.textqty.Name = "textqty";
            this.textqty.Size = new System.Drawing.Size(38, 20);
            this.textqty.TabIndex = 93;
            this.textqty.TextChanged += new System.EventHandler(this.textqty_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "QTY";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(57, 200);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(150, 20);
            this.txttotal.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Total";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(613, 66);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 97;
            // 
            // txp
            // 
            this.txp.AutoSize = true;
            this.txp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txp.Location = new System.Drawing.Point(555, 69);
            this.txp.Name = "txp";
            this.txp.Size = new System.Drawing.Size(54, 13);
            this.txp.TabIndex = 98;
            this.txp.Text = "Subtotal";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(423, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 99;
            // 
            // Ftransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txp);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textharga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbobat);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.kode_transaksi);
            this.Controls.Add(this.txtkodetransaksi);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.kasir);
            this.Controls.Add(this.txtkasir);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.dgvtransaksi);
            this.Controls.Add(this.obat);
            this.Name = "Ftransaksi";
            this.Text = "Ftransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbobat;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Label kode_transaksi;
        private System.Windows.Forms.TextBox txtkodetransaksi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label kasir;
        private System.Windows.Forms.TextBox txtkasir;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.DataGridView dgvtransaksi;
        private System.Windows.Forms.Label obat;
        private System.Windows.Forms.TextBox textharga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label txp;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridViewTextBoxColumn obat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}