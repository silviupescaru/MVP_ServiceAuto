using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoMVP.View
{
    public interface IEmployeeGUI : IGUI
    {

        void SetCarID(uint carID);

        uint GetCarID();

        void SetOwner(string owner);

        string GetOwner();

        void SetBrand(string brand);

        string GetBrand();

        void SetColor(string color);

        string GetColor();

        void SetFuel(string fuel);

        string GetFuel();

        string GetUserFromLogin();

        void SetLoggedUser(string loggedUser);

        string GetLoggedUser();

        void ResetSelectedCriterion();

        string GetSelectedCriterion();

        void ResetSelectedCriterionFilterBy();

        string GetSelectedCriterionFilterBy();

        int GetSelectedCar();

        string GetSelectedCarID();

        void AddRowDgvCarTable(DataGridViewRow row);

        DataGridViewRow GetFirstSelectedRow();

        int GetSelectedRowsNumber();

        void ResetDgvCarTable();

        string GetSearchedInformation();

        DataGridViewRowCollection GetDgvCarRows();

        void SetVisibility(bool visible);
    }
}
