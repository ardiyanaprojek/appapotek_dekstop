
namespace apotek_Ardiyana
{
    partial class hrole
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
            this.deskripsi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.image2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.txtdesk = new System.Windows.Forms.TextBox();
            this.namarole = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskripsi.Location = new System.Drawing.Point(12, 63);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(55, 13);
            this.deskripsi.TabIndex = 43;
            this.deskripsi.Text = "Desjripsi";
            this.deskripsi.Click += new System.EventHandler(this.deskripsi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_role,
            this.nama_role,
            this.desk,
            this.image,
            this.image2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 167);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_role
            // 
            this.id_role.HeaderText = "id role";
            this.id_role.Name = "id_role";
            // 
            // nama_role
            // 
            this.nama_role.HeaderText = "Nama Role";
            this.nama_role.Name = "nama_role";
            // 
            // desk
            // 
            this.desk.HeaderText = "Deskripsi";
            this.desk.Name = "desk";
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
            this.labelid.Location = new System.Drawing.Point(12, 5);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 41;
            this.labelid.Text = "id";
            this.labelid.Click += new System.EventHandler(this.labelid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Search";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(516, 181);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(147, 20);
            this.txtsearch.TabIndex = 39;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.LightCyan;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(89, 121);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(112, 26);
            this.btnUbah.TabIndex = 38;
            this.btnUbah.Text = "Ubah Data";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btntampil
            // 
            this.btntampil.BackColor = System.Drawing.Color.LightCyan;
            this.btntampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampil.Location = new System.Drawing.Point(207, 121);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(106, 26);
            this.btntampil.TabIndex = 37;
            this.btntampil.Text = "Tampil Data";
            this.btntampil.UseVisualStyleBackColor = false;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // txtdesk
            // 
            this.txtdesk.Location = new System.Drawing.Point(113, 60);
            this.txtdesk.Name = "txtdesk";
            this.txtdesk.Size = new System.Drawing.Size(150, 20);
            this.txtdesk.TabIndex = 36;
            this.txtdesk.Text = "-";
            this.txtdesk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdesk_KeyDown);
            // 
            // namarole
            // 
            this.namarole.AutoSize = true;
            this.namarole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namarole.Location = new System.Drawing.Point(12, 30);
            this.namarole.Name = "namarole";
            this.namarole.Size = new System.Drawing.Size(69, 13);
            this.namarole.TabIndex = 35;
            this.namarole.Text = "Nama Role";
            this.namarole.Click += new System.EventHandler(this.user_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(113, 23);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(150, 20);
            this.txtname.TabIndex = 34;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 121);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 33;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // hrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 378);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.txtdesk);
            this.Controls.Add(this.namarole);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnSimpan);
            this.Name = "hrole";
            this.Text = "hrole";
            this.Load += new System.EventHandler(this.hrole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.TextBox txtdesk;
        private System.Windows.Forms.Label namarole;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn image2;
    }
}