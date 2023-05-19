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
            BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkoutBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CheckoutID, personIDDataGridViewTextBoxColumn, BookID });
            dataGridView1.DataSource = checkoutBindingSource;
            dataGridView1.Location = new System.Drawing.Point(22, 26);
            dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1441, 452);
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
            btnReturned.Location = new System.Drawing.Point(1224, 661);
            btnReturned.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnReturned.Name = "btnReturned";
            btnReturned.Size = new System.Drawing.Size(240, 49);
            btnReturned.TabIndex = 11;
            btnReturned.Text = "Returned";
            btnReturned.UseVisualStyleBackColor = true;
            btnReturned.Click += btnReturned_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSubmit.Location = new System.Drawing.Point(973, 661);
            btnSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(240, 49);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit Changes";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CheckoutID
            // 
            CheckoutID.DataPropertyName = "CheckoutID";
            CheckoutID.HeaderText = "CheckoutID";
            CheckoutID.MinimumWidth = 10;
            CheckoutID.Name = "CheckoutID";
            CheckoutID.ReadOnly = true;
            CheckoutID.Width = 200;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            personIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            personIDDataGridViewTextBoxColumn.ReadOnly = true;
            personIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // BookID
            // 
            BookID.DataPropertyName = "BookID";
            BookID.HeaderText = "BookID";
            BookID.MinimumWidth = 10;
            BookID.Name = "BookID";
            BookID.Width = 200;
            // 
            // LoanedBooksForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1486, 736);
            Controls.Add(btnSubmit);
            Controls.Add(btnReturned);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
    }
}