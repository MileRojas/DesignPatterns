namespace movilidades.Model
{
    public class DollySecondPrototype : DollyPrototype
    {
        // Constructor
        public DollySecondPrototype(string id)
            : base(id)
        {
        }
        // Returns a shallow copy
        public override DollyPrototype Clone()
        {
            return (DollyPrototype)this.MemberwiseClone();
        }
    }
}
