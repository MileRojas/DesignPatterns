namespace movilidades.Model
{
     public class Scooter : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine("Drive the Scooter : " + km.ToString() + "km");
        }
    }

}