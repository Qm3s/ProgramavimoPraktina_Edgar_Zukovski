using Project_IS.Models;
using Project_IS.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Project_IS.UI
{
    public partial class TeacherForm : Form
    {
        private readonly Teacher _teacher;
        private readonly TeacherService _teacherService;

        public TeacherForm()
        {
            InitializeComponent();
        }

        public TeacherForm(Teacher teacher) : this()
        {
            _teacher = teacher;
            _teacherService = new TeacherService();

            labelTeacherName.Text = $"Teacher: {_teacher.FirstName} {_teacher.LastName}";

            LoadGroups();
            LoadSubjects();
        }

        
        private void LoadGroups()
        {
            var groups = _teacherService.GetAllGroups();

            comboGroups.DataSource = null;
            comboGroups.DisplayMember = "GroupName";
            comboGroups.ValueMember = "GroupId";
            comboGroups.DataSource = groups;

            comboGroups.SelectedIndex = -1;
        }


        private void comboGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGroups.SelectedValue is int groupId)
                LoadStudents(groupId);
        }

       
        private void LoadStudents(int groupId)
        {
            var students = _teacherService.GetStudentsByGroup(groupId);

            comboStudents.DataSource = null;                    
            comboStudents.DisplayMember = "LastName";           
            comboStudents.ValueMember = "StudentId";            
            comboStudents.DataSource = students;                
            comboStudents.SelectedIndex = -1;
            dataGridViewGrades.DataSource = null;
        }


        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrades();
        }

        
        private void LoadSubjects()
        {
            var subjects = _teacherService.GetAllSubjects();

            comboSubjects.DataSource = null;
            comboSubjects.DisplayMember = "SubjectName";
            comboSubjects.ValueMember = "Id";
            comboSubjects.DataSource = subjects;

            comboSubjects.SelectedIndex = -1;
        }


        private void comboSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void LoadGrades()
        {
            if (comboStudents.SelectedValue == null ||
                comboSubjects.SelectedValue == null)
            {
                dataGridViewGrades.DataSource = null;
                return;
            }

            int studentId = (int)comboStudents.SelectedValue;
            int subjectId = (int)comboSubjects.SelectedValue;

            var grades = _teacherService.GetGrades(studentId, subjectId);

            dataGridViewGrades.DataSource = grades
                .Select(g => new { Grade = g.Value })
                .ToList();
        }


        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            if (comboStudents.SelectedValue == null || comboSubjects.SelectedValue == null)
            {
                MessageBox.Show("Please select group, student and subject.");
                return;
            }

            int studentId = (int)comboStudents.SelectedValue;
            int subjectId = (int)comboSubjects.SelectedValue;
            int gradeValue = (int)numericGrade.Value;

            _teacherService.AddGrade(studentId, subjectId, gradeValue);

            MessageBox.Show("Grade added!");
            LoadGrades();
        }

        
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
