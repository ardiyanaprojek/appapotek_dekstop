
namespace apotek_Ardiyana
{
    partial class husers
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
            this.labelid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.image2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.password = new System.Windows.Forms.Label();
            this.cmbhak = new System.Windows.Forms.ComboBox();
            this.hak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 9);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 27;
            this.labelid.Text = "id";
            this.labelid.Click += new System.EventHandler(this.labelid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Search";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(516, 185);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(147, 20);
            this.txtsearch.TabIndex = 25;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.LightCyan;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(89, 125);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(112, 26);
            this.btnUbah.TabIndex = 24;
            this.btnUbah.Text = "Ubah Data";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btntampil
            // 
            this.btntampil.BackColor = System.Drawing.Color.LightCyan;
            this.btntampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampil.Location = new System.Drawing.Point(207, 125);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(106, 26);
            this.btntampil.TabIndex = 23;
            this.btntampil.Text = "Tampil Data";
            this.btntampil.UseVisualStyleBackColor = false;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(113, 64);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(150, 20);
            this.txtpassword.TabIndex = 17;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(12, 34);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(69, 13);
            this.user.TabIndex = 16;
            this.user.Text = "Nama User";
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(113, 27);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(150, 20);
            this.txtuser.TabIndex = 15;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 125);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama_user,
            this.pw,
            this.role,
            this.image,
            this.image2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 167);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nama_user
            // 
            this.nama_user.HeaderText = "Nama User";
            this.nama_user.Name = "nama_user";
            // 
            // pw
            // 
            this.pw.HeaderText = "Password";
            this.pw.Name = "pw";
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
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
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(12, 67);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(61, 13);
            this.password.TabIndex = 30;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // cmbhak
            // 
            this.cmbhak.FormattingEnabled = true;
            this.cmbhak.Location = new System.Drawing.Point(113, 90);
            this.cmbhak.Name = "cmbhak";
            this.cmbhak.Size = new System.Drawing.Size(150, 21);
            this.cmbhak.TabIndex = 31;
            this.cmbhak.DropDown += new System.EventHandler(this.cmbhak_DropDown);
            this.cmbhak.SelectedIndexChanged += new System.EventHandler(this.cmbhak_DropDown);
            this.cmbhak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbhak_KeyDown);
            // 
            // hak
            // 
            this.hak.AutoSize = true;
            this.hak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hak.Location = new System.Drawing.Point(12, 93);
            this.hak.Name = "hak";
            this.hak.Size = new System.Drawing.Size(30, 13);
            this.hak.TabIndex = 32;
            this.hak.Text = "Hak";
            this.hak.Click += new System.EventHandler(this.hak_Click);
            // 
            // husers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 378);
            this.Controls.Add(this.hak);
            this.Controls.Add(this.cmbhak);
            this.Controls.Add(this.password);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.user);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnSimpan);
            this.Name = "husers";
            this.Text = "husers";
            this.Load += new System.EventHandler(this.husers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn image2;
        private System.Windows.Forms.ComboBox cmbhak;
        private System.Windows.Forms.Label hak;
    }
}