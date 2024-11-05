namespace Constructors
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        #region Parameterized Constrcutor
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        #endregion

        #region Copy Constructor 
        public Car(Car copy)
        {
            Make = copy.Make;
            Model = copy.Model;
            Year = copy.Year;
        }
        #endregion

        #region Static Constructor 
        static Car()
        {
            Console.WriteLine("This is My Car");
        }
        #endregion

        #region Static method
        public static void print()
        {
            Console.WriteLine("This is my static method, but you can see static constructor has been executed before me");
        }
        #endregion

        #region Parameter-less(default) Constructor
        public Car()
        {
            Make = "Toyota";
            Model = "Fortuner";
            Year = 2025;
        }
        #endregion

        //#region Private Constructor
        //private Car()
        //{

        //}
        //#endregion
    }
}
