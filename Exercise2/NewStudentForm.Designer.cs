namespace Exercise2
{
    partial class NewStudentForm
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
            btnSave = new System.Windows.Forms.Button();
            textbox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textbox2 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            combobox1 = new System.Windows.Forms.ComboBox();
            textbox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(273, 149);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(81, 22);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textbox1
            // 
            textbox1.Location = new System.Drawing.Point(98, 12);
            textbox1.Name = "textbox1";
            textbox1.Size = new System.Drawing.Size(138, 23);
            textbox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Prename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Surname";
            // 
            // textbox2
            // 
            textbox2.Location = new System.Drawing.Point(98, 45);
            textbox2.Name = "textbox2";
            textbox2.Size = new System.Drawing.Size(138, 23);
            textbox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Department";
            // 
            // combobox1
            // 
            combobox1.FormattingEnabled = true;
            combobox1.Location = new System.Drawing.Point(98, 111);
            combobox1.Name = "combobox1";
            combobox1.Size = new System.Drawing.Size(257, 23);
            combobox1.TabIndex = 8;
            // 
            // textbox3
            // 
            textbox3.Location = new System.Drawing.Point(98, 77);
            textbox3.Name = "textbox3";
            textbox3.Size = new System.Drawing.Size(138, 23);
            textbox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Mat.Nr.";
            // 
            // NewItemForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(361, 176);
            Controls.Add(label3);
            Controls.Add(textbox3);
            Controls.Add(combobox1);
            Controls.Add(label4);
            Controls.Add(textbox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textbox1);
            Controls.Add(btnSave);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "NewItemForm";
            Text = "New Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.Label label3;
    }
}