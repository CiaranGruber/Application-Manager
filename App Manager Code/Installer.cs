using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;
using IWshRuntimeLibrary;

namespace AppInstallerCode
{
    /// <summary>
    /// Contains helper methods used to install to select paths
    /// </summary>
    public static class Installer
    {
        /// <summary>
        /// Installs an app using the full process
        /// </summary>
        /// <param name="executablePath">The path of the executable from the program folder</param>
        /// <param name="shortcutName">The name of the shortcuts to be created</param>
        /// <param name="programFolder">The folder where the program is situated</param>
        /// <param name="installFolder">The folder where the program is to be installed</param>
        /// <param name="containedInAnAppFolder">Whether the executable is contained in an app folder or is standalone</param>
        /// <param name="createDesktopShortcut">Whether to create desktop shortcuts or not</param>
        /// <param name="isAdmin">Whether the user wishes to act as admin or not</param>
        public static void InstallApp(string executablePath, string shortcutName, string programFolder, string installFolder, bool containedInAnAppFolder, bool createDesktopShortcut, bool isAdmin)
        {
            // Change shortcut name to include standard .lnk extension
            shortcutName = Path.GetFileNameWithoutExtension(shortcutName) + ".lnk";

            // Move files to project folder
            Directory.CreateDirectory(installFolder);
            if (containedInAnAppFolder)
            {
                GeneralApp.MoveDirectory(programFolder, installFolder);
            }
            else
            {
                System.IO.File.Move(Path.Combine(programFolder, executablePath), Path.Combine(installFolder, executablePath));
            }

            // Create shortcuts
            IWshShell_Class wsh = new IWshShell_Class();
            IWshShortcut shortcut;
            IWshShortcut desktopShortcut = null;
            if (isAdmin)
            {
                // Create standard shortcut
                shortcut = wsh.CreateShortcut(Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonPrograms), shortcutName)) as IWshShortcut;

                // Create desktop shortcut
                if (createDesktopShortcut)
                {
                    desktopShortcut = wsh.CreateShortcut(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.CommonDesktopDirectory), shortcutName)) as IWshShortcut;
                }
            }
            else
            {
                // Create standard shortcuts
                shortcut = wsh.CreateShortcut(Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.Programs), shortcutName)) as IWshShortcut;

                // Create desktop shortcut
                if (createDesktopShortcut)
                {
                    desktopShortcut = wsh.CreateShortcut(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop), shortcutName)) as IWshShortcut;
                }
            }
            shortcut.WorkingDirectory = installFolder;
            shortcut.TargetPath = Path.Combine(installFolder, Path.Combine(installFolder, executablePath));
            shortcut.Save();

            // Desktop shortcuts will be created if they are expected
            if (createDesktopShortcut)
            {
                desktopShortcut.WorkingDirectory = installFolder;
                desktopShortcut.TargetPath = Path.Combine(installFolder, Path.Combine(installFolder, executablePath));
                desktopShortcut.Save();
            }
        }
    }
}
