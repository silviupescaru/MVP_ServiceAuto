using ServiceAutoMVP.Model;
using ServiceAutoMVP.Model.Repository;
using ServiceAutoMVP.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoMVP.Presenter
{
    public class AdministratorPresenter
    {
        private IAdministratorGUI iAdministratorGUI;
        private UserRepository userRepository;

        public AdministratorPresenter(IAdministratorGUI iAdministratorGUI)
        {
            this.iAdministratorGUI = iAdministratorGUI;
            this.userRepository = new UserRepository();
            this.setLoggedUser();
            this.LoadUserTable();
        }

        private void setLoggedUser()
        {
            try
            {
                string logged = "";
                logged = "Logged in as " + this.iAdministratorGUI.GetUserFromLogin();
                this.iAdministratorGUI.SetLoggedUser(logged);
            } catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Exception", exception.ToString());
            }
        }

        public void LoadUserTable()
        {
            try
            {

                this.resetUserControls();
                this.iAdministratorGUI.ResetDgvUserTable();
                List<User> list = userRepository.UserList();

                if (list != null && list.Count > 0)
                {
                    this.setRowUserList(list);

                }
                else
                {
                    this.iAdministratorGUI.SetMessage("Empty", "There is no user in your table!");
                }

            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Users load - exception", exception.ToString());
            }
        }

        public void Logout()
        {
            try
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.iAdministratorGUI.HideForm();
            } catch(Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Logout failed", exception.ToString());
            }
        }

        public void AddUser()
        {
            try
            {
                User user = this.validInformation();
                if (user != null)
                {
                    bool result = this.userRepository.AddUser(user);
                    if (result)
                    {
                        this.iAdministratorGUI.SetMessage("Success!", "Adding was completed successfully!");
                        this.resetUserControls();
                        this.iAdministratorGUI.ResetDgvUserTable();
                    }
                    else
                        this.iAdministratorGUI.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Add - Exception", exception.ToString());
            }
        }

        public void DeleteUser()
        {
            try
            {
                if (Convert.ToBoolean(this.iAdministratorGUI.GetSelectedUser()))
                {
                    uint selectedID = Convert.ToUInt32(this.iAdministratorGUI.GetSelectedUserID());
                    bool result = this.userRepository.DeleteUser(selectedID);
                    if (result)
                    {
                        this.resetUserControls();
                        this.iAdministratorGUI.ResetDgvUserTable();
                        this.iAdministratorGUI.SetMessage("Success!", "Deletion was completed successfully!");
                    }
                    else
                        this.iAdministratorGUI.SetMessage("Failure!", "Deletion was ended with failure!");
                }
                else
                    this.iAdministratorGUI.SetMessage("Failure!", "No user has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Delete - Exception", exception.ToString());
            }
        }

        public void UpdateUser()
        {
            try
            {
                if (Convert.ToBoolean(this.iAdministratorGUI.GetSelectedUser()))
                {
                    //uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedCarID());
                    User user = this.validInformation();
                    if (user != null)
                    {
                        bool result = this.userRepository.UpdateUser(user);
                        if (result)
                        {
                            this.iAdministratorGUI.SetMessage("Success!", "Updating was completed successfully!");
                            this.resetUserControls();
                            this.iAdministratorGUI.ResetDgvUserTable();
                        }
                        else
                            this.iAdministratorGUI.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
                else
                    this.iAdministratorGUI.SetMessage("Failure!", "No user has been selected to be updated!");
            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Update - Exception", exception.ToString());
            }
        }

        public void UserTable()
        {
            try
            {
                this.iAdministratorGUI.ResetDgvUserTable();
                this.allUsers();
            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Users - Exception", exception.ToString());
            }
        }

        public void SearchUserByUsernameOrRole()
        {
            try
            {
                this.iAdministratorGUI.ResetDgvUserTable();
                string searchedInfo = this.iAdministratorGUI.GetSearchedInformation();
                if (searchedInfo != null && searchedInfo.Length > 0)
                {

                    List<User> list = new List<User>();

                    list = this.userRepository.SearchUserByUsername(searchedInfo);

                    if (list == null)
                    {
                        list = this.userRepository.SearchUserByRole(searchedInfo);
                    }

                    if(list != null)
                    {
                        this.setRowUserList(list);
                    }
                    else
                    {
                        this.iAdministratorGUI.SetMessage("Empty", "The searched information is empty!");
                    }

                } 
            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("Users search - exception", exception.ToString());
            }
        }

        public void SetUserControls()
        {
            try
            {
                if (this.iAdministratorGUI.GetSelectedRowsNumber() > 0)
                {
                    DataGridViewRow drvr = this.iAdministratorGUI.GetFirstSelectedRow();
                    uint id = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.iAdministratorGUI.SetUserID(id);
                    string username = drvr.Cells[1].Value.ToString();
                    this.iAdministratorGUI.SetUsername(username);
                    string password = drvr.Cells[2].Value.ToString();
                    this.iAdministratorGUI.SetPassword(password);
                    string role = drvr.Cells[3].Value.ToString();
                    this.iAdministratorGUI.SetRole(role);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error at row selection!");
            }
        }

        private void allUsers()
        {
            try
            {
                List<User> list = this.userRepository.UserList();
                if (list != null)
                {
                    this.setRowUserList(list);
                }
                else
                {
                    this.iAdministratorGUI.SetMessage("Empty", "The list of users is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iAdministratorGUI.SetMessage("User List - exception", exception.ToString());
            }
        }

        private void setRowUserList(List<User> list)
        {
            foreach (User user in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.Username });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.Password });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.Role });
                this.iAdministratorGUI.AddRowDgvUserTable(row);
            }
        }

        private void resetUserControls()
        {
            this.iAdministratorGUI.SetUserID(1);
            this.iAdministratorGUI.SetUsername("");
            this.iAdministratorGUI.SetPassword("");
            this.iAdministratorGUI.SetRole("");
            this.setLoggedUser();
        }

        private User validInformation()
        {
            uint id = this.iAdministratorGUI.GetUserID();
            Debug.Print("User ID: " + id);
            if (id == 0)
            {
                this.iAdministratorGUI.SetMessage("Incomplete information!", "User ID must be non-zero natural number!");
                return null;
            }
            string username = this.iAdministratorGUI.GetUsername();
            Debug.Print("Username: " + username);
            if (username == null || username.Length == 0)
            {
                this.iAdministratorGUI.SetMessage("Incomplete information!", "Username is empty!");
                return null;
            }
            string password = this.iAdministratorGUI.GetPassword();
            Debug.Print("Password: " + password);
            if (password == null || password.Length == 0)
            {
                this.iAdministratorGUI.SetMessage("Incomplete information!", "Password is empty!");
                return null;
            }
            string role = this.iAdministratorGUI.GetRole();
            Debug.Print("Role: " + role);
            if (role == null || role.Length == 0)
            {
                this.iAdministratorGUI.SetMessage("Incomplete information!", "Role is empty");
                return null;
            }
            return new User(id, username, password, role);
        }
    }

}

