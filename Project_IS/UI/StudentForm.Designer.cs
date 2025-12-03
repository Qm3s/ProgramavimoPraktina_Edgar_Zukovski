namespace Project_IS.UI
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
            StudentName = new Label();
            dataGridView = new DataGridView();
            Subject = new DataGridViewTextBoxColumn();
            colGrades = new DataGridViewTextBoxColumn();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StudentName.Location = new Point(27, 26);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(131, 25);
            StudentName.TabIndex = 0;
            StudentName.Text = "Student Name";
            StudentName.Click += StudentName_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Subject, colGrades });
            dataGridView.Location = new Point(27, 76);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(262, 150);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.Name = "Subject";
            // 
            // colGrades
            // 
            colGrades.HeaderText = "Grades";
            colGrades.Name = "colGrades";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(674, 30);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogout);
            Controls.Add(dataGridView);
            Controls.Add(StudentName);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentName;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn colGrades;
        private Button buttonLogout;
    }
}