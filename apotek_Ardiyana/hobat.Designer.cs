
namespace apotek_Ardiyana
{
    partial class hobat
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
            this.harga = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.deskripsi = new System.Windows.Forms.Label();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.kandungan = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.image2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelid = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.txtkandungan = new System.Windows.Forms.TextBox();
            this.namaobat = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.Location = new System.Drawing.Point(12, 134);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(41, 13);
            this.harga.TabIndex = 62;
            this.harga.Text = "Harga";
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(113, 131);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(150, 20);
            this.txtharga.TabIndex = 61;
            this.txtharga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtharga_KeyDown);
            this.txtharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharga_KeyPress);
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskripsi.Location = new System.Drawing.Point(12, 101);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(59, 13);
            this.deskripsi.TabIndex = 60;
            this.deskripsi.Text = "Deskripsi";
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.Location = new System.Drawing.Point(113, 94);
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(150, 20);
            this.txtdeskripsi.TabIndex = 59;
            this.txtdeskripsi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdeskripsi_KeyDown);
            // 
            // kandungan
            // 
            this.kandungan.AutoSize = true;
            this.kandungan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kandungan.Location = new System.Drawing.Point(12, 61);
            this.kandungan.Name = "kandungan";
            this.kandungan.Size = new System.Drawing.Size(71, 13);
            this.kandungan.TabIndex = 58;
            this.kandungan.Text = "Kandungan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Kategori_id,
            this.nama_obat,
            this.Column1,
            this.column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.image,
            this.image2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 167);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Kategori_id
            // 
            this.Kategori_id.HeaderText = "Kategori Id";
            this.Kategori_id.Name = "Kategori_id";
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.Name = "nama_obat";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kandungan";
            this.Column1.Name = "Column1";
            // 
            // column2
            // 
            this.column2.HeaderText = "Deskripsi";
            this.column2.Name = "column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stok";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // image
            // 
            this.image.HeaderText = "";
            this.image.Name = "image";
            // 
            // image2
            // 
            this.image2.HeaderText = "";
            this.image2.Name = "image2";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 3);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(37, 13);
            this.labelid.TabIndex = 56;
            this.labelid.Text = "labelid";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(516, 179);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(147, 20);
            this.txtsearch.TabIndex = 54;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.LightCyan;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(90, 173);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(112, 26);
            this.btnUbah.TabIndex = 53;
            this.btnUbah.Text = "Ubah Data";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btntampil
            // 
            this.btntampil.BackColor = System.Drawing.Color.LightCyan;
            this.btntampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampil.Location = new System.Drawing.Point(208, 173);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(106, 26);
            this.btntampil.TabIndex = 52;
            this.btntampil.Text = "Tampil Data";
            this.btntampil.UseVisualStyleBackColor = false;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // txtkandungan
            // 
            this.txtkandungan.Location = new System.Drawing.Point(113, 58);
            this.txtkandungan.Name = "txtkandungan";
            this.txtkandungan.Size = new System.Drawing.Size(150, 20);
            this.txtkandungan.TabIndex = 51;
            this.txtkandungan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkandungan_KeyDown);
            // 
            // namaobat
            // 
            this.namaobat.AutoSize = true;
            this.namaobat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaobat.Location = new System.Drawing.Point(12, 28);
            this.namaobat.Name = "namaobat";
            this.namaobat.Size = new System.Drawing.Size(70, 13);
            this.namaobat.TabIndex = 50;
            this.namaobat.Text = "Nama Obat";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(113, 21);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(150, 20);
            this.txtname.TabIndex = 49;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(13, 173);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 48;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Stok";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(388, 19);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(150, 20);
            this.txtstok.TabIndex = 63;
            this.txtstok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtstok_KeyDown);
            this.txtstok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstok_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Search";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(388, 58);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(150, 21);
            this.cmbstatus.TabIndex = 67;
            this.cmbstatus.DropDown += new System.EventHandler(this.cmbstatus_DropDown);
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            this.cmbstatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbstatus_KeyDown);
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(388, 94);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(150, 21);
            this.cmbkategori.TabIndex = 69;
            this.cmbkategori.DropDown += new System.EventHandler(this.cmbkategori_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Kategori";
            // 
            // hobat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 378);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.txtdeskripsi);
            this.Controls.Add(this.kandungan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.txtkandungan);
            this.Controls.Add(this.namaobat);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnSimpan);
            this.Name = "hobat";
            this.Text = "hobat";
            this.Load += new System.EventHandler(this.hobat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.Label kandungan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.TextBox txtkandungan;
        private System.Windows.Forms.Label namaobat;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn image2;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Label label1;
    }
}