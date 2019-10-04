namespace DSVisionDatViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMediaType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNavigationText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNavigationURL = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblManualText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblManualURL = new System.Windows.Forms.LinkLabel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbBannerImage = new System.Windows.Forms.PictureBox();
            this.pbPropertyImage = new System.Windows.Forms.PictureBox();
            this.grpImageInformation = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBannerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPropertyImage)).BeginInit();
            this.grpImageInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(103, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "placeholderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(103, 54);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(91, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "placeholderGenre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Media Type";
            // 
            // lblMediaType
            // 
            this.lblMediaType.AutoSize = true;
            this.lblMediaType.Location = new System.Drawing.Point(103, 84);
            this.lblMediaType.Name = "lblMediaType";
            this.lblMediaType.Size = new System.Drawing.Size(115, 13);
            this.lblMediaType.TabIndex = 6;
            this.lblMediaType.Text = "placeholderMediaType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Title";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(105, 116);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "placeholderTitle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Navigation Text";
            // 
            // lblNavigationText
            // 
            this.lblNavigationText.AutoSize = true;
            this.lblNavigationText.Location = new System.Drawing.Point(470, 27);
            this.lblNavigationText.Name = "lblNavigationText";
            this.lblNavigationText.Size = new System.Drawing.Size(134, 13);
            this.lblNavigationText.TabIndex = 12;
            this.lblNavigationText.Text = "placeholderNavigationText";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Navigation URL";
            // 
            // lblNavigationURL
            // 
            this.lblNavigationURL.AutoSize = true;
            this.lblNavigationURL.Location = new System.Drawing.Point(470, 54);
            this.lblNavigationURL.Name = "lblNavigationURL";
            this.lblNavigationURL.Size = new System.Drawing.Size(135, 13);
            this.lblNavigationURL.TabIndex = 14;
            this.lblNavigationURL.TabStop = true;
            this.lblNavigationURL.Text = "placeholderNavigationURL";
            this.lblNavigationURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNavigationURL_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Manual Text";
            // 
            // lblManualText
            // 
            this.lblManualText.AutoSize = true;
            this.lblManualText.Location = new System.Drawing.Point(473, 83);
            this.lblManualText.Name = "lblManualText";
            this.lblManualText.Size = new System.Drawing.Size(118, 13);
            this.lblManualText.TabIndex = 16;
            this.lblManualText.Text = "placeholderManualText";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Manual URL";
            // 
            // lblManualURL
            // 
            this.lblManualURL.AutoSize = true;
            this.lblManualURL.Location = new System.Drawing.Point(473, 116);
            this.lblManualURL.Name = "lblManualURL";
            this.lblManualURL.Size = new System.Drawing.Size(119, 13);
            this.lblManualURL.TabIndex = 18;
            this.lblManualURL.TabStop = true;
            this.lblManualURL.Text = "placeholderManualURL";
            this.lblManualURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblManualURL_LinkClicked);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtDescription);
            this.grpInfo.Controls.Add(this.lblMediaType);
            this.grpInfo.Controls.Add(this.lblManualURL);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.lblID);
            this.grpInfo.Controls.Add(this.lblManualText);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.lblGenre);
            this.grpInfo.Controls.Add(this.lblNavigationURL);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.lblNavigationText);
            this.grpInfo.Controls.Add(this.lblTitle);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Location = new System.Drawing.Point(12, 27);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(776, 254);
            this.grpInfo.TabIndex = 19;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Banner Image";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Property Image";
            // 
            // pbBannerImage
            // 
            this.pbBannerImage.Location = new System.Drawing.Point(6, 33);
            this.pbBannerImage.Name = "pbBannerImage";
            this.pbBannerImage.Size = new System.Drawing.Size(307, 151);
            this.pbBannerImage.TabIndex = 22;
            this.pbBannerImage.TabStop = false;
            this.pbBannerImage.DoubleClick += new System.EventHandler(this.pbBannerImage_DoubleClick);
            // 
            // pbPropertyImage
            // 
            this.pbPropertyImage.Location = new System.Drawing.Point(368, 33);
            this.pbPropertyImage.Name = "pbPropertyImage";
            this.pbPropertyImage.Size = new System.Drawing.Size(390, 151);
            this.pbPropertyImage.TabIndex = 23;
            this.pbPropertyImage.TabStop = false;
            this.pbPropertyImage.Click += new System.EventHandler(this.pbPropertyImage_Click);
            this.pbPropertyImage.DoubleClick += new System.EventHandler(this.pbPropertyImage_DoubleClick);
            // 
            // grpImageInformation
            // 
            this.grpImageInformation.Controls.Add(this.label10);
            this.grpImageInformation.Controls.Add(this.pbPropertyImage);
            this.grpImageInformation.Controls.Add(this.pbBannerImage);
            this.grpImageInformation.Controls.Add(this.label11);
            this.grpImageInformation.ImeMode = System.Windows.Forms.ImeMode.On;
            this.grpImageInformation.Location = new System.Drawing.Point(12, 287);
            this.grpImageInformation.Name = "grpImageInformation";
            this.grpImageInformation.Size = new System.Drawing.Size(776, 201);
            this.grpImageInformation.TabIndex = 24;
            this.grpImageInformation.TabStop = false;
            this.grpImageInformation.Text = "Image Information";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 144);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(652, 104);
            this.txtDescription.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.grpImageInformation);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DSVision Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBannerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPropertyImage)).EndInit();
            this.grpImageInformation.ResumeLayout(false);
            this.grpImageInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMediaType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNavigationText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblNavigationURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblManualText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lblManualURL;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbBannerImage;
        private System.Windows.Forms.PictureBox pbPropertyImage;
        private System.Windows.Forms.GroupBox grpImageInformation;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

