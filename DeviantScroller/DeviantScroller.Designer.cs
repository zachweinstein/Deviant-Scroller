namespace DeviantScroller
{
    partial class DeviantScroller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblCollectionURL = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptbArt = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lnkDev = new System.Windows.Forms.LinkLabel();
            this.lstGalleries = new System.Windows.Forms.ListBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblImageNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblCollectionURL
            // 
            this.lblCollectionURL.AutoSize = true;
            this.lblCollectionURL.Location = new System.Drawing.Point(45, 117);
            this.lblCollectionURL.Name = "lblCollectionURL";
            this.lblCollectionURL.Size = new System.Drawing.Size(88, 15);
            this.lblCollectionURL.TabIndex = 2;
            this.lblCollectionURL.Text = "Collection URL:";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(344, 601);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(212, 95);
            this.btnGO.TabIndex = 4;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbArt
            // 
            this.ptbArt.Location = new System.Drawing.Point(149, 104);
            this.ptbArt.Name = "ptbArt";
            this.ptbArt.Size = new System.Drawing.Size(725, 500);
            this.ptbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbArt.TabIndex = 10;
            this.ptbArt.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(-108, -47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 276);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 15);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(6, 300);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(131, 23);
            this.txtUserName.TabIndex = 13;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(6, 329);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(92, 23);
            this.btnUpdateUser.TabIndex = 14;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lnkDev
            // 
            this.lnkDev.AutoSize = true;
            this.lnkDev.Location = new System.Drawing.Point(26, 5);
            this.lnkDev.Name = "lnkDev";
            this.lnkDev.Size = new System.Drawing.Size(34, 15);
            this.lnkDev.TabIndex = 15;
            this.lnkDev.TabStop = true;
            this.lnkDev.Text = "URL: ";
            // 
            // lstGalleries
            // 
            this.lstGalleries.FormattingEnabled = true;
            this.lstGalleries.ItemHeight = 15;
            this.lstGalleries.Location = new System.Drawing.Point(0, 104);
            this.lstGalleries.Name = "lstGalleries";
            this.lstGalleries.Size = new System.Drawing.Size(143, 169);
            this.lstGalleries.TabIndex = 16;
            this.lstGalleries.SelectedIndexChanged += new System.EventHandler(this.lstGalleries_SelectedIndexChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAuthor.Location = new System.Drawing.Point(6, 57);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(58, 21);
            this.lblAuthor.TabIndex = 17;
            this.lblAuthor.Text = "Author";
            // 
            // lblImageNum
            // 
            this.lblImageNum.AutoSize = true;
            this.lblImageNum.Location = new System.Drawing.Point(6, 78);
            this.lblImageNum.Name = "lblImageNum";
            this.lblImageNum.Size = new System.Drawing.Size(109, 15);
            this.lblImageNum.TabIndex = 18;
            this.lblImageNum.Text = "Number in Gallery: ";
            
            // 
            // DeviantScroller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 708);
            this.Controls.Add(this.lblImageNum);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lstGalleries);
            this.Controls.Add(this.lnkDev);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ptbArt);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.toolStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "DeviantScroller";
            this.Text = "DeviantScroller";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblCollectionURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblURLT;
        private System.Windows.Forms.PictureBox ptbArt;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.LinkLabel lnkDev;
        private System.Windows.Forms.ListBox lstGalleries;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblImageNum;
    }
}

