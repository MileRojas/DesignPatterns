namespace movilidades.Model 
{
     public class Bike : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine("Drive the Bike : " + km.ToString() + "km");
        }
    }

}