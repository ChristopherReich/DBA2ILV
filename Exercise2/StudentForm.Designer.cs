namespace Exercise2
{
    partial class StudentForm
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
            surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            preNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            matNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department = new System.Windows.Forms.DataGridViewComboBoxColumn();
            departmentBindingSource = new System.Windows.Forms.BindingSource(components);
            studentBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSubmit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { surNameDataGridViewTextBoxColumn, preNameDataGridViewTextBoxColumn, matNoDataGridViewTextBoxColumn, Department });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new System.Drawing.Point(12, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(771, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            surNameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // preNameDataGridViewTextBoxColumn
            // 
            preNameDataGridViewTextBoxColumn.DataPropertyName = "PreName";
            preNameDataGridViewTextBoxColumn.HeaderText = "Prename";
            preNameDataGridViewTextBoxColumn.Name = "preNameDataGridViewTextBoxColumn";
            // 
            // matNoDataGridViewTextBoxColumn
            // 
            matNoDataGridViewTextBoxColumn.DataPropertyName = "MatNo";
            matNoDataGridViewTextBoxColumn.HeaderText = "Mat.Nr.";
            matNoDataGridViewTextBoxColumn.Name = "matNoDataGridViewTextBoxColumn";
            // 
            // Department
            // 
            Department.DataPropertyName = "DepID";
            Department.DataSource = departmentBindingSource;
            Department.DisplayMember = "Name";
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ValueMember = "DepID";
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(ormExample.Department);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(ormExample.Student);
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(654, 302);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(129, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit Changes";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(12, 303);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(81, 22);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { departmentToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(795, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            departmentToolStripMenuItem.Text = "Department";
            departmentToolStripMenuItem.Click += departmentToolStripMenuItem_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(97, 303);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(81, 22);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(795, 337);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "StudentForm";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Department;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
    }
}