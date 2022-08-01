namespace movilidades.Model {
    public class DollyFirstPrototype : DollyPrototype
    {
        // Constructor
        public DollyFirstPrototype(string id)
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
    