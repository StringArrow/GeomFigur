namespace WFA_GeomFigur
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
            this.LBL_figuren = new System.Windows.Forms.Label();
            this.LV_figuren = new System.Windows.Forms.ListView();
            this.BTN_figurHinzufuegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_figuren
            // 
            this.LBL_figuren.AutoSize = true;
            this.LBL_figuren.Location = new System.Drawing.Point(12, 9);
            this.LBL_figuren.Name = "LBL_figuren";
            this.LBL_figuren.Size = new System.Drawing.Size(42, 13);
            this.LBL_figuren.TabIndex = 1;
            this.LBL_figuren.Text = "Figuren";
            // 
            // LV_figuren
            // 
            this.LV_figuren.HideSelection = false;
            this.LV_figuren.Location = new System.Drawing.Point(14, 60);
            this.LV_figuren.Name = "LV_figuren";
            this.LV_figuren.Size = new System.Drawing.Size(290, 377);
            this.LV_figuren.TabIndex = 2;
            this.LV_figuren.UseCompatibleStateImageBehavior = false;
            // 
            // BTN_figurHinzufuegen
            // 
            this.BTN_figurHinzufuegen.Location = new System.Drawing.Point(14, 31);
            this.BTN_figurHinzufuegen.Name = "BTN_figurHinzufuegen";
            this.BTN_figurHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.BTN_figurHinzufuegen.TabIndex = 3;
            this.BTN_figurHinzufuegen.Text = "Hinzufügen";
            this.BTN_figurHinzufuegen.UseVisualStyleBackColor = true;
            this.BTN_figurHinzufuegen.Click += new System.EventHandler(this.BTN_figurHinzufuegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_figurHinzufuegen);
            this.Controls.Add(this.LV_figuren);
            this.Controls.Add(this.LBL_figuren);
            this.Name = "Form1";
            this.Text = "Geometrische Figuren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_figuren;
        private System.Windows.Forms.ListView LV_figuren;
        private System.Windows.Forms.Button BTN_figurHinzufuegen;
    }
}

