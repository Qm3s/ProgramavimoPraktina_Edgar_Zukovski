namespace Project_IS.UI
{
    partial class TeacherForm
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
            labelTeacherName = new Label();
            labelSubject = new Label();
            comboSubjects = new ComboBox();
            labelGroup = new Label();
            comboGroups = new ComboBox();
            labelStudent = new Label();
            comboStudents = new ComboBox();
            labelGrade = new Label();
            numericGrade = new NumericUpDown();
            buttonAddGrade = new Button();
            labelGradesList = new Label();
            dataGridViewGrades = new DataGridView();
            buttonLogout = new Button();

            ((System.ComponentModel.ISupportInitialize)numericGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            SuspendLayout();

            // -----------------------------------------------------
            // Teacher Name Label
            // -----------------------------------------------------
            labelTeacherName.AutoSize = true;
            labelTeacherName.Font = new Font("Segoe UI", 14F);
            labelTeacherName.Location = new Point(300, 10);
            labelTeacherName.Name = "labelTeacherName";
            labelTeacherName.Size = new Size(113, 25);
            labelTeacherName.TabIndex = 0;
            labelTeacherName.Text = "Teacher: ???";

            // -----------------------------------------------------
            // Subject Label
            // -----------------------------------------------------
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(40, 70);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(49, 15);
            labelSubject.Text = "Subject:";

            // -----------------------------------------------------
            // Subjects ComboBox
            // -----------------------------------------------------
            comboSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSubjects.Location = new Point(100, 67);
            comboSubjects.Name = "comboSubjects";
            comboSubjects.Size = new Size(239, 23);
            comboSubjects.SelectedIndexChanged += comboSubjects_SelectedIndexChanged;

            // -----------------------------------------------------
            // Group Label
            // -----------------------------------------------------
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(40, 100);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(43, 15);
            labelGroup.Text = "Group:";

            // -----------------------------------------------------
            // Groups ComboBox
            // -----------------------------------------------------
            comboGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGroups.Location = new Point(100, 97);
            comboGroups.Name = "comboGroups";
            comboGroups.Size = new Size(239, 23);
            comboGroups.SelectedIndexChanged += comboGroups_SelectedIndexChanged;

            // -----------------------------------------------------
            // Student Label
            // -----------------------------------------------------
            labelStudent.AutoSize = true;
            labelStudent.Location = new Point(40, 130);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(51, 15);
            labelStudent.Text = "Student:";

            // -----------------------------------------------------
            // Students ComboBox
            // -----------------------------------------------------
            comboStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStudents.Location = new Point(100, 127);
            comboStudents.Name = "comboStudents";
            comboStudents.Size = new Size(239, 23);
            comboStudents.SelectedIndexChanged += comboStudents_SelectedIndexChanged;

            // -----------------------------------------------------
            // Grade Label
            // -----------------------------------------------------
            labelGrade.AutoSize = true;
            labelGrade.Location = new Point(40, 170);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(41, 15);
            labelGrade.Text = "Grade:";

            // -----------------------------------------------------
            // Numeric Grade
            // -----------------------------------------------------
            numericGrade.Location = new Point(100, 167);
            numericGrade.Maximum = 10;
            numericGrade.Minimum = 1;
            numericGrade.Value = 1;
            numericGrade.Name = "numericGrade";
            numericGrade.Size = new Size(120, 23);

            // -----------------------------------------------------
            // Add Grade Button
            // -----------------------------------------------------
            buttonAddGrade.Location = new Point(230, 167);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new Size(75, 23);
            buttonAddGrade.Text = "Add Grade";
            buttonAddGrade.Click += buttonAddGrade_Click;

            // -----------------------------------------------------
            // Grades Label
            // -----------------------------------------------------
            labelGradesList.AutoSize = true;
            labelGradesList.Location = new Point(40, 240);
            labelGradesList.Name = "labelGradesList";
            labelGradesList.Size = new Size(46, 15);
            labelGradesList.Text = "Grades:";

            // -----------------------------------------------------
            // Grades DataGridView
            // -----------------------------------------------------
            dataGridViewGrades.Location = new Point(100, 240);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.ReadOnly = true;
            dataGridViewGrades.Size = new Size(240, 160);
            dataGridViewGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.AllowUserToDeleteRows = false;

            // -----------------------------------------------------
            // Logout Button
            // -----------------------------------------------------
            buttonLogout.Location = new Point(700, 20);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.Text = "Logout";
            buttonLogout.Click += buttonLogout_Click;

            // -----------------------------------------------------
            // TeacherForm
            // -----------------------------------------------------
            ClientSize = new Size(800, 450);
            Controls.Add(labelTeacherName);
            Controls.Add(labelSubject);
            Controls.Add(comboSubjects);
            Controls.Add(labelGroup);
            Controls.Add(comboGroups);
            Controls.Add(labelStudent);
            Controls.Add(comboStudents);
            Controls.Add(labelGrade);
            Controls.Add(numericGrade);
            Controls.Add(buttonAddGrade);
            Controls.Add(labelGradesList);
            Controls.Add(dataGridViewGrades);
            Controls.Add(buttonLogout);
            Text = "Teacher Panel";

            ((System.ComponentModel.ISupportInitialize)numericGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTeacherName;
        private Label labelSubject;
        private ComboBox comboSubjects;
        private Label labelGroup;
        private ComboBox comboGroups;
        private Label labelStudent;
        private ComboBox comboStudents;
        private Label labelGrade;
        private NumericUpDown numericGrade;
        private Button buttonAddGrade;
        private Label labelGradesList;
        private DataGridView dataGridViewGrades;
        private Button buttonLogout;
    }
}
