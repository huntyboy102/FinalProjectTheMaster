using Lab5NotepadNegative;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectTheMaster
{
    public partial class TheMasterForm : Form
    {
        public TheMasterForm()
        {
            InitializeComponent();
        }

        #region Event Handlers
        #region Notepad Negative
        private void WindowNewNotepadNegative(object sender, EventArgs e)
        {
            formNotepadNegative notepadNegativeInstance = new formNotepadNegative();
            notepadNegativeInstance.MdiParent = this;
            notepadNegativeInstance.Show();
        }

        private void CopyClick(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.CopyClick(sender, e);
                }
                else
                {
                    MessageBox.Show("The 'copy' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
        }

        private void PasteClick(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.PasteClick(sender, e);
                }
                else
                {
                    MessageBox.Show("The 'paste' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
        }

        private void CutClick(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
                {
                    formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                    notepadNegativeInstance.CutClick(sender, e);
                }
                else
                {
                    MessageBox.Show("The 'cut' operation is not supported by the current selected windows.", "Operation Not Supported");
                }
            }
        }

        private void SelectAllClick(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType() == typeof(formNotepadNegative))
            {
                formNotepadNegative notepadNegativeInstance = (formNotepadNegative)this.ActiveMdiChild;
                notepadNegativeInstance.SelectAllClick(sender, e);
            }
        }

        private void WindowTileHorizontal(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowTileVertically(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void WindowCascade(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        #endregion
        #region CustomerEntry

        #endregion
        #endregion
    }
}
