using ServiceAutoMVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoMVP.View
{
    public partial class EmployeeGUI : Form, IEmployeeGUI
    {

        private EmployeePresenter employeePresenter;
        private string loggedUserFromLogin;

        public EmployeeGUI(string loggedUserFromLogin)
        {
            InitializeComponent();
            this.employeePresenter = new EmployeePresenter(this);
            this.SetLoggedUser("Logged in as " + loggedUserFromLogin);
        }
        // IEmployeeGUI===================================================================

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetCarID(uint carID)
        {
            this.numericUpDownCarID.Value = carID;
        }
        
        public uint GetCarID()
        {
            return (uint)this.numericUpDownCarID.Value;
        }

        public void SetOwner(string owner)
        {
            this.textBoxOwner.Text = owner;
        }

        public string GetOwner()
        {
            return this.textBoxOwner.Text;
        }

        public void SetBrand(string brand)
        {
            this.textBoxBrand.Text = brand;
        }

        public string GetBrand()
        {
            return this.textBoxBrand.Text;
        }

        public void SetColor(string color) { 
            this.textBoxColor.Text = color;
        }

        public string GetColor()
        {
            return this.textBoxColor.Text;
        }

        public void SetFuel(string fuel)
        {
            this.comboBoxFuel.Text = fuel;
        }

        public string GetFuel()
        {
            return this.comboBoxFuel.Text;
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

        public void ResetSelectedCriterion()
        {
            this.comboBoxSelectList.SelectedIndex = 0;
        }

        public string GetSelectedCriterion() 
        { 
            return this.comboBoxSelectList.SelectedItem.ToString();
        }

        public void ResetSelectedCriterionFilterBy()
        {
            this.comboBoxOrderBy.SelectedIndex = 0;
        }

        public string GetSelectedCriterionFilterBy()
        {
            return this.comboBoxOrderBy.SelectedItem.ToString();
        }


        public int GetSelectedCar()
        {
            return this.dataGridViewCarTable.SelectedRows.Count;
        }

        public string GetSelectedCarID()
        {
            return (string)this.dataGridViewCarTable.SelectedRows[0].Cells[0].Value;
        }

        public void AddRowDgvCarTable(DataGridViewRow row)
        {
            this.dataGridViewCarTable.Rows.Add(row);
        }

        public DataGridViewRow GetFirstSelectedRow()
        {
            return this.dataGridViewCarTable.SelectedRows[0];
        }

        public int GetSelectedRowsNumber()
        {
            return this.dataGridViewCarTable.SelectedRows.Count;
        }

        public void ResetDgvCarTable()
        {
            this.dataGridViewCarTable.Rows.Clear();
        }

        public DataGridViewRowCollection GetDgvCarRows()
        {
            return this.dataGridViewCarTable.Rows;
        }



        // Button event====================================================================

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.employeePresenter.AddCar();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.employeePresenter.UpdateCar();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.employeePresenter.DeleteCar();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.employeePresenter.Logout();
        }

        private void dgvCarTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            this.employeePresenter.SetCarControls();
        }

        

        // GUI Specific====================================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFontChanged(e);
            Environment.Exit(0);
        }

        public void SetVisibility(bool visible)
        {
            this.comboBoxSelectList.Visible = visible;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.employeePresenter.SearchCarByIDOrName();
        }

        public string GetSearchedInformation()
        {
            return this.textBoxSearch.Text;
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            this.employeePresenter.LoadCarTable();
        }

        private void comboBoxSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeePresenter.CarTable();
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeePresenter.CarTableFilterBy();
        }
    }

}
