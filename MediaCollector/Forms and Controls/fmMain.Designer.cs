﻿namespace MediaCollector
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnLoad = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSetting = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMain.AutoScroll = true;
            this.flpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMain.BackColor = System.Drawing.Color.NavajoWhite;
            this.flpMain.Location = new System.Drawing.Point(191, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(1501, 849);
            this.flpMain.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMenu.BackColor = System.Drawing.Color.IndianRed;
            this.pnMenu.Controls.Add(this.txtSearch);
            this.pnMenu.Controls.Add(this.pbHome);
            this.pnMenu.Controls.Add(this.btnLoad);
            this.pnMenu.Controls.Add(this.btnSetting);
            this.pnMenu.Location = new System.Drawing.Point(12, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(173, 849);
            this.pnMenu.TabIndex = 1;
            this.pnMenu.Click += new System.EventHandler(this.pnMenu_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(3, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pbHome
            // 
            this.pbHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.ErrorImage = null;
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.InitialImage = null;
            this.pbHome.Location = new System.Drawing.Point(3, 64);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(167, 79);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 2;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbLoading_Click);
            this.pbHome.DoubleClick += new System.EventHandler(this.pbLoading_DoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(3, 753);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 43);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Values.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Location = new System.Drawing.Point(3, 811);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(167, 26);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Values.Text = "Setting";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1704, 861);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.flpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.StateCommon.Border.Rounding = 11;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Header.ButtonEdgeInset = 11;
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.Text = "Media Collector";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Panel pnMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoad;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSetting;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

