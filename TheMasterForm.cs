/*
 * Name: Hunter L Praveen J-M
 * Date: 2021-04-06
 * Desc: This program is a master program. It features all previous labs all under one Parent form.
 * This master form includes Praveen's Average Units Shipped, Hunter's Notepad, Hunter's car inventory taker and Hunter's Customer Entry.
 * 
 * Changes: Most changes have been documented on my Github. I did a lot for this lab, Praveen only supplied me with their Lab 1. Little ticked but that's ok.
 */
using AvgUnitsShipped;
using CustomerViewer;
using Lab4InventoryForCars;
using Lab5NotepadNegative;
using System;
using System.Windows.Forms;

namespace FinalProjectTheMaster
{
    public partial class TheMasterForm : Form
    {
        public TheMasterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a new NotepadNegative child.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowNewNotepadNegative(object sender, EventArgs e)
        {
            // Create a new notepad negative instance.
            formNotepadNegative notepadNegativeInstance = new formNotepadNegative();

            // Set the forms parent to the master form.
            notepadNegativeInstance.MdiParent = this;

            // Show the notepad negative form.
            notepadNegativeInstance.Show();
        }

        /// <summary>
        /// This assigns an instance of the customer entry form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowOpenCustomerEntry(object sender, EventArgs e)
        {
            // Create (or call) the customer entry instance.
            formCustomerEntry customerEntryInstance = formCustomerEntry.Instance;

            // Assign this child window an MdiParent
            customerEntryInstance.MdiParent = this;

            // Display the existing or created instance.
            customerEntryInstance.Show();
            customerEntryInstance.Focus();
        }

        /// <summary>
        /// This assigns an instance of the car inventory taker form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowOpenCarInventory(object sender, EventArgs e)
        {
            // Create (or call) the customer entry instance.
            formCarInventory carInventoryInstance = formCarInventory.Instance;

            // Assign this child window an MdiParent
            carInventoryInstance.MdiParent = this;

            // Display the existing or created instance.
            carInventoryInstance.Show();
            carInventoryInstance.Focus();
        }

        /// <summary>
        /// This assigns an instance of the average units shipped form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowOpenAverageUnitsShipped(object sender, EventArgs e)
        {
            // Create (or call) the customer entry instance.
            formAvgShippedUnit avgShippedUnitsInstance = formAvgShippedUnit.Instance;

            // Assign this child window an MdiParent
            avgShippedUnitsInstance.MdiParent = this;

            // Display the existing or created instance.
            avgShippedUnitsInstance.Show();
            avgShippedUnitsInstance.Focus();
        }

        /// <summary>
        /// Copy selected items if notepad negative is open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyClick(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call for the CopyClick function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.CopyClick(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Copy' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open NotepadNegative in order to use the copy operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteClick(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the PasteClick function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.PasteClick(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Paste' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open NotepadNegative in order to use the 'Paste' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// Cut the current selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutClick(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the CutClick function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.CutClick(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Cut' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open NotepadNegative in order to use the 'Cut' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// Select all text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllClick(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the SelectAllClick function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.SelectAllClick(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Select All' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open NotepadNegative in order to use the 'Select All' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// If the user clicks Save as, save the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSaveAs(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the FileSaveAs function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.FileSaveAs(sender, e);
                }
                // If the child is CustomerEntry.
                else if (this.ActiveMdiChild.GetType() == typeof(formCustomerEntry))
                {
                    // Call the ButtonSaveClick function.
                    formCustomerEntry customerEntryInstance = (formCustomerEntry)this.ActiveMdiChild;
                    customerEntryInstance.ButtonSaveClick(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Save As' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open a form in order to use the 'Save As' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// Save the current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClick(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the SaveClick function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.SaveClick(sender, e);
                }
                // If the child is Customer Entry.
                else if (this.ActiveMdiChild.GetType() == typeof(formCustomerEntry))
                {
                    // Call the ButtonSaveClick function.
                    formCustomerEntry customerEntryInstance = (formCustomerEntry)this.ActiveMdiChild;
                    customerEntryInstance.ButtonSaveClick(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Save' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open a form in order to use the 'Save' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// Create a new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileNew(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the FileNew function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.FileNew(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'New' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open NotepadNegative in order to use the 'New' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// Open a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile(object sender, EventArgs e)
        {
            // If there is MdiChildren.
            if (this.MdiChildren.Length > 0)
            {
                // If the child is notepad negative.
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    // Call the OpenFile function.
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.OpenFile(sender, e);
                }
                else
                {
                    // Show a message box if the form is not supported in the current window.
                    MessageBox.Show("The 'Open' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
            else
            {
                // Show a message box if there is no form open.
                MessageBox.Show("You must open NotepadNegative in order to use the 'Open' operation.", "Operation Not Supported");
            }
        }

        /// <summary>
        /// Tile windows horizontally.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowTileHorizontal(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Tile windows vertically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowTileVertically(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Cascade all windows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowCascade(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        
    }
}
