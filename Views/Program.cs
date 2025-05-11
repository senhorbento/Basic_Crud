using Core;

namespace Basic_CRUD.Views;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        using DB db = new();
        db.Init();
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}