namespace SchoolSql
{
    partial class Form1
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
            this.add_grpbx = new System.Windows.Forms.GroupBox();
            this.update_grpbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.age_nupd = new System.Windows.Forms.NumericUpDown();
            this.status_chkbx = new System.Windows.Forms.CheckBox();
            this.classes_cmbx = new System.Windows.Forms.ComboBox();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.updateClasses_cmbx = new System.Windows.Forms.ComboBox();
            this.updateStatus_chbx = new System.Windows.Forms.CheckBox();
            this.updateAge_nudp = new System.Windows.Forms.NumericUpDown();
            this.updateSurname_txt = new System.Windows.Forms.TextBox();
            this.updateName_txt = new System.Windows.Forms.TextBox();
            this.delete_grpbx = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.delete_lbl = new System.Windows.Forms.Label();
            this.add_grpbx.SuspendLayout();
            this.update_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_nupd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateAge_nudp)).BeginInit();
            this.delete_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_grpbx
            // 
            this.add_grpbx.Controls.Add(this.label5);
            this.add_grpbx.Controls.Add(this.label4);
            this.add_grpbx.Controls.Add(this.label3);
            this.add_grpbx.Controls.Add(this.label2);
            this.add_grpbx.Controls.Add(this.label1);
            this.add_grpbx.Controls.Add(this.addUser_btn);
            this.add_grpbx.Controls.Add(this.classes_cmbx);
            this.add_grpbx.Controls.Add(this.status_chkbx);
            this.add_grpbx.Controls.Add(this.age_nupd);
            this.add_grpbx.Controls.Add(this.surname_txt);
            this.add_grpbx.Controls.Add(this.name_txt);
            this.add_grpbx.Location = new System.Drawing.Point(28, 30);
            this.add_grpbx.Name = "add_grpbx";
            this.add_grpbx.Size = new System.Drawing.Size(200, 182);
            this.add_grpbx.TabIndex = 0;
            this.add_grpbx.TabStop = false;
            this.add_grpbx.Text = "Add User";
            // 
            // update_grpbx
            // 
            this.update_grpbx.Controls.Add(this.label6);
            this.update_grpbx.Controls.Add(this.label7);
            this.update_grpbx.Controls.Add(this.label8);
            this.update_grpbx.Controls.Add(this.label9);
            this.update_grpbx.Controls.Add(this.label10);
            this.update_grpbx.Controls.Add(this.update_btn);
            this.update_grpbx.Controls.Add(this.updateClasses_cmbx);
            this.update_grpbx.Controls.Add(this.updateStatus_chbx);
            this.update_grpbx.Controls.Add(this.updateAge_nudp);
            this.update_grpbx.Controls.Add(this.updateSurname_txt);
            this.update_grpbx.Controls.Add(this.updateName_txt);
            this.update_grpbx.Location = new System.Drawing.Point(28, 218);
            this.update_grpbx.Name = "update_grpbx";
            this.update_grpbx.Size = new System.Drawing.Size(200, 170);
            this.update_grpbx.TabIndex = 1;
            this.update_grpbx.TabStop = false;
            this.update_grpbx.Text = "Update User";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(480, 347);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(6, 54);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(62, 20);
            this.name_txt.TabIndex = 3;
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(6, 98);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(62, 20);
            this.surname_txt.TabIndex = 3;
            // 
            // age_nupd
            // 
            this.age_nupd.Location = new System.Drawing.Point(6, 145);
            this.age_nupd.Name = "age_nupd";
            this.age_nupd.Size = new System.Drawing.Size(80, 20);
            this.age_nupd.TabIndex = 3;
            // 
            // status_chkbx
            // 
            this.status_chkbx.AutoSize = true;
            this.status_chkbx.Location = new System.Drawing.Point(102, 56);
            this.status_chkbx.Name = "status_chkbx";
            this.status_chkbx.Size = new System.Drawing.Size(64, 17);
            this.status_chkbx.TabIndex = 3;
            this.status_chkbx.Text = "IsStatus";
            this.status_chkbx.UseVisualStyleBackColor = true;
            // 
            // classes_cmbx
            // 
            this.classes_cmbx.FormattingEnabled = true;
            this.classes_cmbx.Location = new System.Drawing.Point(102, 98);
            this.classes_cmbx.Name = "classes_cmbx";
            this.classes_cmbx.Size = new System.Drawing.Size(64, 21);
            this.classes_cmbx.TabIndex = 3;
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(102, 142);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(75, 23);
            this.addUser_btn.TabIndex = 3;
            this.addUser_btn.Text = "Add User";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Classes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Classes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Surname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Name";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(112, 126);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update User";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // updateClasses_cmbx
            // 
            this.updateClasses_cmbx.FormattingEnabled = true;
            this.updateClasses_cmbx.Location = new System.Drawing.Point(112, 82);
            this.updateClasses_cmbx.Name = "updateClasses_cmbx";
            this.updateClasses_cmbx.Size = new System.Drawing.Size(64, 21);
            this.updateClasses_cmbx.TabIndex = 10;
            // 
            // updateStatus_chbx
            // 
            this.updateStatus_chbx.AutoSize = true;
            this.updateStatus_chbx.Location = new System.Drawing.Point(112, 40);
            this.updateStatus_chbx.Name = "updateStatus_chbx";
            this.updateStatus_chbx.Size = new System.Drawing.Size(64, 17);
            this.updateStatus_chbx.TabIndex = 11;
            this.updateStatus_chbx.Text = "IsStatus";
            this.updateStatus_chbx.UseVisualStyleBackColor = true;
            // 
            // updateAge_nudp
            // 
            this.updateAge_nudp.Location = new System.Drawing.Point(16, 129);
            this.updateAge_nudp.Name = "updateAge_nudp";
            this.updateAge_nudp.Size = new System.Drawing.Size(80, 20);
            this.updateAge_nudp.TabIndex = 12;
            // 
            // updateSurname_txt
            // 
            this.updateSurname_txt.Location = new System.Drawing.Point(16, 82);
            this.updateSurname_txt.Name = "updateSurname_txt";
            this.updateSurname_txt.Size = new System.Drawing.Size(62, 20);
            this.updateSurname_txt.TabIndex = 13;
            // 
            // updateName_txt
            // 
            this.updateName_txt.Location = new System.Drawing.Point(16, 38);
            this.updateName_txt.Name = "updateName_txt";
            this.updateName_txt.Size = new System.Drawing.Size(62, 20);
            this.updateName_txt.TabIndex = 14;
            // 
            // delete_grpbx
            // 
            this.delete_grpbx.Controls.Add(this.delete_lbl);
            this.delete_grpbx.Controls.Add(this.deleteUser_btn);
            this.delete_grpbx.Controls.Add(this.label11);
            this.delete_grpbx.Location = new System.Drawing.Point(37, 479);
            this.delete_grpbx.Name = "delete_grpbx";
            this.delete_grpbx.Size = new System.Drawing.Size(200, 100);
            this.delete_grpbx.TabIndex = 3;
            this.delete_grpbx.TabStop = false;
            this.delete_grpbx.Text = "Delete";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Selected User:";
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUser_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteUser_btn.Location = new System.Drawing.Point(10, 62);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(158, 23);
            this.deleteUser_btn.TabIndex = 4;
            this.deleteUser_btn.Text = "Delete";
            this.deleteUser_btn.UseVisualStyleBackColor = false;
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // delete_lbl
            // 
            this.delete_lbl.AutoSize = true;
            this.delete_lbl.Location = new System.Drawing.Point(100, 30);
            this.delete_lbl.Name = "delete_lbl";
            this.delete_lbl.Size = new System.Drawing.Size(13, 13);
            this.delete_lbl.TabIndex = 4;
            this.delete_lbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 700);
            this.Controls.Add(this.delete_grpbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.update_grpbx);
            this.Controls.Add(this.add_grpbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.add_grpbx.ResumeLayout(false);
            this.add_grpbx.PerformLayout();
            this.update_grpbx.ResumeLayout(false);
            this.update_grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_nupd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateAge_nudp)).EndInit();
            this.delete_grpbx.ResumeLayout(false);
            this.delete_grpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox add_grpbx;
        private System.Windows.Forms.CheckBox status_chkbx;
        private System.Windows.Forms.NumericUpDown age_nupd;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.GroupBox update_grpbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.ComboBox classes_cmbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox updateClasses_cmbx;
        private System.Windows.Forms.CheckBox updateStatus_chbx;
        private System.Windows.Forms.NumericUpDown updateAge_nudp;
        private System.Windows.Forms.TextBox updateSurname_txt;
        private System.Windows.Forms.TextBox updateName_txt;
        private System.Windows.Forms.GroupBox delete_grpbx;
        private System.Windows.Forms.Label delete_lbl;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Label label11;
    }
}

