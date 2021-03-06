namespace Backend_Practice
{
    partial class ManageUsers
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.avatarURLInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.TextBox();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.MemberStatusOption = new System.Windows.Forms.RadioButton();
            this.statusGB = new System.Windows.Forms.GroupBox();
            this.AdminStatusOption = new System.Windows.Forms.RadioButton();
            this.roleGB = new System.Windows.Forms.GroupBox();
            this.BackEndOption = new System.Windows.Forms.RadioButton();
            this.FrontEndOption = new System.Windows.Forms.RadioButton();
            this.FullstackOption = new System.Windows.Forms.RadioButton();
            this.signupBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.statusGB.SuspendLayout();
            this.roleGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(774, 73);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(396, 26);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameInput_KeyPress);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(774, 134);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(396, 26);
            this.emailInput.TabIndex = 1;
            // 
            // avatarURLInput
            // 
            this.avatarURLInput.Location = new System.Drawing.Point(774, 314);
            this.avatarURLInput.Name = "avatarURLInput";
            this.avatarURLInput.Size = new System.Drawing.Size(396, 26);
            this.avatarURLInput.TabIndex = 2;
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(774, 255);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(174, 26);
            this.stateInput.TabIndex = 3;
            this.stateInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stateInput_KeyPress);
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new System.Drawing.Point(774, 195);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(174, 26);
            this.firstnameInput.TabIndex = 4;
            this.firstnameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnameInput_KeyPress);
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(982, 195);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(188, 26);
            this.lastnameInput.TabIndex = 5;
            this.lastnameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastnameInput_KeyPress);
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Location = new System.Drawing.Point(774, 442);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(396, 26);
            this.confirmPasswordInput.TabIndex = 6;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(982, 255);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(188, 26);
            this.addressInput.TabIndex = 7;
            this.addressInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressInput_KeyPress);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(774, 378);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(396, 26);
            this.passwordInput.TabIndex = 8;
            // 
            // MemberStatusOption
            // 
            this.MemberStatusOption.AutoSize = true;
            this.MemberStatusOption.Checked = true;
            this.MemberStatusOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemberStatusOption.Location = new System.Drawing.Point(6, 25);
            this.MemberStatusOption.Name = "MemberStatusOption";
            this.MemberStatusOption.Size = new System.Drawing.Size(91, 24);
            this.MemberStatusOption.TabIndex = 9;
            this.MemberStatusOption.TabStop = true;
            this.MemberStatusOption.Text = "Member";
            this.MemberStatusOption.UseVisualStyleBackColor = true;
            // 
            // statusGB
            // 
            this.statusGB.Controls.Add(this.AdminStatusOption);
            this.statusGB.Controls.Add(this.MemberStatusOption);
            this.statusGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGB.ForeColor = System.Drawing.Color.White;
            this.statusGB.Location = new System.Drawing.Point(973, 488);
            this.statusGB.Name = "statusGB";
            this.statusGB.Size = new System.Drawing.Size(147, 126);
            this.statusGB.TabIndex = 11;
            this.statusGB.TabStop = false;
            this.statusGB.Text = "Status";
            // 
            // AdminStatusOption
            // 
            this.AdminStatusOption.AutoSize = true;
            this.AdminStatusOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminStatusOption.Location = new System.Drawing.Point(6, 55);
            this.AdminStatusOption.Name = "AdminStatusOption";
            this.AdminStatusOption.Size = new System.Drawing.Size(77, 24);
            this.AdminStatusOption.TabIndex = 10;
            this.AdminStatusOption.Text = "Admin";
            this.AdminStatusOption.UseVisualStyleBackColor = true;
            // 
            // roleGB
            // 
            this.roleGB.Controls.Add(this.BackEndOption);
            this.roleGB.Controls.Add(this.FrontEndOption);
            this.roleGB.Controls.Add(this.FullstackOption);
            this.roleGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleGB.ForeColor = System.Drawing.Color.White;
            this.roleGB.Location = new System.Drawing.Point(792, 488);
            this.roleGB.Name = "roleGB";
            this.roleGB.Size = new System.Drawing.Size(147, 126);
            this.roleGB.TabIndex = 12;
            this.roleGB.TabStop = false;
            this.roleGB.Text = "Role";
            // 
            // BackEndOption
            // 
            this.BackEndOption.AutoSize = true;
            this.BackEndOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackEndOption.Location = new System.Drawing.Point(6, 85);
            this.BackEndOption.Name = "BackEndOption";
            this.BackEndOption.Size = new System.Drawing.Size(105, 24);
            this.BackEndOption.TabIndex = 11;
            this.BackEndOption.Text = "Back-End";
            this.BackEndOption.UseVisualStyleBackColor = true;
            // 
            // FrontEndOption
            // 
            this.FrontEndOption.AutoSize = true;
            this.FrontEndOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrontEndOption.Location = new System.Drawing.Point(6, 55);
            this.FrontEndOption.Name = "FrontEndOption";
            this.FrontEndOption.Size = new System.Drawing.Size(108, 24);
            this.FrontEndOption.TabIndex = 10;
            this.FrontEndOption.Text = "Front-End";
            this.FrontEndOption.UseVisualStyleBackColor = true;
            // 
            // FullstackOption
            // 
            this.FullstackOption.AutoSize = true;
            this.FullstackOption.Checked = true;
            this.FullstackOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullstackOption.Location = new System.Drawing.Point(6, 25);
            this.FullstackOption.Name = "FullstackOption";
            this.FullstackOption.Size = new System.Drawing.Size(99, 24);
            this.FullstackOption.TabIndex = 9;
            this.FullstackOption.TabStop = true;
            this.FullstackOption.Text = "Fullstack";
            this.FullstackOption.UseVisualStyleBackColor = true;
            // 
            // signupBtn
            // 
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Location = new System.Drawing.Point(792, 635);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(328, 33);
            this.signupBtn.TabIndex = 13;
            this.signupBtn.Text = "Insert";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(770, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(770, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(982, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(770, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(770, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(984, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(770, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Avatar URL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(770, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(775, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Confirm Password";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(30, 152);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(713, 521);
            this.dataGridView.TabIndex = 55;
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Location = new System.Drawing.Point(61, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(193, 36);
            this.btnSelect.TabIndex = 54;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(284, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 36);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(512, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 36);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDB.Location = new System.Drawing.Point(61, 50);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(644, 36);
            this.btnUpdateDB.TabIndex = 58;
            this.btnUpdateDB.Text = "Update Database";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.roleGB);
            this.Controls.Add(this.statusGB);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.lastnameInput);
            this.Controls.Add(this.firstnameInput);
            this.Controls.Add(this.stateInput);
            this.Controls.Add(this.avatarURLInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.usernameInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.statusGB.ResumeLayout(false);
            this.statusGB.PerformLayout();
            this.roleGB.ResumeLayout(false);
            this.roleGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox avatarURLInput;
        private System.Windows.Forms.TextBox stateInput;
        private System.Windows.Forms.TextBox firstnameInput;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.TextBox confirmPasswordInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.RadioButton MemberStatusOption;
        private System.Windows.Forms.GroupBox statusGB;
        private System.Windows.Forms.RadioButton AdminStatusOption;
        private System.Windows.Forms.GroupBox roleGB;
        private System.Windows.Forms.RadioButton BackEndOption;
        private System.Windows.Forms.RadioButton FrontEndOption;
        private System.Windows.Forms.RadioButton FullstackOption;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateDB;
    }
}