using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstallerCode
{
    /// <summary>
    /// Contains code used in the general application
    /// </summary>
    static class GeneralApp
    {
        /// <summary>
        /// Moves a directory to the specified directory
        /// </summary>
        /// <param name="sourceDirectory">The source directory to copy from</param>
        /// <param name="finalDirectory">The directory to copy to</param>
        public static void MoveDirectory(string sourceDirectory, string finalDirectory)
        {
            // Create new location
            Directory.CreateDirectory(finalDirectory);

            // Move contents to new location
            string[] folderContents = Directory.EnumerateFileSystemEntries(sourceDirectory).ToArray();
            foreach (string content in folderContents)
            {
                // If content is a directory
                if (File.GetAttributes(content).HasFlag(FileAttributes.Directory))
                {
                    MoveDirectory(content, Path.Combine(finalDirectory, Path.GetFileName(content)));
                }
                // If content is a file
                else
                {
                    File.Move(content, Path.Combine(finalDirectory, Path.GetFileName(content)));
                }
            }

            // Delete old location
            Directory.Delete(sourceDirectory);
        }
    }
}
