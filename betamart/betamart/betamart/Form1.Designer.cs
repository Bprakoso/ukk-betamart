namespace betamart
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.produkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.betamartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new betamart.AppData();
            this.txtnamabarang = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtjenisbarang = new System.Windows.Forms.TextBox();
            this.txthargabarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstokbarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.betamartTableAdapter = new betamart.AppDataTableAdapters.BetamartTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Barang";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(47, 151);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produkIDDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.stokBarangDataGridViewTextBoxColumn,
            this.hargaBarangDataGridViewTextBoxColumn,
            this.jenisBarangDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.betamartBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(10, 267);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(656, 150);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // produkIDDataGridViewTextBoxColumn
            // 
            this.produkIDDataGridViewTextBoxColumn.DataPropertyName = "ProdukID";
            this.produkIDDataGridViewTextBoxColumn.HeaderText = "ProdukID";
            this.produkIDDataGridViewTextBoxColumn.Name = "produkIDDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // stokBarangDataGridViewTextBoxColumn
            // 
            this.stokBarangDataGridViewTextBoxColumn.DataPropertyName = "StokBarang";
            this.stokBarangDataGridViewTextBoxColumn.HeaderText = "StokBarang";
            this.stokBarangDataGridViewTextBoxColumn.Name = "stokBarangDataGridViewTextBoxColumn";
            // 
            // hargaBarangDataGridViewTextBoxColumn
            // 
            this.hargaBarangDataGridViewTextBoxColumn.DataPropertyName = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.HeaderText = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.Name = "hargaBarangDataGridViewTextBoxColumn";
            // 
            // jenisBarangDataGridViewTextBoxColumn
            // 
            this.jenisBarangDataGridViewTextBoxColumn.DataPropertyName = "JenisBarang";
            this.jenisBarangDataGridViewTextBoxColumn.HeaderText = "JenisBarang";
            this.jenisBarangDataGridViewTextBoxColumn.Name = "jenisBarangDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // betamartBindingSource
            // 
            this.betamartBindingSource.DataMember = "Betamart";
            this.betamartBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtnamabarang
            // 
            this.txtnamabarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "NamaBarang", true));
            this.txtnamabarang.Location = new System.Drawing.Point(284, 41);
            this.txtnamabarang.Name = "txtnamabarang";
            this.txtnamabarang.Size = new System.Drawing.Size(258, 20);
            this.txtnamabarang.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.txtjenisbarang);
            this.panel.Controls.Add(this.txthargabarang);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtstokbarang);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtnamabarang);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.btnbrowse);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 48);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(656, 187);
            this.panel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.betamartBindingSource, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(21, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(124, 132);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtjenisbarang
            // 
            this.txtjenisbarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "JenisBarang", true));
            this.txtjenisbarang.Location = new System.Drawing.Point(284, 119);
            this.txtjenisbarang.Name = "txtjenisbarang";
            this.txtjenisbarang.Size = new System.Drawing.Size(258, 20);
            this.txtjenisbarang.TabIndex = 3;
            // 
            // txthargabarang
            // 
            this.txthargabarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "HargaBarang", true));
            this.txthargabarang.Location = new System.Drawing.Point(284, 93);
            this.txthargabarang.Name = "txthargabarang";
            this.txthargabarang.Size = new System.Drawing.Size(258, 20);
            this.txthargabarang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jenis Barang";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtstokbarang
            // 
            this.txtstokbarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "StokBarang", true));
            this.txtstokbarang.Location = new System.Drawing.Point(284, 67);
            this.txtstokbarang.Name = "txtstokbarang";
            this.txtstokbarang.Size = new System.Drawing.Size(258, 20);
            this.txtstokbarang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(117, 241);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(551, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(591, 423);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(510, 423);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(429, 423);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.Location = new System.Drawing.Point(348, 423);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // betamartTableAdapter
            // 
            this.betamartTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "BETAMART";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(267, 423);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 456);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtnamabarang;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtjenisbarang;
        private System.Windows.Forms.TextBox txthargabarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstokbarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private AppData appData;
        private System.Windows.Forms.BindingSource betamartBindingSource;
        private AppDataTableAdapters.BetamartTableAdapter betamartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndelete;
    }
}

