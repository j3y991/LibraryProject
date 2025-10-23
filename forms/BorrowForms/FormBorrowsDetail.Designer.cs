namespace Library.Forms.BorrowDetails
{
    partial class BorrowDetails
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_ID_value = new System.Windows.Forms.Label();
            this.label_Student = new System.Windows.Forms.Label();
            this.label_Book = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_Students = new System.Windows.Forms.ListBox();
            this.lb_Books = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ID.Location = new System.Drawing.Point(23, 25);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(0, 16);
            this.label_ID.TabIndex = 1;
            // 
            // label_ID_value
            // 
            this.label_ID_value.AutoSize = true;
            this.label_ID_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ID_value.Location = new System.Drawing.Point(131, 25);
            this.label_ID_value.Name = "label_ID_value";
            this.label_ID_value.Size = new System.Drawing.Size(0, 16);
            this.label_ID_value.TabIndex = 2;
            // 
            // label_Student
            // 
            this.label_Student.AutoSize = true;
            this.label_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Student.Location = new System.Drawing.Point(23, 68);
            this.label_Student.Name = "label_Student";
            this.label_Student.Size = new System.Drawing.Size(0, 16);
            this.label_Student.TabIndex = 3;
            // 
            // label_Book
            // 
            this.label_Book.AutoSize = true;
            this.label_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Book.Location = new System.Drawing.Point(23, 137);
            this.label_Book.Name = "label_Book";
            this.label_Book.Size = new System.Drawing.Size(0, 16);
            this.label_Book.TabIndex = 4;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(134, 200);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(295, 200);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lb_Students
            // 
            this.lb_Students.FormattingEnabled = true;
            this.lb_Students.Location = new System.Drawing.Point(88, 68);
            this.lb_Students.Name = "lb_Students";
            this.lb_Students.Size = new System.Drawing.Size(413, 43);
            this.lb_Students.TabIndex = 7;
            // 
            // lb_Books
            // 
            this.lb_Books.FormattingEnabled = true;
            this.lb_Books.Location = new System.Drawing.Point(88, 137);
            this.lb_Books.Name = "lb_Books";
            this.lb_Books.Size = new System.Drawing.Size(413, 43);
            this.lb_Books.TabIndex = 8;
            // 
            // BorrowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 245);
            this.Controls.Add(this.lb_Books);
            this.Controls.Add(this.lb_Students);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label_Book);
            this.Controls.Add(this.label_Student);
            this.Controls.Add(this.label_ID_value);
            this.Controls.Add(this.label_ID);
            this.Name = "BorrowDetails";
            this.Load += new System.EventHandler(this.BorrowDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_ID_value;
        private System.Windows.Forms.Label label_Student;
        private System.Windows.Forms.Label label_Book;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListBox lb_Students;
        private System.Windows.Forms.ListBox lb_Books;
    }
}