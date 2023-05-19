namespace HomeLibrary
{
    partial class LoanedBooksForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            checkoutBindingSource = new System.Windows.Forms.BindingSource(components);
            btnReturned = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();
            CheckoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkoutBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CheckoutID, personIDDataGridViewTextBoxColumn });
            dataGridView1.DataSource = checkoutBindingSource;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(776, 212);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // checkoutBindingSource
            // 
            checkoutBindingSource.DataSource = typeof(Checkout);
            // 
            // btnReturned
            // 
            btnReturned.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnReturned.Location = new System.Drawing.Point(659, 310);
            btnReturned.Name = "btnReturned";
            btnReturned.Size = new System.Drawing.Size(129, 23);
            btnReturned.TabIndex = 11;
            btnReturned.Text = "Returned";
            btnReturned.UseVisualStyleBackColor = true;
            btnReturned.Click += btnReturned_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSubmit.Location = new System.Drawing.Point(524, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(129, 23);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit Changes";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CheckoutID
            // 
            CheckoutID.DataPropertyName = "CheckoutID";
            CheckoutID.HeaderText = "CheckoutID";
            CheckoutID.Name = "CheckoutID";
            CheckoutID.ReadOnly = true;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            personIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LoanedBooksForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 345);
            Controls.Add(btnSubmit);
            Controls.Add(btnReturned);
            Controls.Add(dataGridView1);
            Name = "LoanedBooksForm";
            Text = "LoanedBooksForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkoutBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReturned;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
    }
}