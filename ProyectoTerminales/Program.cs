using ProyectoTerminales.Comerciales.FormulariosComer;
namespace ProyectoTerminales




{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmProductos());
        }
    }
}