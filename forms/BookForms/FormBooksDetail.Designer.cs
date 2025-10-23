namespace Library.Forms.BookDetails
{
    partial class FormBooksDetail
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
            this.label_Author = new System.Windows.Forms.Label();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_ReleaseYear = new System.Windows.Forms.Label();
            this.label_CopiesNum = new System.Windows.Forms.Label();
            this.cb_Release_Year = new System.Windows.Forms.ComboBox();
            this.cb_CopiesNum = new System.Windows.Forms.ComboBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_bookId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ID.Location = new System.Drawing.Point(13, 21);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(0, 16);
            this.label_ID.TabIndex = 0;
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Author.Location = new System.Drawing.Point(13, 56);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(0, 16);
            this.label_Author.TabIndex = 3;
            // 
            // tb_Author
            // 
            this.tb_Author.Location = new System.Drawing.Point(70, 55);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(137, 20);
            this.tb_Author.TabIndex = 4;
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(78, 88);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(137, 20);
            this.tb_Title.TabIndex = 6;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(12, 88);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(0, 16);
            this.label_Title.TabIndex = 5;
            // 
            // label_ReleaseYear
            // 
            this.label_ReleaseYear.AutoSize = true;
            this.label_ReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ReleaseYear.Location = new System.Drawing.Point(13, 121);
            this.label_ReleaseYear.Name = "label_ReleaseYear";
            this.label_ReleaseYear.Size = new System.Drawing.Size(0, 16);
            this.label_ReleaseYear.TabIndex = 7;
            // 
            // label_CopiesNum
            // 
            this.label_CopiesNum.AutoSize = true;
            this.label_CopiesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CopiesNum.Location = new System.Drawing.Point(13, 155);
            this.label_CopiesNum.Name = "label_CopiesNum";
            this.label_CopiesNum.Size = new System.Drawing.Size(0, 16);
            this.label_CopiesNum.TabIndex = 9;
            // 
            // cb_Release_Year
            // 
            this.cb_Release_Year.FormattingEnabled = true;
            this.cb_Release_Year.Location = new System.Drawing.Point(134, 120);
            this.cb_Release_Year.Name = "cb_Release_Year";
            this.cb_Release_Year.Size = new System.Drawing.Size(91, 21);
            this.cb_Release_Year.TabIndex = 10;
            // 
            // cb_CopiesNum
            // 
            this.cb_CopiesNum.FormattingEnabled = true;
            this.cb_CopiesNum.Location = new System.Drawing.Point(134, 155);
            this.cb_CopiesNum.Name = "cb_CopiesNum";
            this.cb_CopiesNum.Size = new System.Drawing.Size(91, 21);
            this.cb_CopiesNum.TabIndex = 11;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(35, 197);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 12;
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(140, 197);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tb_bookId
            // 
            this.tb_bookId.Location = new System.Drawing.Point(70, 21);
            this.tb_bookId.Name = "tb_bookId";
            this.tb_bookId.Size = new System.Drawing.Size(137, 20);
            this.tb_bookId.TabIndex = 14;
            // 
            // FormBooksDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 237);
            this.Controls.Add(this.tb_bookId);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.cb_CopiesNum);
            this.Controls.Add(this.cb_Release_Year);
            this.Controls.Add(this.label_CopiesNum);
            this.Controls.Add(this.label_ReleaseYear);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.tb_Author);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_ID);
            this.Name = "FormBooksDetail";
            this.Load += new System.EventHandler(this.FormBooksDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_ReleaseYear;
        private System.Windows.Forms.Label label_CopiesNum;
        private System.Windows.Forms.ComboBox cb_Release_Year;
        private System.Windows.Forms.ComboBox cb_CopiesNum;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_bookId;
    }
}