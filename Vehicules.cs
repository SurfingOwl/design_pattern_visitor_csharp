namespace cc1
{
    public class Vehicules
    {
        private List<Vehicule> vehicules = new List<Vehicule>();

        public void Attach(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
        }

        public void Detach(Vehicule vehicule)
        {
            vehicules.Remove(vehicule);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Vehicule vehicule in vehicules)
            {
                vehicule.Accept(visitor);
            }
        }

        public override string? ToString()
        {
            return String.Join('\n', vehicules);
        }
    }
}