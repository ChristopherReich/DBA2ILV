namespace HomeLibrary
{
    partial class LoanForm
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
            components = new System.ComponentModel.Container();
            btnSubmit = new System.Windows.Forms.Button();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            lbBook = new System.Windows.Forms.Label();
            lbISBN = new System.Windows.Forms.Label();
            cbLoaner = new System.Windows.Forms.ComboBox();
            personBindingSource = new System.Windows.Forms.BindingSource(components);
            lbLoaner = new System.Windows.Forms.Label();
            lbStartDate = new System.Windows.Forms.Label();
            lbEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(197, 226);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(62, 121);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(200, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(62, 150);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(200, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // lbBook
            // 
            lbBook.AutoSize = true;
            lbBook.Location = new System.Drawing.Point(12, 23);
            lbBook.Name = "lbBook";
            lbBook.Size = new System.Drawing.Size(44, 15);
            lbBook.TabIndex = 3;
            lbBook.Text = "lbBook";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new System.Drawing.Point(12, 54);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new System.Drawing.Size(42, 15);
            lbISBN.TabIndex = 4;
            lbISBN.Text = "lbISBN";
            // 
            // cbLoaner
            // 
            cbLoaner.DataSource = personBindingSource;
            cbLoaner.DisplayMember = "Name";
            cbLoaner.FormattingEnabled = true;
            cbLoaner.Location = new System.Drawing.Point(62, 92);
            cbLoaner.Name = "cbLoaner";
            cbLoaner.Size = new System.Drawing.Size(121, 23);
            cbLoaner.TabIndex = 5;
            cbLoaner.ValueMember = "PersonID";
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // lbLoaner
            // 
            lbLoaner.AutoSize = true;
            lbLoaner.Location = new System.Drawing.Point(13, 95);
            lbLoaner.Name = "lbLoaner";
            lbLoaner.Size = new System.Drawing.Size(43, 15);
            lbLoaner.TabIndex = 6;
            lbLoaner.Text = "Loaner";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new System.Drawing.Point(13, 127);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new System.Drawing.Size(31, 15);
            lbStartDate.TabIndex = 7;
            lbStartDate.Text = "Start";
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Location = new System.Drawing.Point(13, 156);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new System.Drawing.Size(27, 15);
            lbEnd.TabIndex = 8;
            lbEnd.Text = "End";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(lbEnd);
            Controls.Add(lbStartDate);
            Controls.Add(lbLoaner);
            Controls.Add(cbLoaner);
            Controls.Add(lbISBN);
            Controls.Add(lbBook);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnSubmit);
            Name = "LoanForm";
            Text = "LoanForm";
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.ComboBox cbLoaner;
        private System.Windows.Forms.Label lbLoaner;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEnd;
    }
}