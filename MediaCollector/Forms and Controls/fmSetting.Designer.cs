namespace MediaCollector.Forms_and_Controls
{
    partial class fmSetting
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
            this.grpCardSize = new System.Windows.Forms.GroupBox();
            this.info = new System.Windows.Forms.Label();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grpTheme = new System.Windows.Forms.GroupBox();
            this.rdDefaultColor = new System.Windows.Forms.RadioButton();
            this.rdZuper = new System.Windows.Forms.RadioButton();
            this.rdDark = new System.Windows.Forms.RadioButton();
            this.rdRetro = new System.Windows.Forms.RadioButton();
            this.rdPink = new System.Windows.Forms.RadioButton();
            this.btnApply = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.numCard = new System.Windows.Forms.NumericUpDown();
            this.grpCardSize.SuspendLayout();
            this.grpTheme.SuspendLayout();
            this.grpCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCard)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCardSize
            // 
            this.grpCardSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCardSize.Controls.Add(this.info);
            this.grpCardSize.Controls.Add(this.rdLarge);
            this.grpCardSize.Controls.Add(this.rdMedium);
            this.grpCardSize.Controls.Add(this.rdSmall);
            this.grpCardSize.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCardSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.grpCardSize.Location = new System.Drawing.Point(12, 7);
            this.grpCardSize.Name = "grpCardSize";
            this.grpCardSize.Size = new System.Drawing.Size(173, 127);
            this.grpCardSize.TabIndex = 2;
            this.grpCardSize.TabStop = false;
            this.grpCardSize.Text = "Card Size";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.Gray;
            this.info.Location = new System.Drawing.Point(72, 103);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(93, 15);
            this.info.TabIndex = 3;
            this.info.Text = "Restart Required";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.Location = new System.Drawing.Point(6, 79);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(59, 21);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium.Location = new System.Drawing.Point(6, 52);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(74, 21);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(6, 25);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(57, 21);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            // 
            // grpTheme
            // 
            this.grpTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpTheme.Controls.Add(this.rdDefaultColor);
            this.grpTheme.Controls.Add(this.rdZuper);
            this.grpTheme.Controls.Add(this.rdDark);
            this.grpTheme.Controls.Add(this.rdRetro);
            this.grpTheme.Controls.Add(this.rdPink);
            this.grpTheme.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.grpTheme.Location = new System.Drawing.Point(12, 140);
            this.grpTheme.Name = "grpTheme";
            this.grpTheme.Size = new System.Drawing.Size(90, 180);
            this.grpTheme.TabIndex = 3;
            this.grpTheme.TabStop = false;
            this.grpTheme.Text = "Theme";
            // 
            // rdDefaultColor
            // 
            this.rdDefaultColor.AutoSize = true;
            this.rdDefaultColor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDefaultColor.Location = new System.Drawing.Point(6, 136);
            this.rdDefaultColor.Name = "rdDefaultColor";
            this.rdDefaultColor.Size = new System.Drawing.Size(67, 21);
            this.rdDefaultColor.TabIndex = 5;
            this.rdDefaultColor.TabStop = true;
            this.rdDefaultColor.Text = "Default";
            this.rdDefaultColor.UseVisualStyleBackColor = true;
            // 
            // rdZuper
            // 
            this.rdZuper.AutoSize = true;
            this.rdZuper.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdZuper.Location = new System.Drawing.Point(6, 109);
            this.rdZuper.Name = "rdZuper";
            this.rdZuper.Size = new System.Drawing.Size(60, 21);
            this.rdZuper.TabIndex = 4;
            this.rdZuper.TabStop = true;
            this.rdZuper.Text = "Zuper";
            this.rdZuper.UseVisualStyleBackColor = true;
            // 
            // rdDark
            // 
            this.rdDark.AutoSize = true;
            this.rdDark.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDark.Location = new System.Drawing.Point(6, 28);
            this.rdDark.Name = "rdDark";
            this.rdDark.Size = new System.Drawing.Size(53, 21);
            this.rdDark.TabIndex = 3;
            this.rdDark.TabStop = true;
            this.rdDark.Text = "Dark";
            this.rdDark.UseVisualStyleBackColor = true;
            // 
            // rdRetro
            // 
            this.rdRetro.AutoSize = true;
            this.rdRetro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRetro.Location = new System.Drawing.Point(6, 82);
            this.rdRetro.Name = "rdRetro";
            this.rdRetro.Size = new System.Drawing.Size(58, 21);
            this.rdRetro.TabIndex = 2;
            this.rdRetro.TabStop = true;
            this.rdRetro.Text = "Retro";
            this.rdRetro.UseVisualStyleBackColor = true;
            // 
            // rdPink
            // 
            this.rdPink.AutoSize = true;
            this.rdPink.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPink.Location = new System.Drawing.Point(6, 55);
            this.rdPink.Name = "rdPink";
            this.rdPink.Size = new System.Drawing.Size(49, 21);
            this.rdPink.TabIndex = 0;
            this.rdPink.TabStop = true;
            this.rdPink.Text = "Pink";
            this.rdPink.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(87, 327);
            this.btnApply.Name = "btnApply";
            this.btnApply.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnApply.Size = new System.Drawing.Size(98, 26);
            this.btnApply.TabIndex = 1;
            this.btnApply.Values.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpCard
            // 
            this.grpCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCard.Controls.Add(this.numCard);
            this.grpCard.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.grpCard.Location = new System.Drawing.Point(108, 140);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(77, 103);
            this.grpCard.TabIndex = 6;
            this.grpCard.TabStop = false;
            this.grpCard.Text = "Card Number";
            // 
            // numCard
            // 
            this.numCard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numCard.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.numCard.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCard.Location = new System.Drawing.Point(6, 55);
            this.numCard.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numCard.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCard.Name = "numCard";
            this.numCard.ReadOnly = true;
            this.numCard.Size = new System.Drawing.Size(63, 29);
            this.numCard.TabIndex = 0;
            this.numCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCard.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // fmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(197, 364);
            this.Controls.Add(this.grpCard);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpTheme);
            this.Controls.Add(this.grpCardSize);
            this.Name = "fmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.Text = "Settting";
            this.Load += new System.EventHandler(this.fmSetting_Load);
            this.grpCardSize.ResumeLayout(false);
            this.grpCardSize.PerformLayout();
            this.grpTheme.ResumeLayout(false);
            this.grpTheme.PerformLayout();
            this.grpCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCardSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox grpTheme;
        private System.Windows.Forms.RadioButton rdRetro;
        private System.Windows.Forms.RadioButton rdPink;
        private System.Windows.Forms.RadioButton rdDark;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.RadioButton rdZuper;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnApply;
        private System.Windows.Forms.RadioButton rdDefaultColor;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.NumericUpDown numCard;
    }
}