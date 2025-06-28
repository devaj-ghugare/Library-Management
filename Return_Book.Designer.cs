namespace Library_Management
{
    partial class Return_Book
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePickerreturn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.dateTimePickerborrow = new System.Windows.Forms.DateTimePicker();
            this.btnreturn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(43, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 576);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 558);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dateTimePickerreturn);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtbname);
            this.panel5.Controls.Add(this.dateTimePickerborrow);
            this.panel5.Controls.Add(this.btnreturn);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(2, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 378);
            this.panel5.TabIndex = 25;
            // 
            // dateTimePickerreturn
            // 
            this.dateTimePickerreturn.CalendarFont = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerreturn.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerreturn.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerreturn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerreturn.Location = new System.Drawing.Point(207, 198);
            this.dateTimePickerreturn.Name = "dateTimePickerreturn";
            this.dateTimePickerreturn.Size = new System.Drawing.Size(194, 23);
            this.dateTimePickerreturn.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(72, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(72, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Book Name";
            // 
            // txtbname
            // 
            this.txtbname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbname.ForeColor = System.Drawing.Color.DimGray;
            this.txtbname.Location = new System.Drawing.Point(207, 49);
            this.txtbname.Name = "txtbname";
            this.txtbname.ReadOnly = true;
            this.txtbname.Size = new System.Drawing.Size(194, 23);
            this.txtbname.TabIndex = 12;
            // 
            // dateTimePickerborrow
            // 
            this.dateTimePickerborrow.CalendarFont = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerborrow.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerborrow.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerborrow.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerborrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerborrow.Location = new System.Drawing.Point(207, 121);
            this.dateTimePickerborrow.Name = "dateTimePickerborrow";
            this.dateTimePickerborrow.Size = new System.Drawing.Size(194, 23);
            this.dateTimePickerborrow.TabIndex = 20;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Red;
            this.btnreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreturn.FlatAppearance.BorderSize = 0;
            this.btnreturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(301, 279);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(145, 41);
            this.btnreturn.TabIndex = 13;
            this.btnreturn.Text = "RETURN";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(72, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Borrow Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnsearch);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtmname);
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 72);
            this.panel4.TabIndex = 24;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Red;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(350, 23);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(98, 29);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Member Name";
            // 
            // txtmname
            // 
            this.txtmname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtmname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.ForeColor = System.Drawing.Color.DimGray;
            this.txtmname.Location = new System.Drawing.Point(157, 26);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(171, 23);
            this.txtmname.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 64);
            this.panel3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(469, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "RETURN BOOK";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(692, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(554, 615);
            this.Controls.Add(this.panel1);
            this.Name = "Return_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Book";
            this.Load += new System.EventHandler(this.Return_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerborrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.DateTimePicker dateTimePickerreturn;
        private System.Windows.Forms.Label label2;
    }
}