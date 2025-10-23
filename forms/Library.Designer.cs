namespace Library
{
    partial class Library
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
            this.form_title = new System.Windows.Forms.Label();
            this.btn_Students = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Borrows = new System.Windows.Forms.Button();
            this.btn_Database = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form_title
            // 
            this.form_title.AutoSize = true;
            this.form_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.form_title.Location = new System.Drawing.Point(125, 9);
            this.form_title.Name = "form_title";
            this.form_title.Size = new System.Drawing.Size(0, 20);
            this.form_title.TabIndex = 5;
            // 
            // btn_Students
            // 
            this.btn_Students.Location = new System.Drawing.Point(129, 57);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Size = new System.Drawing.Size(98, 23);
            this.btn_Students.TabIndex = 11;
            this.btn_Students.UseVisualStyleBackColor = true;
            this.btn_Students.Click += new System.EventHandler(this.BtnStudents_Click);
            // 
            // btn_Books
            // 
            this.btn_Books.Location = new System.Drawing.Point(246, 57);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(98, 23);
            this.btn_Books.TabIndex = 12;
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // btn_Borrows
            // 
            this.btn_Borrows.Location = new System.Drawing.Point(12, 57);
            this.btn_Borrows.Name = "btn_Borrows";
            this.btn_Borrows.Size = new System.Drawing.Size(98, 23);
            this.btn_Borrows.TabIndex = 13;
            this.btn_Borrows.UseVisualStyleBackColor = true;
            this.btn_Borrows.Click += new System.EventHandler(this.BtnBorrows_Click);
            // 
            // btn_Database
            // 
            this.btn_Database.Location = new System.Drawing.Point(129, 97);
            this.btn_Database.Name = "btn_Database";
            this.btn_Database.Size = new System.Drawing.Size(98, 23);
            this.btn_Database.TabIndex = 14;
            this.btn_Database.UseVisualStyleBackColor = true;
            this.btn_Database.Click += new System.EventHandler(this.BtnResetDatabase_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 132);
            this.Controls.Add(this.btn_Database);
            this.Controls.Add(this.btn_Borrows);
            this.Controls.Add(this.btn_Books);
            this.Controls.Add(this.btn_Students);
            this.Controls.Add(this.form_title);
            this.Name = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Library_FormClosed);
            this.Load += new System.EventHandler(this.Library_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label form_title;
        private System.Windows.Forms.Button btn_Students;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_Borrows;
        private System.Windows.Forms.Button btn_Database;
    }
}

