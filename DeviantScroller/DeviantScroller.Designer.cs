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
            this.lbl_deviation_info = new System.Windows.Forms.Label();
            this.ptbArt = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lnkDev = new System.Windows.Forms.LinkLabel();
            this.lstGalleries = new System.Windows.Forms.ListBox();
            this.grp_deviation_info = new System.Windows.Forms.GroupBox();
            this.grp_result = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArt)).BeginInit();
            this.grp_deviation_info.SuspendLayout();
            this.grp_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
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
            this.btnGO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGO.Location = new System.Drawing.Point(3, 551);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(745, 60);
            this.btnGO.TabIndex = 4;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click_1);
            // 
            // lbl_deviation_info
            // 
            this.lbl_deviation_info.AutoSize = true;
            this.lbl_deviation_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_deviation_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_deviation_info.Location = new System.Drawing.Point(3, 19);
            this.lbl_deviation_info.Name = "lbl_deviation_info";
            this.lbl_deviation_info.Size = new System.Drawing.Size(142, 63);
            this.lbl_deviation_info.TabIndex = 9;
            this.lbl_deviation_info.Text = "Title: \r\nDeviant: \r\nPosition in Gallery: ";
            this.lbl_deviation_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbArt
            // 
            this.ptbArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbArt.Location = new System.Drawing.Point(3, 19);
            this.ptbArt.Name = "ptbArt";
            this.ptbArt.Size = new System.Drawing.Size(745, 525);
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
            this.lblUserName.Location = new System.Drawing.Point(6, 306);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 15);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(6, 324);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(131, 23);
            this.txtUserName.TabIndex = 13;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(6, 353);
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
            this.lnkDev.Location = new System.Drawing.Point(12, 7);
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
            this.lstGalleries.Location = new System.Drawing.Point(6, 134);
            this.lstGalleries.Name = "lstGalleries";
            this.lstGalleries.Size = new System.Drawing.Size(143, 169);
            this.lstGalleries.TabIndex = 16;
            this.lstGalleries.SelectedIndexChanged += new System.EventHandler(this.lstGalleries_SelectedIndexChanged);
            // 
            // grp_deviation_info
            // 
            this.grp_deviation_info.Controls.Add(this.lbl_deviation_info);
            this.grp_deviation_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_deviation_info.Location = new System.Drawing.Point(0, 25);
            this.grp_deviation_info.Name = "grp_deviation_info";
            this.grp_deviation_info.Size = new System.Drawing.Size(964, 100);
            this.grp_deviation_info.TabIndex = 19;
            this.grp_deviation_info.TabStop = false;
            this.grp_deviation_info.Text = "s";
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.btnGO);
            this.grp_result.Controls.Add(this.ptbArt);
            this.grp_result.Location = new System.Drawing.Point(176, 134);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(751, 614);
            this.grp_result.TabIndex = 20;
            this.grp_result.TabStop = false;
            // 
            // DeviantScroller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 760);
            this.Controls.Add(this.grp_result);
            this.Controls.Add(this.grp_deviation_info);
            this.Controls.Add(this.lstGalleries);
            this.Controls.Add(this.lnkDev);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.toolStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "DeviantScroller";
            this.Text = "DeviantScroller";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArt)).EndInit();
            this.grp_deviation_info.ResumeLayout(false);
            this.grp_deviation_info.PerformLayout();
            this.grp_result.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblCollectionURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblURLT;
        private System.Windows.Forms.PictureBox ptbArt;
        private System.Windows.Forms.Label lbl_deviation_info;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.LinkLabel lnkDev;
        private System.Windows.Forms.ListBox lstGalleries;
        private System.Windows.Forms.GroupBox grp_deviation_info;
        private System.Windows.Forms.GroupBox grp_deviation;
        private System.Windows.Forms.GroupBox grp_result;
    }
}

