using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace FormUtilities
{
    /// <summary>
    /// Contains utilities code for the general control class
    /// </summary>
    public static class GeneralControlUtils
    {
        /// <summary>
        /// Reverses the control collection in the controls
        /// </summary>
        /// <param name="originalCollection">The control collection to be reversed</param>
        public static void Reverse(this ControlCollection originalCollection)
        {
            List<Control> newControlCollection = new List<Control>();
            foreach (Control control in originalCollection)
            {
                newControlCollection.Insert(0, control);
            }
            originalCollection.Clear();
            originalCollection.AddRange(newControlCollection.ToArray());
        }

        /// <summary>
        /// Replaces a specific index in a control collection
        /// </summary>
        /// <param name="originalCollection">The collection that is being modified</param>
        /// <param name="indexToReplace">The index to be replaced</param>
        /// <param name="newControl">The new control to replace the old control</param>
        public static void Replace(this ControlCollection originalCollection, int indexToReplace, Control newControl)
        {
            originalCollection.Insert(indexToReplace, newControl);
            originalCollection.RemoveAt(indexToReplace + 1);
        }

        /// <summary>
        /// Inserts a control into the <c>ControlCollection</c> at the specified index
        /// </summary>
        /// <param name="originalCollection">The collection that is being modified</param>
        /// <param name="index">The zero-based index at which item is being inserted</param>
        /// <param name="newControl">The control to insert</param>
        public static void Insert(this ControlCollection originalCollection, int index, Control newControl)
        {
            // Detect if index is out of range
            if (index < 0 || index > originalCollection.Count)
            {
                throw new IndexOutOfRangeException("Index must be within the bounds of the ControlCollection");
            }

            // Decide best method depending on index or count
            if (originalCollection.Count == 0)
            {
                originalCollection.Add(newControl);
            }
            else if (index > originalCollection.Count / 2)
            {
                SmartInsert(originalCollection, index, newControl);
            }
            else
            {
                BasicInsert(originalCollection, index, newControl);
            }
        }

        private static void BasicInsert(this ControlCollection originalCollection, int index, Control newControl)
        {
            int i = 0;
            Control tempControl = new Control();

            // Loop through original collection until point at which index is to be added
            while (originalCollection.Count > 0)
            {
                // Inserts the new control if currently at the desired index
                if (i == index)
                {
                    tempControl.Controls.Add(newControl);
                }
                tempControl.Controls.Add(originalCollection[0]);
                i++;
            }

            // Finally add modified collection
            originalCollection.AddRange(tempControl.Controls.ToArray());
        }

        private static void SmartInsert(this ControlCollection originalCollection, int index, Control newControl)
        {
            Control tempControl = new Control();

            // Save collection contents until next index is the new control
            while (originalCollection.Count > index)
            {
                tempControl.Controls.Add(originalCollection[originalCollection.Count - 1]);
                originalCollection.RemoveAt(originalCollection.Count - 1);
            }

            // Add control
            originalCollection.Add(newControl);

            // Add old list contents
            while (tempControl.Controls.Count > 0)
            {
                originalCollection.Add(tempControl.Controls[tempControl.Controls.Count - 1]);
                tempControl.Controls.RemoveAt(tempControl.Controls.Count - 1);
            }
        }

        /// <summary>
        /// Copies the elements of the <c>ControlCollection</c> to a new array
        /// </summary>
        /// <param name="controlCollection">The control collection to copy from</param>
        /// <returns>A list containing all controls</returns>
        public static Control[] ToArray(this ControlCollection controlCollection)
        {
            return controlCollection.ToList().ToArray();
        }

        /// <summary>
        /// Copies the elements of the <c>ControlCollection</c> to a new list
        /// </summary>
        /// <param name="controlCollection">The control collection to copy from</param>
        /// <returns>A list containing all controls</returns>
        public static List<Control> ToList(this ControlCollection controlCollection)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control control in controlCollection)
            {
                controlList.Add(control);
            }
            return controlList;
        }
    }
}
