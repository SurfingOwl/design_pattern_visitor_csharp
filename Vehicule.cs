namespace cc1 
{
    public class Vehicule : Element
    {

        public double mileage;
        public double fuel;

        public Vehicule(double mileage, double fuel)
        {
            this.mileage = mileage;
            this.fuel = fuel;
        }

        public override void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}