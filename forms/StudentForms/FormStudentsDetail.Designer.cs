namespace Library.Forms.StudentDetails
{
    partial class FormStudentsDetail
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Class = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Name.Location = new System.Drawing.Point(20, 63);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 16);
            this.label_Name.TabIndex = 0;
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Surname.Location = new System.Drawing.Point(5, 92);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(0, 16);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Class.Location = new System.Drawing.Point(5, 120);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(0, 16);
            this.label_Class.TabIndex = 2;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_ID.Location = new System.Drawing.Point(20, 32);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(0, 16);
            this.label_ID.TabIndex = 3;
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(16, 173);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(117, 173);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(78, 32);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 20);
            this.tb_ID.TabIndex = 6;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Location = new System.Drawing.Point(78, 91);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(100, 20);
            this.tb_Surname.TabIndex = 7;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(78, 62);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 8;
            // 
            // cb_Class
            // 
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(78, 120);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(36, 21);
            this.cb_Class.TabIndex = 9;
            // 
            // FormStudentsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 220);
            this.Controls.Add(this.cb_Class);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Class);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Name = "FormStudentsDetail";
            this.Load += new System.EventHandler(this.FormStudentsDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cb_Class;
    }
}