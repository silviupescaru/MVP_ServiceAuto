using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ServiceAutoMVP.Model.Repository
{

    public class CarRepository
    {
        private Repository repository;

        public CarRepository()
        {
            this.repository = new Repository();
        }

        public bool AddCar(Car car)
        {
            string commandSQL = "insert into Car values('";
            commandSQL += car.Owner + "','" + car.Brand;
            commandSQL += "','" + car.Color + "','" + car.Fuel;
            commandSQL += "')";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool DeleteCar(uint id)
        {
            string commandSQL = "delete from Car where carID = '" + id + "'";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool UpdateCar(Car car)
        {
            string commandSQL = "update [Car] set [owner] = '";
            commandSQL += car.Owner + "', [brand] = '" + car.Brand;
            commandSQL += "', [color] = '" + car.Color;
            commandSQL += "', [fuel] = '" + car.Fuel;
            commandSQL += "' where [carID] = '" + car.CarID + "'";
            return this.repository.CommandSQL(commandSQL);
        }

        public DataTable CarTable()
        {
            string selectSQL = "Select * from Car order by carID";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            return carTable;
        }

        public List<Car> CarList()
        {
            DataTable carTable = this.CarTable();
            if (carTable == null)
                return null;
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        //public List<Car> CarList_Fuel(string searchedFuel)
        //{
        //    string selectSQL = "Select * from Car where fuel ='";
        //    selectSQL += searchedFuel + "' order by owner";
        //    DataTable carTable = this.repository.GetTable(selectSQL);
        //    if (carTable == null || carTable.Rows.Count == 0)
        //        return null;
        //    List<Car> list = new List<Car>();
        //    foreach (DataRow dr in carTable.Rows)
        //    {
        //        Car car = this.convertToCar(dr);
        //        list.Add(car);
        //    }
        //    return list;
        //}

        public List<Car> CarList_BrandFuel(string brand, string fuel)
        {
            string selectSQL = "Select * from [Car] where [fuel] ='";
            selectSQL += fuel + "' AND [brand] ='";
            selectSQL += brand + "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if(carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach(DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Owner(string owner)
        {
            string selectSQL = "Select * from [Car] where [owner] ='";
            selectSQL += owner;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Brand(string brand)
        {
            string selectSQL = "Select * from [Car] where [brand] ='";
            selectSQL += brand;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Color(string color)
        {
            string selectSQL = "Select * from [Car] where [color] ='";
            selectSQL += color;
            selectSQL += "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public List<Car> CarList_Fuel(string fuel)
        {
            string selectSQL = "Select * from [Car] where [fuel] ='";
            selectSQL += fuel + "' order by carID";

            Debug.Print(selectSQL);

            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
            {
                return null;
            }
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        public Car SearchCarByID(string id)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                string searchSQL = "Select * from Car where carID = " + ID;
                DataTable carTable = this.repository.GetTable(searchSQL);
                if (carTable == null || carTable.Rows.Count == 0)
                    return null;
                DataRow dr = carTable.Rows[0];
                return this.convertToCar(dr);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Car> SearchCarByOwner(string owner)
        {
            string selectSQL = "Select * from Car where owner = '" + owner + "'";
            DataTable carTable = this.repository.GetTable(selectSQL);
            if (carTable == null || carTable.Rows.Count == 0)
                return null;
            List<Car> list = new List<Car>();
            foreach (DataRow dr in carTable.Rows)
            {
                Car car = this.convertToCar(dr);
                list.Add(car);
            }
            return list;
        }

        private Car convertToCar(DataRow dataRow)
        {
            int id = (int)dataRow["carID"];
            return new Car((uint)id, (string)dataRow["owner"], (string)dataRow["brand"], (string)dataRow["color"], (string)dataRow["fuel"]);
        }

    }
}