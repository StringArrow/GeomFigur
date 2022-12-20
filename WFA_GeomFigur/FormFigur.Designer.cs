namespace WFA_GeomFigur
{
    partial class FormFigur
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
            this.CB_figureType = new System.Windows.Forms.ComboBox();
            this.LBL_figureType = new System.Windows.Forms.Label();
            this.LBL_bezeichnung = new System.Windows.Forms.Label();
            this.TB_bezeichnung = new System.Windows.Forms.TextBox();
            this.LBL_color = new System.Windows.Forms.Label();
            this.CB_color = new System.Windows.Forms.ComboBox();
            this.LBL_value1 = new System.Windows.Forms.Label();
            this.NUD_value1 = new System.Windows.Forms.NumericUpDown();
            this.BTN_create = new System.Windows.Forms.Button();
            this.LBL_value2 = new System.Windows.Forms.Label();
            this.NUD_value2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_value1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_value2)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_figureType
            // 
            this.CB_figureType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_figureType.FormattingEnabled = true;
            this.CB_figureType.Items.AddRange(new object[] {
            "Quadrat",
            "Rechteck",
            "Kreis",
            "Würfel",
            "Kugel"});
            this.CB_figureType.Location = new System.Drawing.Point(16, 31);
            this.CB_figureType.Margin = new System.Windows.Forms.Padding(4);
            this.CB_figureType.Name = "CB_figureType";
            this.CB_figureType.Size = new System.Drawing.Size(301, 24);
            this.CB_figureType.TabIndex = 0;
            this.CB_figureType.SelectedIndexChanged += new System.EventHandler(this.CB_figureType_SelectedIndexChanged);
            // 
            // LBL_figureType
            // 
            this.LBL_figureType.AutoSize = true;
            this.LBL_figureType.Location = new System.Drawing.Point(16, 11);
            this.LBL_figureType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_figureType.Name = "LBL_figureType";
            this.LBL_figureType.Size = new System.Drawing.Size(31, 16);
            this.LBL_figureType.TabIndex = 1;
            this.LBL_figureType.Text = "Typ";
            // 
            // LBL_bezeichnung
            // 
            this.LBL_bezeichnung.AutoSize = true;
            this.LBL_bezeichnung.Location = new System.Drawing.Point(16, 60);
            this.LBL_bezeichnung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_bezeichnung.Name = "LBL_bezeichnung";
            this.LBL_bezeichnung.Size = new System.Drawing.Size(84, 16);
            this.LBL_bezeichnung.TabIndex = 2;
            this.LBL_bezeichnung.Text = "Bezeichnung";
            // 
            // TB_bezeichnung
            // 
            this.TB_bezeichnung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_bezeichnung.Location = new System.Drawing.Point(16, 80);
            this.TB_bezeichnung.Margin = new System.Windows.Forms.Padding(4);
            this.TB_bezeichnung.Name = "TB_bezeichnung";
            this.TB_bezeichnung.Size = new System.Drawing.Size(301, 22);
            this.TB_bezeichnung.TabIndex = 1;
            // 
            // LBL_color
            // 
            this.LBL_color.AutoSize = true;
            this.LBL_color.Location = new System.Drawing.Point(16, 108);
            this.LBL_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_color.Name = "LBL_color";
            this.LBL_color.Size = new System.Drawing.Size(43, 16);
            this.LBL_color.TabIndex = 4;
            this.LBL_color.Text = "Farbe";
            // 
            // CB_color
            // 
            this.CB_color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_color.FormattingEnabled = true;
            this.CB_color.Location = new System.Drawing.Point(16, 128);
            this.CB_color.Margin = new System.Windows.Forms.Padding(4);
            this.CB_color.Name = "CB_color";
            this.CB_color.Size = new System.Drawing.Size(301, 24);
            this.CB_color.TabIndex = 2;
            // 
            // LBL_value1
            // 
            this.LBL_value1.AutoSize = true;
            this.LBL_value1.Location = new System.Drawing.Point(16, 158);
            this.LBL_value1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_value1.Name = "LBL_value1";
            this.LBL_value1.Size = new System.Drawing.Size(50, 16);
            this.LBL_value1.TabIndex = 6;
            this.LBL_value1.Text = "Seite A";
            // 
            // NUD_value1
            // 
            this.NUD_value1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_value1.Location = new System.Drawing.Point(16, 177);
            this.NUD_value1.Margin = new System.Windows.Forms.Padding(4);
            this.NUD_value1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_value1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_value1.Name = "NUD_value1";
            this.NUD_value1.Size = new System.Drawing.Size(302, 22);
            this.NUD_value1.TabIndex = 3;
            this.NUD_value1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_create
            // 
            this.BTN_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_create.Location = new System.Drawing.Point(218, 251);
            this.BTN_create.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_create.Name = "BTN_create";
            this.BTN_create.Size = new System.Drawing.Size(100, 28);
            this.BTN_create.TabIndex = 8;
            this.BTN_create.Text = "Anlegen";
            this.BTN_create.UseVisualStyleBackColor = true;
            this.BTN_create.Click += new System.EventHandler(this.BTN_create_Click);
            // 
            // LBL_value2
            // 
            this.LBL_value2.AutoSize = true;
            this.LBL_value2.Location = new System.Drawing.Point(16, 206);
            this.LBL_value2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_value2.Name = "LBL_value2";
            this.LBL_value2.Size = new System.Drawing.Size(50, 16);
            this.LBL_value2.TabIndex = 9;
            this.LBL_value2.Text = "Seite B";
            // 
            // NUD_value2
            // 
            this.NUD_value2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_value2.Location = new System.Drawing.Point(16, 225);
            this.NUD_value2.Margin = new System.Windows.Forms.Padding(4);
            this.NUD_value2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_value2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_value2.Name = "NUD_value2";
            this.NUD_value2.Size = new System.Drawing.Size(302, 22);
            this.NUD_value2.TabIndex = 4;
            this.NUD_value2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormFigur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 291);
            this.Controls.Add(this.NUD_value2);
            this.Controls.Add(this.LBL_value2);
            this.Controls.Add(this.BTN_create);
            this.Controls.Add(this.NUD_value1);
            this.Controls.Add(this.LBL_value1);
            this.Controls.Add(this.CB_color);
            this.Controls.Add(this.LBL_color);
            this.Controls.Add(this.TB_bezeichnung);
            this.Controls.Add(this.LBL_bezeichnung);
            this.Controls.Add(this.LBL_figureType);
            this.Controls.Add(this.CB_figureType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(350, 330);
            this.MinimumSize = new System.Drawing.Size(350, 330);
            this.Name = "FormFigur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neue Figur";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_value1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_value2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_figureType;
        private System.Windows.Forms.Label LBL_figureType;
        private System.Windows.Forms.Label LBL_bezeichnung;
        private System.Windows.Forms.TextBox TB_bezeichnung;
        private System.Windows.Forms.Label LBL_color;
        private System.Windows.Forms.ComboBox CB_color;
        private System.Windows.Forms.Label LBL_value1;
        private System.Windows.Forms.NumericUpDown NUD_value1;
        private System.Windows.Forms.Button BTN_create;
        private System.Windows.Forms.Label LBL_value2;
        private System.Windows.Forms.NumericUpDown NUD_value2;
    }
}