
namespace PresentationLayer
{
    internal static class Program
    {
        public static BusinessLayer.HandlerBusiness businessHandler;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            businessHandler = new BusinessLayer.HandlerBusiness();
            Application.Run(new Form1());

        }
    }
}