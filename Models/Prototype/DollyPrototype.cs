namespace movilidades.Model 
{
    public abstract class DollyPrototype
    {
        string id;
        // Constructor
        public DollyPrototype(string id)
        {
            this.id = id;
        }
        // Gets id
        public string Id
        {
            get { return id; }
        }
        public abstract DollyPrototype Clone();
    }
}
    