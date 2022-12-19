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
            this.LV_figuren = new System.Windows.Forms.ListView();
            this.BTN_figurHinzufuegen = new System.Windows.Forms.Button();
            this.PL_formen = new System.Windows.Forms.Panel();
            this.LBL_figuren = new System.Windows.Forms.Label();
            this.LV_details = new System.Windows.Forms.ListView();
            this.BTN_figurEntfernen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LV_figuren
            // 
            this.LV_figuren.HideSelection = false;
            this.LV_figuren.Location = new System.Drawing.Point(14, 60);
            this.LV_figuren.Name = "LV_figuren";
            this.LV_figuren.Size = new System.Drawing.Size(183, 218);
            this.LV_figuren.TabIndex = 2;
            this.LV_figuren.UseCompatibleStateImageBehavior = false;
            this.LV_figuren.View = System.Windows.Forms.View.List;
            this.LV_figuren.SelectedIndexChanged += new System.EventHandler(this.LV_figuren_SelectedIndexChanged);
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
            // PL_formen
            // 
            this.PL_formen.Location = new System.Drawing.Point(202, 60);
            this.PL_formen.Name = "PL_formen";
            this.PL_formen.Size = new System.Drawing.Size(214, 219);
            this.PL_formen.TabIndex = 4;
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
            // LV_details
            // 
            this.LV_details.HideSelection = false;
            this.LV_details.Location = new System.Drawing.Point(423, 60);
            this.LV_details.Name = "LV_details";
            this.LV_details.Size = new System.Drawing.Size(192, 219);
            this.LV_details.TabIndex = 5;
            this.LV_details.UseCompatibleStateImageBehavior = false;
            this.LV_details.View = System.Windows.Forms.View.Details;
            // 
            // BTN_figurEntfernen
            // 
            this.BTN_figurEntfernen.Location = new System.Drawing.Point(122, 31);
            this.BTN_figurEntfernen.Name = "BTN_figurEntfernen";
            this.BTN_figurEntfernen.Size = new System.Drawing.Size(75, 23);
            this.BTN_figurEntfernen.TabIndex = 6;
            this.BTN_figurEntfernen.Text = "Entfernen";
            this.BTN_figurEntfernen.UseVisualStyleBackColor = true;
            this.BTN_figurEntfernen.Click += new System.EventHandler(this.BTN_figurEntfernen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 288);
            this.Controls.Add(this.BTN_figurEntfernen);
            this.Controls.Add(this.LV_details);
            this.Controls.Add(this.PL_formen);
            this.Controls.Add(this.BTN_figurHinzufuegen);
            this.Controls.Add(this.LV_figuren);
            this.Controls.Add(this.LBL_figuren);
            this.Name = "Form1";
            this.Text = "Geometrische Figuren";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LV_figuren;
        private System.Windows.Forms.Button BTN_figurHinzufuegen;
        private System.Windows.Forms.Panel PL_formen;
        private System.Windows.Forms.Label LBL_figuren;
        private System.Windows.Forms.ListView LV_details;
        private System.Windows.Forms.Button BTN_figurEntfernen;
    }
}

