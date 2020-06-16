using AppInstallerCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagerConsole
{
    /// <summary>
    /// Runs the installer console program for the application manager
    /// </summary>
    public class ApplicationInstaller
    {
        private bool HasFolder = false;
        private bool AdminInstall = false;
        private bool InstallLocationModified = false;
        private string InstallLocation;
        private List<ExecutableData> Executables = new List<ExecutableData>();
        private string ProgramLocation = "";
        private readonly string[] YesChoices = { "yes", "yeah", "y", "true", "1" };
        private readonly string[] AllowedOptions = { "yes", "yeah", "y", "true", "1", "no", "nah", "n", "false", "0" };

        /// <summary>
        /// Changes the install location depending on the current settings
        /// </summary>
        private void ChangeInstallLocation()
        {
            if (!InstallLocationModified)
            {
                if (AdminInstall)
                {
                    InstallLocation = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                }
                else
                {
                    InstallLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                }
                if (HasFolder)
                {
                    InstallLocation = Path.Combine(InstallLocation, Path.GetFileName(ProgramLocation));
                }
                else if (Executables.Count > 0)
                {
                    InstallLocation = Path.Combine(InstallLocation, Executables[0].ShortcutName);
                }
            }
        }

        /// <summary>
        /// Returns a boolean that determines if the application already exists
        /// </summary>
        /// <returns></returns>
        private bool ApplicationExists()
        {
            foreach (ExecutableData executableData in Executables)
            {
                if (File.Exists(Path.Combine(InstallLocation, executableData.ExecutablePath)))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns a boolean that determines if all the selected executables exist
        /// </summary>
        /// <returns>A boolean that determines if all the selected executables exist</returns>
        private bool AllExecutablesExist()
        {
            foreach (ExecutableData executableData in Executables)
            {
                if (!File.Exists(Path.Combine(ProgramLocation, executableData.ExecutablePath)))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Installs the application using the existing settings
        /// </summary>
        private void Install()
        {
            if (ApplicationExists())
            {
                ConsoleUtils.FormattedWrite("Application already exists at selected location");
            }
            else if (!AllExecutablesExist())
            {
                string nonExistentExecString = "";
                foreach (ExecutableData executableData in Executables)
                {
                    if (!File.Exists(Path.Combine(ProgramLocation, executableData.ExecutablePath)))
                    {
                        nonExistentExecString += "\"" + executableData.ExecutablePath + "\", ";
                    }
                }
                nonExistentExecString = nonExistentExecString.Substring(0, nonExistentExecString.Length - 2);
                ConsoleUtils.FormattedWrite("Executables located at the relative locations " + nonExistentExecString + " do not exist");
            }
            else if (!Directory.Exists(ProgramLocation))
            {
                ConsoleUtils.FormattedWrite("Program folder directory does not exist");

            }
            else if (Directory.Exists(InstallLocation) || (!Directory.Exists(InstallLocation) &&
                YesChoices.Contains(ConsoleUtils.FancyGetAllowedInput(AllowedOptions,
                "Installer will be required to create a new directory. Continue? ", isCaseSensitive: false).ToLower())))
            {
                Installer.InstallApp(Executables, ProgramLocation, InstallLocation, HasFolder, AdminInstall);
                ConsoleUtils.FormattedWrite("Application successfully installed");
            }
            ConsoleUtils.FormattedWrite("Press any key to continue...", new FormattedWriteSettings() { NewLine = false });
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Allows the user to modify the executables list
        /// </summary>
        private void ChangeExecutables()
        {
            int menuOption = -1;
            while (menuOption != Executables.Count + 2)
            {
                // Prep Screen for choosing the executable
                ConsoleUtils.PrepNewScreen("Application Installer");
                ConsoleUtils.CreateMenu(Executables.Select(x => x.ShortcutName).ToList().Concat(new string[] { "Add", "Back" }).ToList());
                menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: Executables.Count + 2, maxCharHeight: 1);
                ConsoleUtils.FormattedWrite();
                
                // Choose executable or add another one
                if (menuOption != Executables.Count + 2)
                {
                    ExecutableData executable, prevExecutable = new ExecutableData();
                    int executableIndex = menuOption - 1;
                    bool changeExisting = menuOption != Executables.Count + 1;

                    // Create a copy executable to change
                    if (changeExisting)
                    {
                        prevExecutable = Executables[executableIndex];
                        Executables.RemoveAt(executableIndex);
                        executable = new ExecutableData(prevExecutable);
                    }
                    else
                    {
                        executable = new ExecutableData();
                    }
                    menuOption = 0;

                    // Allow the user to change the settings of the copied executable
                    while (menuOption < 4)
                    {
                        List<string> menuItems = new List<string>() { "Executable path", "Shortcut name", "Create desktop shortcut", "Save", "Cancel" };
                        if (changeExisting)
                        {
                            menuItems.Insert(5, "Remove");
                        }

                        ConsoleUtils.PrepNewScreen("Application Installer");
                        DisplayExecutableSettings(executable);
                        ConsoleUtils.CreateMenu(menuItems, "Executable Options:");
                        menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: menuItems.Count, maxCharHeight: 1);
                        ConsoleUtils.FormattedWrite();

                        if (changeExisting && menuOption > 5)
                        {
                            menuOption++;
                        }

                        switch (menuOption)
                        {
                            // Change Executable path
                            case 1:
                                ConsoleUtils.FormattedWrite("Current Setting: " + executable.ExecutablePath);
                                executable.ExecutablePath = ConsoleUtils.FancyGetInput("Executable path: ");
                                if (executable.ShortcutName == "")
                                {
                                    executable.ShortcutName = Path.GetFileNameWithoutExtension(executable.ExecutablePath);
                                }
                                break;

                            // Change Shortcut name
                            case 2:
                                ConsoleUtils.FormattedWrite("Current Setting: " + executable.ShortcutName);
                                executable.ShortcutName = ConsoleUtils.FancyGetInput("Shortcut name: ");
                                break;

                            // Change On desktop
                            case 3:
                                ConsoleUtils.FormattedWrite("Current Setting: " + executable.OnDesktop);
                                string input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Create desktop shortcut: ", "Choice must be y/n", false, preventIncorrectText: true);
                                executable.OnDesktop = YesChoices.Contains(input.ToLower());
                                break;
                        }

                        if (menuOption == 4)
                        {
                            bool shortcutNameTaken = Executables.Select(x => x.ShortcutName).Contains(executable.ShortcutName);
                            bool executablePathTaken = Executables.Select(x => x.ExecutablePath).Contains(executable.ExecutablePath);
                            if (shortcutNameTaken || executablePathTaken)
                            {
                                if (shortcutNameTaken)
                                {
                                    ConsoleUtils.FormattedWrite("Shortcut name already taken");
                                }
                                if (executablePathTaken)
                                {
                                    ConsoleUtils.FormattedWrite("Executable Path already taken");
                                }
                                ConsoleUtils.FormattedWrite("Press any key to continue...");
                                Console.CursorVisible = false;
                                Console.ReadKey(true);
                                Console.CursorVisible = true;
                            }
                        }
                        else if (menuOption == 6 && changeExisting)
                        {
                            Executables.Insert(executableIndex, prevExecutable);
                        }
                    }
                    // Save settings/Add executable
                    if (menuOption == 4)
                    {
                        if (changeExisting)
                        {
                            Executables[executableIndex] = executable;
                        }
                        else
                        {
                            Executables.Add(executable);
                        }
                    }
                    menuOption = -1;
                }
            }
        }

        /// <summary>
        /// Shows the interface used to change the installer settings
        /// </summary>
        private void ChangeSettings()
        {
            int menuOption = -1;
            while (menuOption != 7)
            {
                string input;

                ConsoleUtils.PrepNewScreen("Application Installer");
                ConsoleUtils.CreateMenu(new string[] { "Change Executables", "Program location", "Installation location",
                    "Contained in app folder", "Install for all users? (Requires admin)", "Display settings", "Back" }, "Settings:");
                menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: 7, maxCharLength: 1, maxCharHeight: 1);
                ConsoleUtils.FormattedWrite();

                switch (menuOption)
                {
                    // Change executables
                    case 1:
                        ChangeExecutables();
                        break;

                    // Program location
                    case 2:
                        ConsoleUtils.FormattedWrite("Current Setting: " + ProgramLocation);
                        ProgramLocation = ConsoleUtils.FancyGetInput("Program location: ");
                        break;

                    // Installation location
                    case 3:
                        ConsoleUtils.FormattedWrite("Current Setting: " + InstallLocation);
                        InstallLocation = ConsoleUtils.FancyGetInput("Installation location: ");
                        InstallLocationModified = true;
                        break;

                    // Contained in app folder
                    case 4:
                        ConsoleUtils.FormattedWrite("Current Setting: " + HasFolder);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Contained in app folder? ", "Choice must be y/n", false);
                        HasFolder = YesChoices.Contains(input.ToLower());
                        break;

                    // Install for all users
                    case 5:
                        ConsoleUtils.FormattedWrite("Current Setting: " + AdminInstall);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Install for all users? (Requires admin) ", "Choice must be y/n", false);
                        AdminInstall = YesChoices.Contains(input.ToLower());
                        InstallLocationModified = false;
                        break;

                    // Display settings
                    case 6:
                        DisplaySettings();
                        break;
                }
                ChangeInstallLocation();
            }
        }

        /// <summary>
        /// Displays executable data in a box to the right of a screen
        /// </summary>
        /// <param name="executable">The executable to be displayed</param>
        public void DisplayExecutableSettings(ExecutableData executable)
        {
            Location boxLocation = new Location(40, 4);
            int height = 5;
            int rightPadding = 3;
            List<Tuple<string, string, int>> boxLines = new List<Tuple<string, string, int>>()
            {
                new Tuple<string, string, int>("Executable path: ", executable.ExecutablePath, 1),
                new Tuple<string, string, int>("Shortcut name: ", executable.ShortcutName, height - 1),
                new Tuple<string, string, int>("Create desktop shortcut: ", executable.OnDesktop.ToString(), height)
            };

            Borders borders = new Borders(true)
            {
                TopStyle = "*",
                LeftStyle = "-|",
                RightStyle = "|-",
                BottomStyle = "*"
            };
            Location bottomRightOfBox = new Location(Console.WindowWidth - rightPadding, boxLocation.Y + height + 
                borders.TopStyle.Length + borders.BottomStyle.Length + 1);

            FormattedWriteSettings writeSettings = new FormattedWriteSettings
            {
                MaximumWidth = bottomRightOfBox.X - boxLocation.X,
                InnerPadding = new Padding(0, borders.LeftStyle.Length + 1, borders.RightStyle.Length + 1, 0),
                ResetCursorPosition = true,
                NewLine = false
            };

            ConsoleUtils.CreateBox(boxLocation, bottomRightOfBox, borders);
            for (int i = 0; i < boxLines.Count; ++i)
            {
                writeSettings.Location = new Location(boxLocation.X, boxLocation.Y + boxLines[i].Item3);
                if (i < boxLines.Count - 1)
                {
                    writeSettings.MaximumHeight = boxLines[i + 1].Item3 - boxLines[i].Item3;
                } else
                {
                    writeSettings.MaximumHeight = height - boxLines[i].Item3 + 1;
                }
                ConsoleUtils.FormattedWrite(boxLines[i].Item1, writeSettings);
                writeSettings.Location.X += boxLines[i].Item1.Length;
                writeSettings.MaximumWidth -= boxLines[i].Item1.Length;

                ConsoleUtils.FormattedWrite(boxLines[i].Item2, writeSettings);
                writeSettings.MaximumWidth += boxLines[i].Item1.Length;
            }
        }

        /// <summary>
        /// Displays the current settings for the installer
        /// </summary>
        public void DisplaySettings()
        {
            ConsoleUtils.FormattedWrite("Executables:");
            foreach (ExecutableData executable in Executables)
            {
                ConsoleUtils.FormattedWrite("\tShortcut Name: " + executable.ShortcutName);
                ConsoleUtils.FormattedWrite("\tExecutable Path: " + executable.ExecutablePath);
                ConsoleUtils.FormattedWrite("\tOn the Desktop: " + executable.OnDesktop);
                ConsoleUtils.FormattedWrite();
            }
            ConsoleUtils.FormattedWrite("Program Location: " + ProgramLocation);
            ConsoleUtils.FormattedWrite("Installation Location: " + InstallLocation);
            ConsoleUtils.FormattedWrite("Extra options:");
            if (HasFolder)
            {
                ConsoleUtils.FormattedWrite(" - Contained in app folder");
            }
            if (AdminInstall)
            {
                ConsoleUtils.FormattedWrite(" - Shortcuts are global");
            }
            ConsoleUtils.FormattedWrite();
            ConsoleUtils.FormattedWrite("Press any key to continue...", new FormattedWriteSettings() { NewLine = false });
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Starts the installer program
        /// </summary>
        public void Start()
        {
            int menuOption = -1;
            Console.Title = "Application Installer";
            ChangeInstallLocation();

            while (menuOption != 4)
            {
                ConsoleUtils.PrepNewScreen("Application Installer");
                ConsoleUtils.CreateMenu(new string[] { "Display Settings", "Change Settings", "Install with current settings", "Back" });
                menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Option must be an integer", "Default", 1, 4, maxCharLength: 1, maxCharHeight: 1);
                
                switch (menuOption)
                {
                    case 1: // Display Settings
                        ConsoleUtils.FormattedWrite();
                        DisplaySettings();
                        break;
                    case 2: // Change settings
                        ChangeSettings();
                        break;
                    case 3:
                        Install();
                        break;
                }
            }
        }
    }
}
