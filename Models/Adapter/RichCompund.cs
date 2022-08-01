namespace movilidades.Model 
{
        public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDatabank bank;
        // Constructor
        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }
        public override String[] Display()
        {
            // The Adaptee
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);
            
            string compound =  "\nCompound: ------ " + chemical;
            string Formula =  "Formula: ------ " + molecularFormula;
            string Weight =  "Weight: ------ " + molecularWeight;
            string Melting_Pt =  "Melting Pt: ------ " + meltingPoint;
            string Boiling_Pt =  "Boiling Pt: ------ " + boilingPoint;

            string[] result = {compound, Formula, Weight, Melting_Pt, Boiling_Pt }; 
            

            return result;
        }
    }

}