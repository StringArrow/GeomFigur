﻿namespace WFA_GeomFigur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LV_figuren = new System.Windows.Forms.ListView();
            this.BTN_figurHinzufuegen = new System.Windows.Forms.Button();
            this.PL_formen = new System.Windows.Forms.Panel();
            this.LV_details = new System.Windows.Forms.ListView();
            this.BTN_figurEntfernen = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_title_kevin = new System.Windows.Forms.Label();
            this.LBL_title_magnificent = new System.Windows.Forms.Label();
            this.LBL_title_skidder = new System.Windows.Forms.Label();
            this.pictureBox_duffy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_duffy)).BeginInit();
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
            this.LV_figuren.Size = new System.Drawing.Size(232, 579);
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
            this.PL_formen.Size = new System.Drawing.Size(419, 611);
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
            this.LV_details.Size = new System.Drawing.Size(388, 611);
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
            this.splitContainer.Location = new System.Drawing.Point(268, 93);
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
            this.splitContainer.Size = new System.Drawing.Size(851, 650);
            this.splitContainer.SplitterDistance = 439;
            this.splitContainer.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PL_formen);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 640);
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
            this.groupBox3.Size = new System.Drawing.Size(402, 640);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Parameter";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.LV_figuren);
            this.groupBox1.Controls.Add(this.BTN_figurEntfernen);
            this.groupBox1.Controls.Add(this.BTN_figurHinzufuegen);
            this.groupBox1.Location = new System.Drawing.Point(19, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 644);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Figur erstellen und auswählen";
            // 
            // LBL_title_kevin
            // 
            this.LBL_title_kevin.AutoSize = true;
            this.LBL_title_kevin.ForeColor = System.Drawing.Color.Black;
            this.LBL_title_kevin.Location = new System.Drawing.Point(31, 41);
            this.LBL_title_kevin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_title_kevin.Name = "LBL_title_kevin";
            this.LBL_title_kevin.Size = new System.Drawing.Size(50, 16);
            this.LBL_title_kevin.TabIndex = 9;
            this.LBL_title_kevin.Text = "Kevin\'s";
            // 
            // LBL_title_magnificent
            // 
            this.LBL_title_magnificent.AutoSize = true;
            this.LBL_title_magnificent.BackColor = System.Drawing.Color.Transparent;
            this.LBL_title_magnificent.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold);
            this.LBL_title_magnificent.ForeColor = System.Drawing.Color.Black;
            this.LBL_title_magnificent.Location = new System.Drawing.Point(27, 53);
            this.LBL_title_magnificent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_title_magnificent.Name = "LBL_title_magnificent";
            this.LBL_title_magnificent.Size = new System.Drawing.Size(154, 37);
            this.LBL_title_magnificent.TabIndex = 10;
            this.LBL_title_magnificent.Text = "Magnificent";
            // 
            // LBL_title_skidder
            // 
            this.LBL_title_skidder.AutoSize = true;
            this.LBL_title_skidder.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_title_skidder.ForeColor = System.Drawing.Color.Black;
            this.LBL_title_skidder.Location = new System.Drawing.Point(216, -2);
            this.LBL_title_skidder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_title_skidder.Name = "LBL_title_skidder";
            this.LBL_title_skidder.Size = new System.Drawing.Size(618, 81);
            this.LBL_title_skidder.TabIndex = 11;
            this.LBL_title_skidder.Text = "Geometrische Figuren";
            // 
            // pictureBox_duffy
            // 
            this.pictureBox_duffy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_duffy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_duffy.Image")));
            this.pictureBox_duffy.InitialImage = null;
            this.pictureBox_duffy.Location = new System.Drawing.Point(1039, 7);
            this.pictureBox_duffy.Name = "pictureBox_duffy";
            this.pictureBox_duffy.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_duffy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_duffy.TabIndex = 12;
            this.pictureBox_duffy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 755);
            this.Controls.Add(this.pictureBox_duffy);
            this.Controls.Add(this.LBL_title_kevin);
            this.Controls.Add(this.LBL_title_skidder);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_title_magnificent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1147, 300);
            this.Name = "Form1";
            this.Text = "Geometrische Figuren";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_duffy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label LBL_title_kevin;
        private System.Windows.Forms.Label LBL_title_magnificent;
        private System.Windows.Forms.Label LBL_title_skidder;
        private System.Windows.Forms.PictureBox pictureBox_duffy;
    }
}

