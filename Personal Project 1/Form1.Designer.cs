﻿namespace Personal_Project_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnword = new System.Windows.Forms.Button();
            this.btnstring = new System.Windows.Forms.Button();
            this.btnpage = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.btngame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnword
            // 
            this.btnword.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnword.Location = new System.Drawing.Point(62, 25);
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(278, 90);
            this.btnword.TabIndex = 0;
            this.btnword.Text = "단어 연습";
            this.btnword.UseVisualStyleBackColor = true;
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // btnstring
            // 
            this.btnstring.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnstring.Location = new System.Drawing.Point(62, 139);
            this.btnstring.Name = "btnstring";
            this.btnstring.Size = new System.Drawing.Size(278, 90);
            this.btnstring.TabIndex = 1;
            this.btnstring.Text = "단문 연습";
            this.btnstring.UseVisualStyleBackColor = true;
            this.btnstring.Click += new System.EventHandler(this.btnstring_Click);
            // 
            // btnpage
            // 
            this.btnpage.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpage.Location = new System.Drawing.Point(62, 254);
            this.btnpage.Name = "btnpage";
            this.btnpage.Size = new System.Drawing.Size(278, 90);
            this.btnpage.TabIndex = 2;
            this.btnpage.Text = "장문 연습";
            this.btnpage.UseVisualStyleBackColor = true;
            this.btnpage.Click += new System.EventHandler(this.btnpage_Click);
            // 
            // Finish
            // 
            this.Finish.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Finish.Location = new System.Drawing.Point(62, 480);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(278, 90);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "종     료";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // btngame
            // 
            this.btngame.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btngame.Location = new System.Drawing.Point(62, 374);
            this.btngame.Name = "btngame";
            this.btngame.Size = new System.Drawing.Size(278, 90);
            this.btngame.TabIndex = 4;
            this.btngame.Text = "게     임";
            this.btngame.UseVisualStyleBackColor = true;
            this.btngame.Click += new System.EventHandler(this.btngame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 604);
            this.Controls.Add(this.btngame);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.btnpage);
            this.Controls.Add(this.btnstring);
            this.Controls.Add(this.btnword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnword;
        private Button btnstring;
        private Button btnpage;
        private Button Finish;
        private Button btngame;
    }
}