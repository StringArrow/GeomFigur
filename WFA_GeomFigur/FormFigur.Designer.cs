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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL_figureType = new System.Windows.Forms.Label();
            this.LBL_bezeichnung = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBL_color = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LBL_value1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BTN_create = new System.Windows.Forms.Button();
            this.LBL_value2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // LBL_figureType
            // 
            this.LBL_figureType.AutoSize = true;
            this.LBL_figureType.Location = new System.Drawing.Point(12, 9);
            this.LBL_figureType.Name = "LBL_figureType";
            this.LBL_figureType.Size = new System.Drawing.Size(25, 13);
            this.LBL_figureType.TabIndex = 1;
            this.LBL_figureType.Text = "Typ";
            // 
            // LBL_bezeichnung
            // 
            this.LBL_bezeichnung.AutoSize = true;
            this.LBL_bezeichnung.Location = new System.Drawing.Point(12, 49);
            this.LBL_bezeichnung.Name = "LBL_bezeichnung";
            this.LBL_bezeichnung.Size = new System.Drawing.Size(69, 13);
            this.LBL_bezeichnung.TabIndex = 2;
            this.LBL_bezeichnung.Text = "Bezeichnung";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 3;
            // 
            // LBL_color
            // 
            this.LBL_color.AutoSize = true;
            this.LBL_color.Location = new System.Drawing.Point(12, 88);
            this.LBL_color.Name = "LBL_color";
            this.LBL_color.Size = new System.Drawing.Size(34, 13);
            this.LBL_color.TabIndex = 4;
            this.LBL_color.Text = "Farbe";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // LBL_value1
            // 
            this.LBL_value1.AutoSize = true;
            this.LBL_value1.Location = new System.Drawing.Point(12, 128);
            this.LBL_value1.Name = "LBL_value1";
            this.LBL_value1.Size = new System.Drawing.Size(41, 13);
            this.LBL_value1.TabIndex = 6;
            this.LBL_value1.Text = "Seite A";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 144);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // BTN_create
            // 
            this.BTN_create.Location = new System.Drawing.Point(105, 209);
            this.BTN_create.Name = "BTN_create";
            this.BTN_create.Size = new System.Drawing.Size(75, 23);
            this.BTN_create.TabIndex = 8;
            this.BTN_create.Text = "Anlegen";
            this.BTN_create.UseVisualStyleBackColor = true;
            // 
            // LBL_value2
            // 
            this.LBL_value2.AutoSize = true;
            this.LBL_value2.Location = new System.Drawing.Point(12, 167);
            this.LBL_value2.Name = "LBL_value2";
            this.LBL_value2.Size = new System.Drawing.Size(41, 13);
            this.LBL_value2.TabIndex = 9;
            this.LBL_value2.Text = "Seite B";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(12, 183);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // FormFigur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 241);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.LBL_value2);
            this.Controls.Add(this.BTN_create);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LBL_value1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LBL_color);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LBL_bezeichnung);
            this.Controls.Add(this.LBL_figureType);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormFigur";
            this.Text = "FormFigur";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL_figureType;
        private System.Windows.Forms.Label LBL_bezeichnung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBL_color;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label LBL_value1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BTN_create;
        private System.Windows.Forms.Label LBL_value2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}