using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption = -1;

            while (menuOption != 3)
            {
                Console.Title = "Application Manager";
                ConsoleUtils.PrepNewScreen("Application Manager");
                ConsoleUtils.CreateMenu(new string[] { "Installer", "Uninstaller", "Close" });
                menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Option must be an integer", "Default", 1, 3, maxCharLength: 1, maxCharHeight: 1);

                switch (menuOption)
                {
                    case 1:
                        ApplicationInstaller installer = new ApplicationInstaller();
                        installer.Start();
                        break;
                    case 2:
                        ApplicationUninstaller uninstaller = new ApplicationUninstaller();
                        uninstaller.Start();
                        break;
                }
            }
            ConsoleUtils.FormattedWrite("See you later...", new FormattedWriteSettings() { SlowWrite = true });
            Console.CursorVisible = false;
            Thread.Sleep(2000);
        }
    }
}
