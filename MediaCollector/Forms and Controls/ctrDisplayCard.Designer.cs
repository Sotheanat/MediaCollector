namespace MediaCollector.Form
{
    partial class ctrDisplayCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDisplayCard));
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.ctmRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.BreakLine = new System.Windows.Forms.ToolStripSeparator();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.size = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.ctmRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCover
            // 
            this.pbCover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCover.BackColor = System.Drawing.Color.DarkKhaki;
            this.pbCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCover.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCover.InitialImage")));
            this.pbCover.Location = new System.Drawing.Point(3, 3);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(359, 224);
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.pbCover_Click);
            this.pbCover.DoubleClick += new System.EventHandler(this.pbCover_DoubleClick);
            // 
            // ctmRightClick
            // 
            this.ctmRightClick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctmRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileLocation,
            this.BreakLine,
            this.delete,
            this.size});
            this.ctmRightClick.Name = "contextMenuStrip1";
            this.ctmRightClick.Size = new System.Drawing.Size(174, 76);
            // 
            // openFileLocation
            // 
            this.openFileLocation.Name = "openFileLocation";
            this.openFileLocation.Size = new System.Drawing.Size(173, 22);
            this.openFileLocation.Text = "Open File Location";
            this.openFileLocation.Click += new System.EventHandler(this.openFileLocation_Click);
            // 
            // BreakLine
            // 
            this.BreakLine.Name = "BreakLine";
            this.BreakLine.Size = new System.Drawing.Size(170, 6);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(173, 22);
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // size
            // 
            this.size.Enabled = false;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(173, 22);
            this.size.Text = "Size UNKNOWN";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 230);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrDisplayCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbCover);
            this.Name = "ctrDisplayCard";
            this.Size = new System.Drawing.Size(365, 266);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ctmRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.ContextMenuStrip ctmRightClick;
        private System.Windows.Forms.ToolStripMenuItem openFileLocation;
        private System.Windows.Forms.ToolStripSeparator BreakLine;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem size;
        private System.Windows.Forms.Label lblTitle;
    }
}
