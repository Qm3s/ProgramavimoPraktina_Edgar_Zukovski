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

            MessageBox.Show($"TeacherId = {_teacher.TeacherId}, UserId = {_teacher.UserId}");

            _teacherService = new TeacherService();
            labelTeacherName.Text = $"Teacher: {_teacher.FirstName} {_teacher.LastName}";
            LoadSubjects();
        }


        // ----------------------
        // SUBJECTS 
        // ----------------------
        private void LoadSubjects()
        {
            comboSubjects.Items.Clear();

            var subjects = _teacherService.GetSubjectsForTeacher(_teacher.TeacherId);

            foreach (var subject in subjects)
                comboSubjects.Items.Add(subject);

            if (comboSubjects.Items.Count > 0)
                comboSubjects.SelectedIndex = 0;
        }

        private void comboSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGroups();
        }

        // ----------------------
        // GROUPS
        // ----------------------
        private void LoadGroups()
        {
            comboGroups.Items.Clear();

            var subject = comboSubjects.SelectedItem as Subject;
            if (subject == null)
                return;

            var groups = _teacherService.GetGroupsForSubject(subject.Id);

            foreach (var group in groups)
                comboGroups.Items.Add(group);

            if (comboGroups.Items.Count > 0)
                comboGroups.SelectedIndex = 0;
        }

        private void comboGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ----------------------
        // STUDENTS
        // ----------------------
        private void LoadStudents()
        {
            comboStudents.Items.Clear();

            var group = comboGroups.SelectedItem as Group;
            if (group == null)
                return;

            var students = _teacherService.GetStudentsInGroup(group.GroupId);

            foreach (var student in students)
                comboStudents.Items.Add(student);

            if (comboStudents.Items.Count > 0)
                comboStudents.SelectedIndex = 0;

            LoadGrades();
        }

        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrades();
        }

        // ----------------------
        // GRADES TABLE
        // ----------------------
        private void LoadGrades()
        {
            var subject = comboSubjects.SelectedItem as Subject;
            var student = comboStudents.SelectedItem as Student;

            if (subject == null || student == null)
                return;

            var grades = _teacherService.GetGrades(student.StudentId, subject.Id);

            dataGridViewGrades.DataSource = grades
                .Select(g => new
                {
                    Grade = g.Value
                })
                .ToList();
        }

        // ----------------------
        // ADD GRADE
        // ----------------------
        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            var subject = comboSubjects.SelectedItem as Subject;
            var student = comboStudents.SelectedItem as Student;

            if (subject == null || student == null)
            {
                MessageBox.Show("Please select subject, group and student.");
                return;
            }

            int value = (int)numericGrade.Value;
            _teacherService.AddGrade(student.StudentId, subject.Id, value);

            MessageBox.Show("Grade added successfully!");

            LoadGrades();
        }

        // ----------------------
        // LOGOUT
        // ----------------------
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
