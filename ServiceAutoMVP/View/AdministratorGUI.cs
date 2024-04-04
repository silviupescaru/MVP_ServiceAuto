using ServiceAutoMVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoMVP.View
{
    public partial class AdministratorGUI : Form, IAdministratorGUI
    {

        private AdministratorPresenter administratorPresenter;
        private string loggedUserFromLogin;

        public AdministratorGUI(string loggedUserFromLogin)
        {
            InitializeComponent();
            this.administratorPresenter = new AdministratorPresenter(this);
            this.loggedUserFromLogin = loggedUserFromLogin;
            this.SetLoggedUser("Logged in as " + loggedUserFromLogin);
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetUserID(uint id)
        {
            this.numericUpDownUserID.Value = id;
        }

        public uint GetUserID()
        {
            return (uint)this.numericUpDownUserID.Value;
        }

        public void SetUsername(string username)
        {
            this.textBoxUsername.Text = username;
        }

        public string GetUsername()
        {
            return this.textBoxUsername.Text;
        }

        public void SetPassword(string password) 
        { 
            this.textBoxPassword.Text = password;
        }

        public string GetPassword()
        {
            return this.textBoxPassword.Text;
        }

        public void SetRole(string role)
        {
            this.textBoxRole.Text = role;
        }

        public string GetRole()
        {
            return this.textBoxRole.Text;
        }

        public string GetUserFromLogin()
        {
            return this.loggedUserFromLogin;
        }

        public void SetLoggedUser(string loggedUser)
        {
            this.labelLoggedUser.Text = loggedUser;
        }

        public string GetLoggedUser()
        {
            return this.labelLoggedUser.Text;
        }

        public int GetSelectedUser()
        {
            return this.dataGridViewUserTable.SelectedRows.Count;
        }

        public string GetSelectedUserID()
        {
            return (string)this.dataGridViewUserTable.SelectedRows[0].Cells[0].Value;
        }

        public void AddRowDgvUserTable(DataGridViewRow row)
        {
            this.dataGridViewUserTable.Rows.Add(row);
        }

        public DataGridViewRow GetFirstSelectedRow()
        {
            return this.dataGridViewUserTable.SelectedRows[0];
        }

        public int GetSelectedRowsNumber()
        {
            return this.dataGridViewUserTable.SelectedRows.Count;
        }

        public void ResetDgvCarTable()
        {
            this.dataGridViewUserTable.Rows.Clear();
        }

        public DataGridViewRowCollection GetDgvUserRows()
        {
            return this.dataGridViewUserTable.Rows;
        }

        public string GetSearchedInformation()
        {
            return this.textBoxSearch.Text;
        }

        public void ResetDgvUserTable()
        {
            this.dataGridViewUserTable.Rows.Clear();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.administratorPresenter.AddUser();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.administratorPresenter.UpdateUser();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.administratorPresenter.DeleteUser();
        }

        private void dgvUserTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            this.administratorPresenter.SetUserControls();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.administratorPresenter.SearchUserByUsernameOrRole();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            this.administratorPresenter.LoadUserTable();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.administratorPresenter.Logout();
        }
    }
}
