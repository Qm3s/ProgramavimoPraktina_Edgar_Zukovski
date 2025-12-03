namespace Project_IS.UI
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelTitle = new Label();
            DataGridUsers = new DataGridView();
            labelFirstName = new Label();
            txtFirstName = new MaskedTextBox();
            txtLastName = new MaskedTextBox();
            labelLastName = new Label();
            labelRole = new Label();
            comboRole = new ComboBox();
            LabelCreatUser = new Label();
            txtPassword = new MaskedTextBox();
            label1 = new Label();
            txtUsername = new MaskedTextBox();
            UserNameLabel = new Label();
            buttonAddUser = new Button();
            buttonLogout = new Button();
            buttonUpdateUser = new Button();
            buttonDeleteUser = new Button();
            FirstNameEdit = new MaskedTextBox();
            EditFirstName = new Label();
            txtEditLastName = new MaskedTextBox();
            EditLastName = new Label();
            txtEditUsername = new MaskedTextBox();
            EditUsername = new Label();
            txtEditPassword = new MaskedTextBox();
            EditPassword = new Label();
            comboEditRole = new ComboBox();
            EditRole = new Label();
            CreateUser = new Label();
            EditUser = new Label();
            DataGridGroups = new DataGridView();
            labelGroupsTitle = new Label();
            txtGroupName = new TextBox();
            buttonAddGroup = new Button();
            buttonUpdateGroup = new Button();
            txtEditGroupName = new TextBox();
            labelEditGroupName = new Label();
            buttonDeleteGroup = new Button();
            DataGridSubjects = new DataGridView();
            labelSubjectName = new Label();
            txtSubjectName = new TextBox();
            label2 = new Label();
            labelEditSubjectName = new Label();
            txtEditSubjectName = new TextBox();
            buttonAddSubject = new Button();
            buttonDeleteSubject = new Button();
            labelStudentGroupTitle = new Label();
            comboStudentsForGroup = new ComboBox();
            labelGroupName = new Label();
            labelStudentForGroup = new Label();
            comboGroupsForStudent = new ComboBox();
            labelGroupForStudent = new Label();
            buttonAssignStudentToGroup = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridSubjects).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.Location = new Point(369, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(133, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admin Panel";
            // 
            // DataGridUsers
            // 
            DataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridUsers.Location = new Point(220, 62);
            DataGridUsers.Name = "DataGridUsers";
            DataGridUsers.Size = new Size(441, 150);
            DataGridUsers.TabIndex = 1;
            DataGridUsers.CellClick += DataGridUsers_CellClick;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(21, 62);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(65, 15);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(92, 59);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(91, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(21, 91);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(64, 15);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last name:";
            // 
            // labelRole
            // 
            labelRole.Location = new Point(46, 178);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(39, 23);
            labelRole.TabIndex = 10;
            labelRole.Text = "Role:";
            // 
            // comboRole
            // 
            comboRole.Items.AddRange(new object[] { "teacher", "student", "admin" });
            comboRole.Location = new Point(91, 175);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(100, 23);
            comboRole.TabIndex = 11;
            // 
            // LabelCreatUser
            // 
            LabelCreatUser.Location = new Point(0, 0);
            LabelCreatUser.Name = "LabelCreatUser";
            LabelCreatUser.Size = new Size(100, 23);
            LabelCreatUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(92, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 9;
            // 
            // label1
            // 
            label1.Location = new Point(26, 149);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 8;
            label1.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(91, 117);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 7;
            // 
            // UserNameLabel
            // 
            UserNameLabel.Location = new Point(22, 120);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(64, 23);
            UserNameLabel.TabIndex = 6;
            UserNameLabel.Text = "Username:";
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(92, 214);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(75, 23);
            buttonAddUser.TabIndex = 12;
            buttonAddUser.Text = "Add";
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(893, 19);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 25;
            buttonLogout.Text = "Logout";
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonUpdateUser
            // 
            buttonUpdateUser.Location = new Point(868, 102);
            buttonUpdateUser.Name = "buttonUpdateUser";
            buttonUpdateUser.Size = new Size(75, 23);
            buttonUpdateUser.TabIndex = 23;
            buttonUpdateUser.Text = "Update";
            buttonUpdateUser.Click += buttonUpdateUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(868, 136);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(75, 23);
            buttonDeleteUser.TabIndex = 24;
            buttonDeleteUser.Text = "Delete";
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // FirstNameEdit
            // 
            FirstNameEdit.Location = new Point(748, 74);
            FirstNameEdit.Name = "FirstNameEdit";
            FirstNameEdit.Size = new Size(100, 23);
            FirstNameEdit.TabIndex = 14;
            // 
            // EditFirstName
            // 
            EditFirstName.Location = new Point(679, 77);
            EditFirstName.Name = "EditFirstName";
            EditFirstName.Size = new Size(67, 23);
            EditFirstName.TabIndex = 13;
            EditFirstName.Text = "First name:";
            // 
            // txtEditLastName
            // 
            txtEditLastName.Location = new Point(748, 103);
            txtEditLastName.Name = "txtEditLastName";
            txtEditLastName.Size = new Size(100, 23);
            txtEditLastName.TabIndex = 16;
            // 
            // EditLastName
            // 
            EditLastName.Location = new Point(677, 106);
            EditLastName.Name = "EditLastName";
            EditLastName.Size = new Size(65, 23);
            EditLastName.TabIndex = 15;
            EditLastName.Text = "Last name:";
            // 
            // txtEditUsername
            // 
            txtEditUsername.Location = new Point(748, 133);
            txtEditUsername.Name = "txtEditUsername";
            txtEditUsername.Size = new Size(100, 23);
            txtEditUsername.TabIndex = 18;
            // 
            // EditUsername
            // 
            EditUsername.Location = new Point(679, 136);
            EditUsername.Name = "EditUsername";
            EditUsername.Size = new Size(63, 23);
            EditUsername.TabIndex = 17;
            EditUsername.Text = "Username:";
            // 
            // txtEditPassword
            // 
            txtEditPassword.Location = new Point(748, 162);
            txtEditPassword.Name = "txtEditPassword";
            txtEditPassword.Size = new Size(100, 23);
            txtEditPassword.TabIndex = 20;
            // 
            // EditPassword
            // 
            EditPassword.Location = new Point(683, 165);
            EditPassword.Name = "EditPassword";
            EditPassword.Size = new Size(63, 23);
            EditPassword.TabIndex = 19;
            EditPassword.Text = "Password:";
            // 
            // comboEditRole
            // 
            comboEditRole.Items.AddRange(new object[] { "student", "teacher", "admin" });
            comboEditRole.Location = new Point(748, 191);
            comboEditRole.Name = "comboEditRole";
            comboEditRole.Size = new Size(100, 23);
            comboEditRole.TabIndex = 22;
            // 
            // EditRole
            // 
            EditRole.Location = new Point(707, 188);
            EditRole.Name = "EditRole";
            EditRole.Size = new Size(35, 23);
            EditRole.TabIndex = 21;
            EditRole.Text = "Role:";
            // 
            // CreateUser
            // 
            CreateUser.AutoSize = true;
            CreateUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateUser.Location = new Point(70, 15);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(110, 25);
            CreateUser.TabIndex = 26;
            CreateUser.Text = "Create User";
            // 
            // EditUser
            // 
            EditUser.AutoSize = true;
            EditUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditUser.Location = new Point(748, 29);
            EditUser.Name = "EditUser";
            EditUser.Size = new Size(87, 25);
            EditUser.TabIndex = 27;
            EditUser.Text = "Edit User";
            // 
            // DataGridGroups
            // 
            DataGridGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridGroups.Location = new Point(92, 320);
            DataGridGroups.Name = "DataGridGroups";
            DataGridGroups.ReadOnly = true;
            DataGridGroups.Size = new Size(175, 150);
            DataGridGroups.TabIndex = 28;
            DataGridGroups.CellContentClick += DataGridGroups_CellContentClick;
            // 
            // labelGroupsTitle
            // 
            labelGroupsTitle.AutoSize = true;
            labelGroupsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroupsTitle.Location = new Point(10, 280);
            labelGroupsTitle.Name = "labelGroupsTitle";
            labelGroupsTitle.Size = new Size(61, 21);
            labelGroupsTitle.TabIndex = 29;
            labelGroupsTitle.Text = "Groups";
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(10, 338);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(76, 23);
            txtGroupName.TabIndex = 31;
            // 
            // buttonAddGroup
            // 
            buttonAddGroup.Location = new Point(10, 367);
            buttonAddGroup.Name = "buttonAddGroup";
            buttonAddGroup.Size = new Size(75, 23);
            buttonAddGroup.TabIndex = 32;
            buttonAddGroup.Text = "Add group";
            buttonAddGroup.UseVisualStyleBackColor = true;
            buttonAddGroup.Click += buttonAddGroup_Click;
            // 
            // buttonUpdateGroup
            // 
            buttonUpdateGroup.Location = new Point(283, 396);
            buttonUpdateGroup.Name = "buttonUpdateGroup";
            buttonUpdateGroup.Size = new Size(75, 23);
            buttonUpdateGroup.TabIndex = 35;
            buttonUpdateGroup.Text = "Update";
            buttonUpdateGroup.UseVisualStyleBackColor = true;
            buttonUpdateGroup.Click += buttonUpdateGroup_Click;
            // 
            // txtEditGroupName
            // 
            txtEditGroupName.Location = new Point(282, 338);
            txtEditGroupName.Name = "txtEditGroupName";
            txtEditGroupName.Size = new Size(76, 23);
            txtEditGroupName.TabIndex = 34;
            // 
            // labelEditGroupName
            // 
            labelEditGroupName.AutoSize = true;
            labelEditGroupName.Location = new Point(282, 320);
            labelEditGroupName.Name = "labelEditGroupName";
            labelEditGroupName.Size = new Size(65, 15);
            labelEditGroupName.TabIndex = 33;
            labelEditGroupName.Text = "Edit group:";
            // 
            // buttonDeleteGroup
            // 
            buttonDeleteGroup.Location = new Point(283, 367);
            buttonDeleteGroup.Name = "buttonDeleteGroup";
            buttonDeleteGroup.Size = new Size(75, 23);
            buttonDeleteGroup.TabIndex = 36;
            buttonDeleteGroup.Text = "Delete";
            buttonDeleteGroup.UseVisualStyleBackColor = true;
            buttonDeleteGroup.Click += buttonDeleteGroup_Click;
            // 
            // DataGridSubjects
            // 
            DataGridSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridSubjects.Location = new Point(563, 320);
            DataGridSubjects.Name = "DataGridSubjects";
            DataGridSubjects.Size = new Size(240, 150);
            DataGridSubjects.TabIndex = 37;
            DataGridSubjects.CellContentClick += DataGridSubjects_CellContentClick;
            // 
            // labelSubjectName
            // 
            labelSubjectName.AutoSize = true;
            labelSubjectName.Location = new Point(369, 317);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(82, 15);
            labelSubjectName.TabIndex = 38;
            labelSubjectName.Text = "Subject name:";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(457, 317);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(100, 23);
            txtSubjectName.TabIndex = 39;
            txtSubjectName.TextChanged += txtSubjectName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 40;
            label2.Text = "label2";
            // 
            // labelEditSubjectName
            // 
            labelEditSubjectName.AutoSize = true;
            labelEditSubjectName.Location = new Point(816, 320);
            labelEditSubjectName.Name = "labelEditSubjectName";
            labelEditSubjectName.Size = new Size(71, 15);
            labelEditSubjectName.TabIndex = 41;
            labelEditSubjectName.Text = "Edit subject:";
            // 
            // txtEditSubjectName
            // 
            txtEditSubjectName.Location = new Point(893, 320);
            txtEditSubjectName.Name = "txtEditSubjectName";
            txtEditSubjectName.Size = new Size(100, 23);
            txtEditSubjectName.TabIndex = 42;
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.Location = new Point(468, 346);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(75, 23);
            buttonAddSubject.TabIndex = 43;
            buttonAddSubject.Text = "Add subject";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += buttonAddSubject_Click;
            // 
            // buttonDeleteSubject
            // 
            buttonDeleteSubject.Location = new Point(902, 349);
            buttonDeleteSubject.Name = "buttonDeleteSubject";
            buttonDeleteSubject.Size = new Size(75, 23);
            buttonDeleteSubject.TabIndex = 45;
            buttonDeleteSubject.Text = "Delete subject";
            buttonDeleteSubject.UseVisualStyleBackColor = true;
            buttonDeleteSubject.Click += buttonDeleteSubject_Click;
            // 
            // labelStudentGroupTitle
            // 
            labelStudentGroupTitle.AutoSize = true;
            labelStudentGroupTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStudentGroupTitle.Location = new Point(81, 542);
            labelStudentGroupTitle.Name = "labelStudentGroupTitle";
            labelStudentGroupTitle.Size = new Size(147, 25);
            labelStudentGroupTitle.TabIndex = 46;
            labelStudentGroupTitle.Text = "Student - Group";
            // 
            // comboStudentsForGroup
            // 
            comboStudentsForGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStudentsForGroup.FormattingEnabled = true;
            comboStudentsForGroup.Location = new Point(107, 617);
            comboStudentsForGroup.Name = "comboStudentsForGroup";
            comboStudentsForGroup.Size = new Size(121, 23);
            comboStudentsForGroup.TabIndex = 47;
            // 
            // labelGroupName
            // 
            labelGroupName.AutoSize = true;
            labelGroupName.Location = new Point(10, 320);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new Size(76, 15);
            labelGroupName.TabIndex = 30;
            labelGroupName.Text = "Group name:";
            // 
            // labelStudentForGroup
            // 
            labelStudentForGroup.AutoSize = true;
            labelStudentForGroup.Location = new Point(50, 620);
            labelStudentForGroup.Name = "labelStudentForGroup";
            labelStudentForGroup.Size = new Size(51, 15);
            labelStudentForGroup.TabIndex = 48;
            labelStudentForGroup.Text = "Student:";
            // 
            // comboGroupsForStudent
            // 
            comboGroupsForStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGroupsForStudent.FormattingEnabled = true;
            comboGroupsForStudent.Location = new Point(107, 646);
            comboGroupsForStudent.Name = "comboGroupsForStudent";
            comboGroupsForStudent.Size = new Size(121, 23);
            comboGroupsForStudent.TabIndex = 49;
            // 
            // labelGroupForStudent
            // 
            labelGroupForStudent.AutoSize = true;
            labelGroupForStudent.Location = new Point(58, 649);
            labelGroupForStudent.Name = "labelGroupForStudent";
            labelGroupForStudent.Size = new Size(43, 15);
            labelGroupForStudent.TabIndex = 50;
            labelGroupForStudent.Text = "Group:";
            // 
            // buttonAssignStudentToGroup
            // 
            buttonAssignStudentToGroup.Location = new Point(109, 675);
            buttonAssignStudentToGroup.Name = "buttonAssignStudentToGroup";
            buttonAssignStudentToGroup.Size = new Size(119, 23);
            buttonAssignStudentToGroup.TabIndex = 51;
            buttonAssignStudentToGroup.Text = "Assign to group";
            buttonAssignStudentToGroup.UseVisualStyleBackColor = true;
            buttonAssignStudentToGroup.Click += buttonAssignStudentToGroup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(27, 720);
            label3.Name = "label3";
            label3.Size = new Size(331, 20);
            label3.TabIndex = 52;
            label3.Text = "Studentas BUTINAI turi but priskirtas prie grupes.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 583);
            label4.Name = "label4";
            label4.Size = new Size(319, 20);
            label4.TabIndex = 53;
            label4.Text = "Kad pamatyti gruope reikia perkraut programa";
            // 
            // AdminForm
            // 
            ClientSize = new Size(1033, 843);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonAssignStudentToGroup);
            Controls.Add(labelGroupForStudent);
            Controls.Add(comboGroupsForStudent);
            Controls.Add(labelStudentForGroup);
            Controls.Add(comboStudentsForGroup);
            Controls.Add(labelStudentGroupTitle);
            Controls.Add(buttonDeleteSubject);
            Controls.Add(buttonAddSubject);
            Controls.Add(txtEditSubjectName);
            Controls.Add(labelEditSubjectName);
            Controls.Add(label2);
            Controls.Add(txtSubjectName);
            Controls.Add(labelSubjectName);
            Controls.Add(DataGridSubjects);
            Controls.Add(buttonDeleteGroup);
            Controls.Add(buttonUpdateGroup);
            Controls.Add(txtEditGroupName);
            Controls.Add(labelEditGroupName);
            Controls.Add(buttonAddGroup);
            Controls.Add(txtGroupName);
            Controls.Add(labelGroupName);
            Controls.Add(labelGroupsTitle);
            Controls.Add(DataGridGroups);
            Controls.Add(EditUser);
            Controls.Add(CreateUser);
            Controls.Add(labelTitle);
            Controls.Add(DataGridUsers);
            Controls.Add(labelFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(labelLastName);
            Controls.Add(txtLastName);
            Controls.Add(UserNameLabel);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(labelRole);
            Controls.Add(comboRole);
            Controls.Add(buttonAddUser);
            Controls.Add(EditFirstName);
            Controls.Add(FirstNameEdit);
            Controls.Add(EditLastName);
            Controls.Add(txtEditLastName);
            Controls.Add(EditUsername);
            Controls.Add(txtEditUsername);
            Controls.Add(EditPassword);
            Controls.Add(txtEditPassword);
            Controls.Add(EditRole);
            Controls.Add(comboEditRole);
            Controls.Add(buttonUpdateUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonLogout);
            Name = "AdminForm";
            Text = "Admin Form";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView DataGridUsers;

        private Label labelFirstName;
        private MaskedTextBox txtFirstName;
        private MaskedTextBox txtLastName;
        private Label labelLastName;
        private Label labelRole;
        private ComboBox comboRole;
        private Label LabelCreatUser;
        private MaskedTextBox txtPassword;
        private Label label1;
        private MaskedTextBox txtUsername;
        private Label UserNameLabel;
        private Button buttonAddUser;

        private Button buttonLogout;
        private Button buttonUpdateUser;
        private Button buttonDeleteUser;

        private MaskedTextBox FirstNameEdit;
        private Label EditFirstName;
        private MaskedTextBox txtEditLastName;
        private Label EditLastName;
        private MaskedTextBox txtEditUsername;
        private Label EditUsername;
        private MaskedTextBox txtEditPassword;
        private Label EditPassword;
        private ComboBox comboEditRole;
        private Label EditRole;
        private Label CreateUser;
        private Label EditUser;
        private DataGridView DataGridGroups;
        private Label labelGroupsTitle;
        private TextBox txtGroupName;
        private Button buttonAddGroup;
        private Button buttonUpdateGroup;
        private TextBox txtEditGroupName;
        private Label labelEditGroupName;
        private Button buttonDeleteGroup;
        private DataGridView DataGridSubjects;
        private Label labelSubjectName;
        private TextBox txtSubjectName;
        private Label label2;
        private Label labelEditSubjectName;
        private TextBox txtEditSubjectName;
        private Button buttonAddSubject;
        private Button buttonDeleteSubject;
        private Label labelStudentGroupTitle;
        private ComboBox comboStudentsForGroup;
        private Label labelGroupName;
        private Label labelStudentForGroup;
        private ComboBox comboGroupsForStudent;
        private Label labelGroupForStudent;
        private Button buttonAssignStudentToGroup;
        private Label label3;
        private Label label4;
    }
}
