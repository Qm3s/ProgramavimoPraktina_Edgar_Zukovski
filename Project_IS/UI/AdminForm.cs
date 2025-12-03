using Project_IS.Models;
using Project_IS.Services;
using System;
using System.Windows.Forms;

namespace Project_IS.UI
{
    public partial class AdminForm : Form
    {
        private readonly Admin _admin;
        private readonly AdminService _adminService = new AdminService();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            var users = _adminService.GetUsers();
            DataGridUsers.DataSource = users;

            DataGridUsers.ClearSelection();
        }

        public AdminForm(Admin admin) : this()
        {
            _admin = admin;
            LoadUsers();
            LoadGroups();

        }

        // ------------------- ADD USER -------------------
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First name and Last name are required.");
                return;
            }

            string username = string.IsNullOrWhiteSpace(txtUsername.Text)
                ? txtFirstName.Text.ToLower()
                : txtUsername.Text;

            string password = string.IsNullOrWhiteSpace(txtPassword.Text)
                ? txtLastName.Text.ToLower()
                : txtPassword.Text;

            var user = new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = username,
                Password = password,
                Role = comboRole.Text
            };

            _adminService.AddUser(user);
            MessageBox.Show("User added.");
            LoadUsers();
        }

        // ------------------- UPDATE USER -------------------
        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            if (DataGridUsers.CurrentRow == null)
            {
                MessageBox.Show("Select user in the table first.");
                return;
            }

            int userId = Convert.ToInt32(DataGridUsers.CurrentRow.Cells["UserId"].Value);

            var user = new User
            {
                UserId = userId,
                FirstName = FirstNameEdit.Text,
                LastName = txtEditLastName.Text,
                Username = txtEditUsername.Text,
                Password = txtEditPassword.Text,
                Role = comboEditRole.Text
            };

            _adminService.UpdateUser(user);

            MessageBox.Show("User updated.");
            LoadUsers();
        }

        // ------------------- DELETE USER -------------------
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (DataGridUsers.CurrentRow == null)
            {
                MessageBox.Show("Select user in the table first.");
                return;
            }

            int userId = Convert.ToInt32(DataGridUsers.CurrentRow.Cells["UserId"].Value);

            if (MessageBox.Show("Delete user?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _adminService.DeleteUser(userId);

            MessageBox.Show("User deleted.");
            LoadUsers();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }

        // ------------------- FILL EDIT FIELDS -------------------
        private void DataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = DataGridUsers.Rows[e.RowIndex];

            FirstNameEdit.Text = row.Cells["FirstName"].Value?.ToString();
            txtEditLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtEditUsername.Text = row.Cells["Username"].Value?.ToString();
            txtEditPassword.Text = row.Cells["Password"].Value?.ToString();
            comboEditRole.Text = row.Cells["Role"].Value?.ToString();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadGroups()
        {
            var groups = _adminService.GetGroups();
            DataGridGroups.DataSource = groups;

            DataGridGroups.ClearSelection();
        }
        private void DataGridGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = DataGridGroups.Rows[e.RowIndex];

            txtEditGroupName.Text = row.Cells["GroupName"].Value?.ToString();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
            {
                MessageBox.Show("Group name required!");
                return;
            }

            var g = new Group
            {
                GroupName = txtGroupName.Text
            };

            _adminService.AddGroup(g);

            MessageBox.Show("Group created!");
            LoadGroups();


        }

        private void buttonUpdateGroup_Click(object sender, EventArgs e)
        {
            if (DataGridGroups.CurrentRow == null)
            {
                MessageBox.Show("Select group first!");
                return;
            }

            int groupId = Convert.ToInt32(DataGridGroups.CurrentRow.Cells["GroupId"].Value);

            var g = new Group
            {
                GroupId = groupId,
                GroupName = txtEditGroupName.Text
            };

            _adminService.UpdateGroup(g);

            MessageBox.Show("Group updated!");
            LoadGroups();
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            if (DataGridGroups.CurrentRow == null)
            {
                MessageBox.Show("Select group first!");
                return;
            }

            int groupId = Convert.ToInt32(DataGridGroups.CurrentRow.Cells["GroupId"].Value);

            if (MessageBox.Show("Delete this group?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _adminService.DeleteGroup(groupId);

            MessageBox.Show("Group deleted!");
            LoadGroups();
        }

    }


}

