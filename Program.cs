using CampusLife.Forms;

namespace CampusLife;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        // DPI awareness is declared as "unaware" in app.manifest so the
        // Windows Forms Designer opens at 96 DPI on high-DPI / scaled displays.
        // We therefore skip Application.SetHighDpiMode() and let the manifest
        // value govern both designer and runtime behaviour.
        // EnableVisualStyles + SetCompatibleTextRenderingDefault still apply
        // the standard WinForms visual polish without touching DPI settings.
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new MainForm());
    }
}
