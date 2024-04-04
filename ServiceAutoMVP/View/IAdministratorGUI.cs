using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoMVP.View
{
    public interface IAdministratorGUI : IGUI
    {
        void SetUserID(uint carID);

        uint GetUserID();

        void SetUsername(string username);

        string GetUsername();

        void SetPassword(string password);

        string GetPassword();

        void SetRole(string role);

        string GetRole();

        string GetUserFromLogin();

        void SetLoggedUser(string loggedUser);

        string GetLoggedUser();

        int GetSelectedUser();

        string GetSelectedUserID();

        void AddRowDgvUserTable(DataGridViewRow row);

        DataGridViewRow GetFirstSelectedRow();

        int GetSelectedRowsNumber();

        void ResetDgvUserTable();

        string GetSearchedInformation();

        DataGridViewRowCollection GetDgvUserRows();

        //void SetVisibility(bool visible);

    }
}
