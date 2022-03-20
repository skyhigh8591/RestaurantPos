namespace RestaurantPos
{
    internal static class Program
    {

        public static int beefBurger = 0;
        public static int chickenBurger = 0;
        public static int japanesePizza = 0;
        public static int hawaiianPizza = 0;


        public static int beefBurgerPrice = 75;
        public static int chickenBurgerPrice = 70;
        public static int japanesePizzaPrice = 300;
        public static int hawaiianPizzaPrice = 250;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}