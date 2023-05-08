namespace MediaCollector.Forms_and_Controls
{
    partial class ctrSearch
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
            this.txtCtrSearch = new System.Windows.Forms.TextBox();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtCtrSearch
            // 
            this.txtCtrSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCtrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtrSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCtrSearch.Location = new System.Drawing.Point(3, 3);
            this.txtCtrSearch.Name = "txtCtrSearch";
            this.txtCtrSearch.Size = new System.Drawing.Size(148, 26);
            this.txtCtrSearch.TabIndex = 4;
            this.txtCtrSearch.Text = "Search";
            // 
            // flpSearch
            // 
            this.flpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSearch.BackColor = System.Drawing.Color.Azure;
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSearch.Location = new System.Drawing.Point(3, 35);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(492, 682);
            this.flpSearch.TabIndex = 5;
            // 
            // ctrSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.txtCtrSearch);
            this.Name = "ctrSearch";
            this.Size = new System.Drawing.Size(498, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCtrSearch;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
    }
}
