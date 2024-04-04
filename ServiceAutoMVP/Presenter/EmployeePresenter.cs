using ServiceAutoMVP.Model.Repository;
using ServiceAutoMVP.View;
using ServiceAutoMVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ServiceAutoMVP.Presenter
{
    public class EmployeePresenter
    {

        private IEmployeeGUI iEmployeeGUI;
        private CarRepository carRepository;

        public EmployeePresenter(IEmployeeGUI iEmployeeGUI) {
            this.iEmployeeGUI = iEmployeeGUI;
            this.carRepository = new CarRepository();
            this.setLoggedUser();
            this.LoadCarTable();
        }

        private void setLoggedUser()
        {
            try
            {
                string logged = "";
                logged = "Logged in as " + this.iEmployeeGUI.GetUserFromLogin();
                Debug.WriteLine(logged);
                this.iEmployeeGUI.SetLoggedUser(logged);
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Exception", exception.ToString());
            }
        }

        public void LoadCarTable()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvCarTable();
                this.iEmployeeGUI.SetVisibility(true);
                    List<Car> list = carRepository.CarList();

                    if (list != null && list.Count > 0)
                    {
                        this.setRowCarList(list);
                    }
                    else
                    {
                        this.iEmployeeGUI.SetMessage("Empty", "There is no car in your table!");
                    }

            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Cars load - exception", exception.ToString());
            }
        }

        public void Logout()
        {
            try
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.iEmployeeGUI.HideForm();
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Logout failed", exception.ToString());
            }
        }

        public void AddCar()
        {
            try
            {
                Car car = this.validInformation();
                if (car != null)
                {
                    bool result = this.carRepository.AddCar(car);
                    if (result)
                    {
                        this.iEmployeeGUI.SetMessage("Success!", "Adding was completed successfully!");
                        this.resetDoctorControls();
                        this.iEmployeeGUI.ResetDgvCarTable();
                        this.LoadCarTable();
                    }
                    else
                        this.iEmployeeGUI.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Add - Exception", exception.ToString());
            }
        }

        public void DeleteCar()
        {
            try
            {
                if (Convert.ToBoolean(this.iEmployeeGUI.GetSelectedCar()))
                {
                    uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedCarID());
                    bool result = this.carRepository.DeleteCar(selectedID);
                    if (result)
                    {
                        this.resetDoctorControls();
                        this.iEmployeeGUI.ResetDgvCarTable();
                        this.iEmployeeGUI.SetMessage("Success!", "Deletion was completed successfully!");
                        this.LoadCarTable();
                    }
                    else
                        this.iEmployeeGUI.SetMessage("Failure!", "Deletion was ended with failure!");
                }
                else
                    this.iEmployeeGUI.SetMessage("Failure!", "No car has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Delete - Exception", exception.ToString());
            }
        }

        public void UpdateCar()
        {
            try
            {
                if (Convert.ToBoolean(this.iEmployeeGUI.GetSelectedCar()))
                {
                    //uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedCarID());
                    Car car = this.validInformation();
                    if (car != null)
                    {
                        bool result = this.carRepository.UpdateCar(car);
                        if (result)
                        {
                            this.iEmployeeGUI.SetMessage("Success!", "Updating was completed successfully!");
                            this.resetDoctorControls();
                            this.iEmployeeGUI.ResetDgvCarTable();
                            this.LoadCarTable();
                        }
                        else
                            this.iEmployeeGUI.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
                else
                    this.iEmployeeGUI.SetMessage("Failure!", "No car has been selected to be updated!");
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Update - Exception", exception.ToString());
            }
        }

        public void CarTable()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvCarTable();
                string selectedOption = this.iEmployeeGUI.GetSelectedCriterion();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "ALL")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        this.allCars();
                    }
                    else if (selectedOption.ToUpper() == "FILTER BY BRAND AND FUEL")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        this.CarFilterByBrandFuel();
                    }
                   
                }
                else
                    this.iEmployeeGUI.SetVisibility(true);
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Cars - Exception", exception.ToString());
            }
        }

        public void CarTableFilterBy()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvCarTable();
                string selectedOption = this.iEmployeeGUI.GetSelectedCriterionFilterBy();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        string owner = this.iEmployeeGUI.GetOwner();
                        this.CarFilterBy(selectedOption, owner);
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        string brand = this.iEmployeeGUI.GetBrand();
                        this.CarFilterBy(selectedOption, brand);
                    } else if (selectedOption.ToUpper() == "COLOR")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        string color = this.iEmployeeGUI.GetColor();
                        this.CarFilterBy(selectedOption, color);
                    } else if (selectedOption.ToUpper() == "FUEL")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        string fuel = this.iEmployeeGUI.GetFuel();
                        this.CarFilterBy(selectedOption, fuel);
                    }

                }
                else
                    this.iEmployeeGUI.SetVisibility(true);
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Cars - Exception", exception.ToString());
            }
        }

        public void CarFilterBy(string criterion, string value)
        {
            try
            {
                this.iEmployeeGUI.ResetDgvCarTable();


                if (criterion.Length > 0)
                {
                    if (criterion.ToUpper() == "OWNER")
                    {
                        List<Car> list = this.carRepository.CarList_Owner(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        } else this.iEmployeeGUI.SetMessage("Empty", "The cars from desired owner is empty!");
                    } else if (criterion.ToUpper() == "BRAND")
                    {
                        List<Car> list = this.carRepository.CarList_Brand(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        } else this.iEmployeeGUI.SetMessage("Empty", "The cars from desired brand is empty!");
                    } else if (criterion.ToUpper() == "COLOR")
                    {
                        List<Car> list = this.carRepository.CarList_Color(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        } else this.iEmployeeGUI.SetMessage("Empty", "The cars from desired color is empty!");
                    } else if (criterion.ToUpper() == "FUEL")
                    {
                        Debug.Print("You chose fuel filter");
                        List<Car> list = this.carRepository.CarList_Fuel(value);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        } else this.iEmployeeGUI.SetMessage("Empty", "The cars from desired fuel is empty!");
                    }
                }
                else this.iEmployeeGUI.SetMessage("Empty", "The cars from desired filter is empty!");
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Car List - filter by - exception", exception.ToString());
            }
        }

        public void CarFilterByBrandFuel()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvCarTable();
                string brand = this.iEmployeeGUI.GetBrand();
                string fuel = this.iEmployeeGUI.GetFuel();


                    if (fuel.Length > 0)
                    {
                        List<Car> list = this.carRepository.CarList_BrandFuel(brand, fuel);
                        if (list != null)
                        {
                            this.setRowCarList(list);
                        }
                    }
                    else this.iEmployeeGUI.SetMessage("Empty", "The cars from desired brand and fuel is empty!");
            } catch(Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Car List - filter by - exception", exception.ToString());
            }
        }

        public void SearchCarByIDOrName()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvCarTable();
                this.iEmployeeGUI.SetVisibility(true);
                this.iEmployeeGUI.ResetSelectedCriterion();
                string searchedInfo = this.iEmployeeGUI.GetSearchedInformation();
                if(searchedInfo != null && searchedInfo.Length > 0)
                {
                    List<Car> list = new List<Car>();
                    Car car = this.carRepository.SearchCarByID(searchedInfo);
                    if(car != null)
                    {
                        list.Add(car);
                    } else list = this.carRepository.SearchCarByOwner(searchedInfo);

                    if(list != null && list.Count > 0)
                    {
                        this.setRowCarList(list);
                    } else
                    {
                        this.iEmployeeGUI.SetMessage("Empty", "There is no car according to searched information!");
                    }
                } else
                {
                    this.iEmployeeGUI.SetMessage("Empty", "The searched information is empty!");
                }
            } catch(Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Cars search - exception", exception.ToString());
            }
        }
    
        public void SetCarControls()
        {
            try
            {
                if (this.iEmployeeGUI.GetSelectedRowsNumber() > 0)
                {
                    DataGridViewRow drvr = this.iEmployeeGUI.GetFirstSelectedRow();
                    uint id = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.iEmployeeGUI.SetCarID(id);
                    string owner = drvr.Cells[1].Value.ToString();
                    this.iEmployeeGUI.SetOwner(owner);
                    string brand = drvr.Cells[2].Value.ToString();
                    this.iEmployeeGUI.SetBrand(brand);
                    string color = drvr.Cells[3].Value.ToString();
                    this.iEmployeeGUI.SetColor(color);
                    String fuel = drvr.Cells[4].Value.ToString();
                    this.iEmployeeGUI.SetFuel(fuel);
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
                if(list != null)
                {
                    this.setRowCarList(list);
                } else
                {
                    this.iEmployeeGUI.SetMessage("Empty", "The list of cars is empty!");
                }
            } catch(Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Car List - exception", exception.ToString());
            }
        }

        private void setRowCarList(List<Car> list)
        {
            foreach (Car car in list) {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                this.iEmployeeGUI.AddRowDgvCarTable(row);
            } 
        }

        private void resetDoctorControls()
        {
            this.iEmployeeGUI.SetCarID(1);
            this.iEmployeeGUI.SetOwner("");
            this.iEmployeeGUI.SetBrand("");
            this.iEmployeeGUI.SetColor("");
            this.iEmployeeGUI.SetFuel("");
            this.iEmployeeGUI.SetVisibility(true);
        }

        private Car validInformation()
        {
            uint id = this.iEmployeeGUI.GetCarID();
            Debug.Print("Car ID: " + id);
            if (id == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car ID must be non-zero natural number!");
                return null;
            }
            string owner = this.iEmployeeGUI.GetOwner();
            Debug.Print("Car Owner: " + owner);
            if (owner == null || owner.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Owner is empty!");
                return null;
            }
            string brand = this.iEmployeeGUI.GetBrand();
            Debug.Print("Car Brand: " +  brand);
            if (brand == null || brand.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Brand is empty!");
                return null;
            }
            string color = this.iEmployeeGUI.GetColor();
            Debug.Print("Car Color: " + color);
            if (color == null || color.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Color is empty");
                return null;
            }
            string fuel = this.iEmployeeGUI.GetFuel();
            Debug.Print("Car Fuel: " + fuel);
            if(fuel == null || fuel.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Fuel is empty");
                return null;
            }
            return new Car(id, owner, brand, color, fuel);
        }
    }
}
