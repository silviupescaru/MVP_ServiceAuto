namespace ServiceAutoMVP.Model
{

    public class Car
    {
        protected uint carID;
        protected string owner;
        protected string brand;
        protected string color;
        protected string fuel;

        public Car()
        {
            this.carID = 1;
            this.owner = "mike";
            this.brand = "Nissan Qashqai";
            this.color = "Gray";
            this.fuel = "Diesel";
        }

        public Car(uint carID, string owner, string brand, string color, string fuel)
        {
            this.carID = carID;
            this.owner = owner;
            this.brand = brand;
            this.color = color;
            this.fuel = fuel;
        }


        public Car(Car car)
        {
            this.carID = car.carID;
            this.owner = car.owner;
            this.brand = car.brand;
            this.color = car.color;
            this.fuel = car.fuel;
        }

        public uint CarID
        {
            get { return this.carID; }
            set { this.carID = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public override string ToString()
        {
            string s = "Owner: " + this.owner;
            s += "\nBrand: " + this.brand;
            s += "\nColor: " + this.color;
            s += "\nFuel: " + this.fuel;
            return s;
        }
    }
}