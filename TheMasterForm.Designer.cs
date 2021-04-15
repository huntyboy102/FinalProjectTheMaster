
namespace FinalProjectTheMaster
{
    partial class TheMasterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheMasterForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuWindowOpenAverageUnitsShipped = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowOpenCarInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowOpenCustomerEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowOpenNewNotepadNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuWindow,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(937, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileSeparator1,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(146, 22);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.Click += new System.EventHandler(this.FileNew);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.OpenFile);
            // 
            // menuFileSeparator
            // 
            this.menuFileSeparator.Name = "menuFileSeparator";
            this.menuFileSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(146, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // menuFileSeparator1
            // 
            this.menuFileSeparator1.Name = "menuFileSeparator1";
            this.menuFileSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(146, 22);
            this.menuFileExit.Text = "E&xit";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditCut,
            this.menuEditPaste,
            this.menuEditSeparator,
            this.menuEditSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(144, 22);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.Click += new System.EventHandler(this.CopyClick);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(144, 22);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.Click += new System.EventHandler(this.CutClick);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(144, 22);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.Click += new System.EventHandler(this.PasteClick);
            // 
            // menuEditSeparator
            // 
            this.menuEditSeparator.Name = "menuEditSeparator";
            this.menuEditSeparator.Size = new System.Drawing.Size(141, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.Size = new System.Drawing.Size(144, 22);
            this.menuEditSelectAll.Text = "Select &All";
            this.menuEditSelectAll.Click += new System.EventHandler(this.SelectAllClick);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowCascade,
            this.menuWindowTileVertical,
            this.menuWindowTileHorizontal,
            this.menuWindowSeparator,
            this.menuWindowOpenAverageUnitsShipped,
            this.menuWindowOpenCarInventory,
            this.menuWindowOpenCustomerEntry,
            this.menuWindowOpenNewNotepadNegative});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(63, 20);
            this.menuWindow.Text = "&Window";
            // 
            // menuWindowCascade
            // 
            this.menuWindowCascade.Name = "menuWindowCascade";
            this.menuWindowCascade.Size = new System.Drawing.Size(229, 22);
            this.menuWindowCascade.Text = "Cascade Window";
            this.menuWindowCascade.Click += new System.EventHandler(this.WindowCascade);
            // 
            // menuWindowTileVertical
            // 
            this.menuWindowTileVertical.Name = "menuWindowTileVertical";
            this.menuWindowTileVertical.Size = new System.Drawing.Size(229, 22);
            this.menuWindowTileVertical.Text = "Tile Window Vertically";
            this.menuWindowTileVertical.Click += new System.EventHandler(this.WindowTileVertically);
            // 
            // menuWindowTileHorizontal
            // 
            this.menuWindowTileHorizontal.Name = "menuWindowTileHorizontal";
            this.menuWindowTileHorizontal.Size = new System.Drawing.Size(229, 22);
            this.menuWindowTileHorizontal.Text = "Tile Window Horizontally";
            this.menuWindowTileHorizontal.Click += new System.EventHandler(this.WindowTileHorizontal);
            // 
            // menuWindowSeparator
            // 
            this.menuWindowSeparator.Name = "menuWindowSeparator";
            this.menuWindowSeparator.Size = new System.Drawing.Size(226, 6);
            // 
            // menuWindowOpenAverageUnitsShipped
            // 
            this.menuWindowOpenAverageUnitsShipped.Name = "menuWindowOpenAverageUnitsShipped";
            this.menuWindowOpenAverageUnitsShipped.Size = new System.Drawing.Size(229, 22);
            this.menuWindowOpenAverageUnitsShipped.Text = "Open Average Units Shipped";
            this.menuWindowOpenAverageUnitsShipped.Click += new System.EventHandler(this.WindowOpenAverageUnitsShipped);
            // 
            // menuWindowOpenCarInventory
            // 
            this.menuWindowOpenCarInventory.Name = "menuWindowOpenCarInventory";
            this.menuWindowOpenCarInventory.Size = new System.Drawing.Size(229, 22);
            this.menuWindowOpenCarInventory.Text = "Open &Car Inventory";
            this.menuWindowOpenCarInventory.Click += new System.EventHandler(this.WindowOpenCarInventory);
            // 
            // menuWindowOpenCustomerEntry
            // 
            this.menuWindowOpenCustomerEntry.Name = "menuWindowOpenCustomerEntry";
            this.menuWindowOpenCustomerEntry.Size = new System.Drawing.Size(229, 22);
            this.menuWindowOpenCustomerEntry.Text = "Open Customer Entry";
            this.menuWindowOpenCustomerEntry.Click += new System.EventHandler(this.WindowOpenCustomerEntry);
            // 
            // menuWindowOpenNewNotepadNegative
            // 
            this.menuWindowOpenNewNotepadNegative.Name = "menuWindowOpenNewNotepadNegative";
            this.menuWindowOpenNewNotepadNegative.Size = new System.Drawing.Size(229, 22);
            this.menuWindowOpenNewNotepadNegative.Text = "Open New &Notepad Negative";
            this.menuWindowOpenNewNotepadNegative.Click += new System.EventHandler(this.WindowNewNotepadNegative);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.Click += new System.EventHandler(this.AboutClick);
            // 
            // TheMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 532);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "TheMasterForm";
            this.Text = "Master Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator menuEditSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenNewNotepadNegative;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenCarInventory;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuWindowTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuWindowTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenCustomerEntry;
        private System.Windows.Forms.ToolStripSeparator menuWindowSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenAverageUnitsShipped;
    }
}

