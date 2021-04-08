using System;
using System.IO;
using System.Windows.Forms;

namespace Lab5NotepadNegative
{
    public partial class formNotepadNegative : Form
    {
        string filePath = string.Empty;

        public formNotepadNegative()
        {
            InitializeComponent();
        }

        #region Event Handlers
        public void FileNew(object sender, EventArgs e)
        {
            textBoxEditor.Clear();
            filePath = String.Empty;
        }

        public void SaveClick(object sender, EventArgs e)
        {
            // If there is no file path.
            if (filePath == String.Empty)
            {
                // Call the FileSaveAs event handler.
                FileSaveAs(sender, e);
            }
            // If the string is not empty.
            else
            {
                // Call the save function.
                SaveTextFile(filePath);
            }
        }

        /// <summary>
        /// Open a save menu and have the user save the file to a specific location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            // Add filters to what file type can be saved.
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Ignore saving the file if the user clicks cancel.
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Make the file path the directory of the saved file.
                filePath = saveDialog.FileName;

                // Create a new file stream.
                FileStream myFile = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);

                // Create a new writer.
                StreamWriter writer = new StreamWriter(myFile);

                // Make the text in the file the text in the editor.
                writer.Write(textBoxEditor.Text);

                // Close the writer.
                writer.Close();
            }
        }

        /// <summary>
        /// Opens saved files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            // Add filters to what file type can be opened.
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Ignore opening the file if the user clicks cancel.
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // Make the file path the directory of the opened file.
                filePath = openDialog.FileName;

                // Create a new file stream.
                FileStream myFile = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);

                // Create a new reader.
                StreamReader reader = new StreamReader(myFile);

                // Make the editors text the contents in the file.
                textBoxEditor.Text = reader.ReadToEnd();

                // Close the reader.
                reader.Close();
            }
        }

        /// <summary>
        /// Select all text in the editor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectAllClick(object sender, EventArgs e)
        {
            // Select all text...pretty straight forward.
            textBoxEditor.SelectAll();
        }

        /// <summary>
        /// Paste copied text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PasteClick(object sender, EventArgs e)
        {
            textBoxEditor.Paste();
        }

        /// <summary>
        /// Cut the selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CutClick(object sender, EventArgs e)
        {
            textBoxEditor.Cut();
        }

        /// <summary>
        /// Copy the selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CopyClick(object sender, EventArgs e)
        {
            textBoxEditor.Copy();
        }

        /// <summary>
        /// Close the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Click to show information about the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutClick(object sender, EventArgs e)
        {
            MessageBox.Show(" NETD 2202 \n\n Lab 5 \n\n Notepad Negative Version 1.0 \n\n H. Lovering");
        }
        #endregion

        #region Functions

        /// <summary>
        /// Save the file.
        /// </summary>
        /// <param name="path"></param>
        public void SaveTextFile(string path)
        {
            FileStream myFile = new FileStream(path, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(myFile);

            writer.Write(textBoxEditor.Text);

            writer.Close();
        }

        #endregion

        
    }
}
