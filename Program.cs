using System.Diagnostics;
using System.Threading;

namespace FactorioSplitScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("UniversalSplitScreen.exe");
            Thread.Sleep(5000);
            Process.Start("SplitScreen1.bat");
            Thread.Sleep(10000);
            Process.Start("SplitScreen2.bat");
        }
    }
}
