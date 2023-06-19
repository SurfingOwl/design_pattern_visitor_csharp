namespace cc1
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}