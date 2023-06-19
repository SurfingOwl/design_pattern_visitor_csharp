namespace cc1;
class Program
{
    static void Main(string[] args)
    {
        Vehicules vehicules = new Vehicules();
        vehicules.Attach(new Car("Voiture", 0, 100, 10));
        vehicules.Attach(new Bike("Moto", 0, 100, 5));

        MileageVisitor mileageVisitor = new MileageVisitor();
        FuelComsuptionVisitor fuelComsuptionVisitor = new FuelComsuptionVisitor();

        vehicules.Accept(mileageVisitor);
        vehicules.Accept(fuelComsuptionVisitor);
    }
}
