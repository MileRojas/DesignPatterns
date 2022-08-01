namespace movilidades.Model 
{
     public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;
        public virtual String[] Display()
        {
            string[] result = {"Compound: Unknown ------"}; 
            return result;
        }
    }
}