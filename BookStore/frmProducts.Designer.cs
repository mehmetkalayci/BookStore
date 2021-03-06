﻿namespace BookStore
{
    partial class frmProducts
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtPickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMovie = new System.Windows.Forms.Panel();
            this.chkIsSubtitled = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlMusic = new System.Windows.Forms.Panel();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMovie.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.pnlMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgView);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgView.Location = new System.Drawing.Point(3, 16);
            this.dgView.MultiSelect = false;
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(614, 227);
            this.dgView.TabIndex = 0;
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtPickerReleaseDate);
            this.panel1.Controls.Add(this.txtItemType);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtItemId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 172);
            this.panel1.TabIndex = 8;
            // 
            // dtPickerReleaseDate
            // 
            this.dtPickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerReleaseDate.Location = new System.Drawing.Point(97, 87);
            this.dtPickerReleaseDate.Name = "dtPickerReleaseDate";
            this.dtPickerReleaseDate.Size = new System.Drawing.Size(140, 20);
            this.dtPickerReleaseDate.TabIndex = 14;
            // 
            // txtItemType
            // 
            this.txtItemType.Enabled = false;
            this.txtItemType.Location = new System.Drawing.Point(97, 113);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(140, 20);
            this.txtItemType.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(178, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(59, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tür :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yayın Tarihi :";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(97, 61);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(140, 20);
            this.txtPublisher.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üretici / Yayıncı :";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(97, 35);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(140, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Adı :";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(97, 9);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(140, 20);
            this.txtItemId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün Id :";
            // 
            // pnlMovie
            // 
            this.pnlMovie.Controls.Add(this.chkIsSubtitled);
            this.pnlMovie.Controls.Add(this.label11);
            this.pnlMovie.Enabled = false;
            this.pnlMovie.Location = new System.Drawing.Point(259, 146);
            this.pnlMovie.Name = "pnlMovie";
            this.pnlMovie.Size = new System.Drawing.Size(232, 38);
            this.pnlMovie.TabIndex = 11;
            // 
            // chkIsSubtitled
            // 
            this.chkIsSubtitled.AutoSize = true;
            this.chkIsSubtitled.Location = new System.Drawing.Point(75, 12);
            this.chkIsSubtitled.Name = "chkIsSubtitled";
            this.chkIsSubtitled.Size = new System.Drawing.Size(83, 17);
            this.chkIsSubtitled.TabIndex = 4;
            this.chkIsSubtitled.Text = "Evet / Hayır";
            this.chkIsSubtitled.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Altyazılı :";
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.txtISBN);
            this.pnlBook.Controls.Add(this.label8);
            this.pnlBook.Controls.Add(this.txtAuthor);
            this.pnlBook.Controls.Add(this.label9);
            this.pnlBook.Enabled = false;
            this.pnlBook.Location = new System.Drawing.Point(259, 79);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(232, 61);
            this.pnlBook.TabIndex = 10;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(75, 33);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(140, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ISBN :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(75, 7);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(140, 20);
            this.txtAuthor.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Yazar :";
            // 
            // pnlMusic
            // 
            this.pnlMusic.Controls.Add(this.txtArtist);
            this.pnlMusic.Controls.Add(this.label7);
            this.pnlMusic.Controls.Add(this.txtAlbumName);
            this.pnlMusic.Controls.Add(this.label6);
            this.pnlMusic.Enabled = false;
            this.pnlMusic.Location = new System.Drawing.Point(259, 12);
            this.pnlMusic.Name = "pnlMusic";
            this.pnlMusic.Size = new System.Drawing.Size(232, 61);
            this.pnlMusic.TabIndex = 9;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(75, 33);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(140, 20);
            this.txtArtist.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sanatçı :";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(75, 7);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(140, 20);
            this.txtAlbumName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Albüm Adı :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(97, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMovie);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.pnlMusic);
            this.Name = "frmProducts";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMovie.ResumeLayout(false);
            this.pnlMovie.PerformLayout();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlMusic.ResumeLayout(false);
            this.pnlMusic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox txtItemType;
        public System.Windows.Forms.Panel pnlMovie;
        public System.Windows.Forms.Panel pnlBook;
        public System.Windows.Forms.Panel pnlMusic;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtArtist;
        public System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.CheckBox chkIsSubtitled;
        private System.Windows.Forms.DateTimePicker dtPickerReleaseDate;
        private System.Windows.Forms.Button btnDelete;
    }
}