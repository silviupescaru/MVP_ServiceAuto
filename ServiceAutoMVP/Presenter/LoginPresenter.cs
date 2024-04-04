using ServiceAutoMVP.Model.Repository;
using ServiceAutoMVP.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAutoMVP.Presenter
{
    public class LoginPresenter
    {
        private ILoginGUI iloginGUI;
        private UserRepository userRepository;

        public LoginPresenter(ILoginGUI iloginGUI)
        {
            this.iloginGUI = iloginGUI;
            this.userRepository = new UserRepository();
        }


        // Event from View===================================================================
        public void Login()
        {
            try {
                string username = this.iloginGUI.GetUsername();
                string password = this.iloginGUI.GetPassword();

                if(username.Length != 0 && password.Length != 0 )
                {
                    bool successfulLogin = userRepository.LoginUser( username, password );
                    if (successfulLogin)
                    {
                        string role = userRepository.GetRole(username, password);
                        if (role.Equals("Employee"))
                        {
                            showEmployeeGUI();
                        }
                        else if (role.Equals("Manager"))
                        {
                            showManagerGUI();
                        }
                        else if (role.Equals("Administrator"))
                        {
                            showAdministratorGUI();
                        }
                    }
                    else this.iloginGUI.SetMessage("Error", "Login failed");
                }
                else
                {
                    this.iloginGUI.SetMessage("Error", "Invalid username or password");
                }


                
            } catch 
            {
                this.iloginGUI.SetMessage("Error", "Login failed");
            }
        }
        // Presenter Specific================================================================
        
        private void showEmployeeGUI()
        {
            EmployeeGUI employeeGUI = new EmployeeGUI(this.iloginGUI.GetUsername());
            employeeGUI.Show();
            this.iloginGUI.HideForm();
        }

        private void showManagerGUI()
        {
            ManagerGUI managerGUI = new ManagerGUI(this.iloginGUI.GetUsername());
            managerGUI.Show();
            this.iloginGUI.HideForm();
        }

        private void showAdministratorGUI()
        {
            AdministratorGUI administratorGUI = new AdministratorGUI(this.iloginGUI.GetUsername());
            Debug.Print(this.iloginGUI.GetUsername());
            administratorGUI.Show();
            this.iloginGUI.HideForm();
        }

    }
}
