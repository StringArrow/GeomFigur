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
            this.LV_details = new System.Windows.Forms.ListView();
            this.BTN_figurEntfernen = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_figuren
            // 
            this.LV_figuren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LV_figuren.HideSelection = false;
            this.LV_figuren.Location = new System.Drawing.Point(7, 58);
            this.LV_figuren.Margin = new System.Windows.Forms.Padding(4);
            this.LV_figuren.Name = "LV_figuren";
            this.LV_figuren.Size = new System.Drawing.Size(232, 370);
            this.LV_figuren.TabIndex = 2;
            this.LV_figuren.UseCompatibleStateImageBehavior = false;
            this.LV_figuren.View = System.Windows.Forms.View.List;
            this.LV_figuren.SelectedIndexChanged += new System.EventHandler(this.LV_figuren_SelectedIndexChanged);
            // 
            // BTN_figurHinzufuegen
            // 
            this.BTN_figurHinzufuegen.Location = new System.Drawing.Point(7, 22);
            this.BTN_figurHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_figurHinzufuegen.Name = "BTN_figurHinzufuegen";
            this.BTN_figurHinzufuegen.Size = new System.Drawing.Size(100, 28);
            this.BTN_figurHinzufuegen.TabIndex = 3;
            this.BTN_figurHinzufuegen.Text = "Hinzufügen";
            this.BTN_figurHinzufuegen.UseVisualStyleBackColor = true;
            this.BTN_figurHinzufuegen.Click += new System.EventHandler(this.BTN_figurHinzufuegen_Click);
            // 
            // PL_formen
            // 
            this.PL_formen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PL_formen.Location = new System.Drawing.Point(7, 22);
            this.PL_formen.Margin = new System.Windows.Forms.Padding(4);
            this.PL_formen.Name = "PL_formen";
            this.PL_formen.Size = new System.Drawing.Size(454, 399);
            this.PL_formen.TabIndex = 4;
            // 
            // LV_details
            // 
            this.LV_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_details.HideSelection = false;
            this.LV_details.Location = new System.Drawing.Point(7, 22);
            this.LV_details.Margin = new System.Windows.Forms.Padding(4);
            this.LV_details.Name = "LV_details";
            this.LV_details.Size = new System.Drawing.Size(221, 399);
            this.LV_details.TabIndex = 5;
            this.LV_details.UseCompatibleStateImageBehavior = false;
            this.LV_details.View = System.Windows.Forms.View.Details;
            // 
            // BTN_figurEntfernen
            // 
            this.BTN_figurEntfernen.Location = new System.Drawing.Point(139, 22);
            this.BTN_figurEntfernen.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_figurEntfernen.Name = "BTN_figurEntfernen";
            this.BTN_figurEntfernen.Size = new System.Drawing.Size(100, 28);
            this.BTN_figurEntfernen.TabIndex = 6;
            this.BTN_figurEntfernen.Text = "Entfernen";
            this.BTN_figurEntfernen.UseVisualStyleBackColor = true;
            this.BTN_figurEntfernen.Click += new System.EventHandler(this.BTN_figurEntfernen_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(268, 6);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer.Panel1.Resize += new System.EventHandler(this.splitContainer_Panel1_Resize);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer.Size = new System.Drawing.Size(719, 438);
            this.splitContainer.SplitterDistance = 474;
            this.splitContainer.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.LV_figuren);
            this.groupBox1.Controls.Add(this.BTN_figurEntfernen);
            this.groupBox1.Controls.Add(this.BTN_figurHinzufuegen);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 435);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Figur erstellen und auswählen";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PL_formen);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 428);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Vorschau";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.LV_details);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 428);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Parameter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 459);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Geometrische Figuren";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LV_figuren;
        private System.Windows.Forms.Button BTN_figurHinzufuegen;
        private System.Windows.Forms.Panel PL_formen;
        private System.Windows.Forms.ListView LV_details;
        private System.Windows.Forms.Button BTN_figurEntfernen;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

