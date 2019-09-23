using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstallerCode
{
    /// <summary>
    /// Contains code used for the uninstaller
    /// </summary>
    public static class Uninstaller
    {
        /// <summary>
        /// Uninstalls an app and removes all data
        /// </summary>
        /// <param name="shortcutName">The name of the shortcuts to be removed</param>
        /// <param name="installationLocation">The location of the installation</param>
        public static void UninstallApp(string shortcutName, string installationLocation)
        {
            // Use move app method to reduce errors - delete created directory
            MoveApp(shortcutName, installationLocation, Path.Combine(Path.GetTempPath(), "Directory Deletion"));
            Directory.Delete(Path.Combine(Path.GetTempPath(), "Directory Deletion"));
        }

        /// <summary>
        /// Uninstalls shortcuts and moves program data to a specified location
        /// </summary>
        /// <param name="shortcutName">The name of the shortcuts to be removed</param>
        /// <param name="installationLocation">The location of the installation</param>
        /// <param name="saveLocation">The save location to save to - if null, program will be uninstalled completely</param>
        public static void MoveApp(string shortcutName, string installationLocation, string saveLocation)
        {
            if (Path.GetExtension(shortcutName) != ".lnk")
            {
                shortcutName += ".lnk";
            }

            Directory.CreateDirectory(saveLocation);

            // Move file
            if (File.GetAttributes(installationLocation).HasFlag(FileAttributes.Directory))
            {
                GeneralApp.MoveDirectory(installationLocation, saveLocation);
            }
            else
            {
                File.Move(installationLocation, saveLocation);
            }

            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), shortcutName)))
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), shortcutName));
            }
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), shortcutName)))
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), shortcutName));
            }
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms), shortcutName)))
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms), shortcutName));
            }
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Programs), shortcutName)))
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Programs), shortcutName));
            }
        }
    }
}
