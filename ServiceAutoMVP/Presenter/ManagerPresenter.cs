using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAutoMVP.Model.Repository;
using ServiceAutoMVP.View;
using ServiceAutoMVP.Model;
using System.Diagnostics;
using System.Windows.Forms;

namespace ServiceAutoMVP.Presenter
{
    public class ManagerPresenter
    {

        private IManagerGUI iManagerGUI;
        private CarRepository carRepository;

        public ManagerPresenter(IManagerGUI iManagerGUI)
        {
            this.iManagerGUI = iManagerGUI;
            this.carRepository = new CarRepository();
            this.setLoggedUser();
            this.LoadCarTable();
        }

        private void setLoggedUser()
        {
            try
            {
                string logged = "";
                logged = "Logged in as " + this.iManagerGUI.GetUserFromLogin();
                this.iManagerGUI.SetLoggedUser(logged);
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Exception", exception.ToString());
            }
        }

        public void LoadCarTable()
        {
            try
            {
                this.setLoggedUser();
                this.iManagerGUI.ResetDgvCarTable();
                this.iManagerGUI.SetVisibility(true);
                List<Car> list = carRepository.CarList();

                if (list != null && list.Count > 0)
                {
                    this.setRowCarList(list);
                }
                else
                {
                    this.iManagerGUI.SetMessage("Empty", "There is no car in your table!");
                }

            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Cars load - exception", exception.ToString());
            }
        }

        public void Logout()
        {
            try
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.iManagerGUI.HideForm();
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Logout failed", exception.ToString());
            }
        }

        public void CarTable()
        {
            try
            {
                this.iManagerGUI.ResetDgvCarTable();
                string selectedOption = this.iManagerGUI.GetSelectedCriterion();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "ALL")
                    {
                        this.iManagerGUI.SetVisibility(true);
                        this.allCars();
                    }
                    else if (selectedOption.ToUpper() == "FILTER BY BRAND AND FUEL")
                    {
                        this.iManagerGUI.SetVisibility(true);
                        this.CarFilterByBrandFuel();
                    }

                }
                else
                    this.iManagerGUI.SetVisibility(true);
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Cars - Exception", exception.ToString());
            }
        }

        public void CarTableFilterBy()
        {
            try
            {
                this.iManagerGUI.ResetDgvCarTable();
                string selectedOption = this.iManagerGUI.GetSelectedCriterionFilterBy();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        this.iManagerGUI.SetVisibility(true);
                        string owner = this.iManagerGUI.GetOwner();
                        this.CarFilterBy(selectedOption, owner);
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        this.iManagerGUI.SetVisibility(true);
                        string brand = this.iManagerGUI.GetBrand();
                        this.CarFilterBy(selectedOption, brand);
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        this.iManagerGUI.SetVisibility(true);
                        string color = this.iManagerGUI.GetColor();
                        this.CarFilterBy(selectedOption, color);
                    }
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        this.iManagerGUI.SetVisibility(true);
                        string fuel = this.iManagerGUI.GetFuel();
                        this.CarFilterBy(selectedOption, fuel);
                    }

                }
                else
                    this.iManagerGUI.SetVisibility(true);
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Cars - Exception", exception.ToString());
            }
        }

        public void CarFilterBy(string criterion, string value)
        {
            try
            {
                this.iManagerGUI.ResetDgvCarTable();


                if (criterion.Length > 0)
                {
                    if (criterion.ToUpper() == "OWNER")
                    {
                        List<Car> list = this.carRepository.CarList_Owner(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The cars from desired owner is empty!");
                    }
                    else if (criterion.ToUpper() == "BRAND")
                    {
                        List<Car> list = this.carRepository.CarList_Brand(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The cars from desired brand is empty!");
                    }
                    else if (criterion.ToUpper() == "COLOR")
                    {
                        List<Car> list = this.carRepository.CarList_Color(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The cars from desired color is empty!");
                    }
                    else if (criterion.ToUpper() == "FUEL")
                    {
                        Debug.Print("You chose fuel filter");
                        List<Car> list = this.carRepository.CarList_Fuel(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The cars from desired fuel is empty!");
                    }
                }
                else this.iManagerGUI.SetMessage("Empty", "The cars from desired filter is empty!");
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Car List - filter by - exception", exception.ToString());
            }
        }

        public void CarFilterByBrandFuel()
        {
            try
            {
                this.iManagerGUI.ResetDgvCarTable();
                string brand = this.iManagerGUI.GetBrand();
                string fuel = this.iManagerGUI.GetFuel();


                if (fuel.Length > 0)
                {
                    List<Car> list = this.carRepository.CarList_BrandFuel(brand, fuel);
                    if (list != null)
                    {
                        this.setRowCarList(list);
                    }
                }
                else this.iManagerGUI.SetMessage("Empty", "The cars from desired brand and fuel is empty!");
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Car List - filter by - exception", exception.ToString());
            }
        }

        public void SearchCarByIDOrName()
        {
            try
            {
                this.iManagerGUI.ResetDgvCarTable();
                this.iManagerGUI.SetVisibility(true);
                this.iManagerGUI.ResetSelectedCriterion();
                string searchedInfo = this.iManagerGUI.GetSearchedInformation();
                if (searchedInfo != null && searchedInfo.Length > 0)
                {
                    List<Car> list = new List<Car>();
                    Car car = this.carRepository.SearchCarByID(searchedInfo);
                    if (car != null)
                    {
                        list.Add(car);
                    }
                    else list = this.carRepository.SearchCarByOwner(searchedInfo);

                    if (list != null && list.Count > 0)
                    {
                        this.setRowCarList(list);
                    }
                    else
                    {
                        this.iManagerGUI.SetMessage("Empty", "There is no car according to searched information!");
                    }
                }
                else
                {
                    this.iManagerGUI.SetMessage("Empty", "The searched information is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Cars search - exception", exception.ToString());
            }
        }

        public void SetCarControls()
        {
            try
            {
                if (this.iManagerGUI.GetSelectedRowsNumber() > 0)
                {
                    DataGridViewRow drvr = this.iManagerGUI.GetFirstSelectedRow();
                    uint id = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.iManagerGUI.SetCarID(id);
                    string owner = drvr.Cells[1].Value.ToString();
                    this.iManagerGUI.SetOwner(owner);
                    string brand = drvr.Cells[2].Value.ToString();
                    this.iManagerGUI.SetBrand(brand);
                    string color = drvr.Cells[3].Value.ToString();
                    this.iManagerGUI.SetColor(color);
                    String fuel = drvr.Cells[4].Value.ToString();
                    this.iManagerGUI.SetFuel(fuel);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error at row selection!");
            }
        }

        private void allCars()
        {
            try
            {
                List<Car> list = this.carRepository.CarList();
                if (list != null)
                {
                    this.setRowCarList(list);
                }
                else
                {
                    this.iManagerGUI.SetMessage("Empty", "The list of cars is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Car List - exception", exception.ToString());
            }
        }

        private void setRowCarList(List<Car> list)
        {
            foreach (Car car in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                this.iManagerGUI.AddRowDgvCarTable(row);
            }
        }

        private void resetDoctorControls()
        {
            this.iManagerGUI.SetCarID(1);
            this.iManagerGUI.SetOwner("");
            this.iManagerGUI.SetBrand("");
            this.iManagerGUI.SetColor("");
            this.iManagerGUI.SetFuel("");
            this.iManagerGUI.SetVisibility(true);
        }

        private Car validInformation()
        {
            uint id = this.iManagerGUI.GetCarID();
            Debug.Print("Car ID: " + id);
            if (id == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Car ID must be non-zero natural number!");
                return null;
            }
            string owner = this.iManagerGUI.GetOwner();
            Debug.Print("Car Owner: " + owner);
            if (owner == null || owner.Length == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Car Owner is empty!");
                return null;
            }
            string brand = this.iManagerGUI.GetBrand();
            Debug.Print("Car Brand: " + brand);
            if (brand == null || brand.Length == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Car Brand is empty!");
                return null;
            }
            string color = this.iManagerGUI.GetColor();
            Debug.Print("Car Color: " + color);
            if (color == null || color.Length == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Car Color is empty");
                return null;
            }
            string fuel = this.iManagerGUI.GetFuel();
            Debug.Print("Car Fuel: " + fuel);
            if (fuel == null || fuel.Length == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Car Fuel is empty");
                return null;
            }
            return new Car(id, owner, brand, color, fuel);
        }
    }
}
