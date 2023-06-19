namespace cc1 
{
    public class Vehicule : Element
    {

        public string brand;
        public double mileage;
        public double fuel;
        public double consumption;

        public Vehicule(string brand, double mileage, double fuel, double consumption)
        {
            this.brand = brand;
            this.mileage = mileage;
            this.fuel = fuel;
            this.consumption = consumption;
        }

        public string Name
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public double Consumption
        {
            get { return consumption; }
            set { consumption = value; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}