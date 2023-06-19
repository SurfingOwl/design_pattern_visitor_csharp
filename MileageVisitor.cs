namespace cc1
{
    public class MileageVisitor : IVisitor
    {
        public void Visit(Element element)
        {
           Vehicule vehicule = element as Vehicule;
           vehicule.mileage += 10.0;
        }
    }
}