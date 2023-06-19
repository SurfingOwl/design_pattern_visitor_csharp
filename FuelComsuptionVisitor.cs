namespace cc1
{
    public class FuelComsuptionVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Vehicule vehicule = element as Vehicule;
            vehicule.fuel -= vehicule.consumption / 10;
        }
    }
}