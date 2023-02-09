namespace Singletone_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton Design Pattern Example

            // Get the only instance of the MySingleton class using the Instance property
            MySingleton mySingleton = MySingleton.Instance;
            mySingleton.DoSomething();
        }
    }

    public class MySingleton
    {
        // Store the only instance of the MySingleton class
        private static MySingleton instance = new MySingleton();

        // Make the constructor private so that it can only be called within the class
        private MySingleton() { }

        // Property to return the only instance of the MySingleton class
        public static MySingleton Instance
        {
            get { return instance; }
        }

        // Method to show that the singleton class is being used
        public void DoSomething()
        {
            Console.WriteLine("Singleton class code has been called");
            Console.ReadLine();
        }
    }
}