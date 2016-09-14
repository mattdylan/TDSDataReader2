using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TDSDataReader2.TestBuild
{
    public partial class fileRenameForm : Form
    {
        string pathToTdsFiles;
        string driveSelected;
        string currentIdentifier;
        string newIdentifier;
        bool newValid;
        bool oldValid;

        public fileRenameForm()
        {
            InitializeComponent();
        }

        private void fileRenameForm_Load(object sender, EventArgs e)
        {
            //Populate the drivesComboBox with valid drives
            drivesComboBox.Items.AddRange(Environment.GetLogicalDrives());
        }

        //Gets the file path to use for renaming the files
        protected string GetFilePath()
        {
            string path = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            return path;
        }

        //Only allow numbers and letters to be typed in, and return the carat to the end of the line when char is rejected. Also capitalizes the letters as they are typed
        protected bool validateIdentifier(TextBox identifierTextBox)
        {
            
            identifierTextBox.Text = string.Concat(identifierTextBox.Text.Where(char.IsLetterOrDigit));
            identifierTextBox.SelectionStart = identifierTextBox.Text.Length + 1;
            identifierTextBox.CharacterCasing = CharacterCasing.Upper;

            if (identifierTextBox.Text.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check and see if input is valid from both newIdentifierTextBox and oldIdentifierTextBox and show/hide the rename button accordingly
        protected void bothValid()
        {
            if (oldValid && newValid)
            {
                renameButton.Enabled = true;
            }
            else
            {
                renameButton.Enabled = false;
            }
        }

        //Rename the files according to the input from the user
        //Still need to add some features to this, such as try/catch, confirmation dialogue box (to give user the chance to cancel) and a better success message box.
        protected void renameFiles(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                File.Move(file.FullName, file.FullName.ToString().Replace(currentIdentifier, newIdentifier));
            }
            MessageBox.Show("Success!");
            clearData();
        }

        //Clear all data from the controls on the form
        protected void clearData()
        {
            Utilities.ClearControls(this);

        }

        private void chooseDriveRadio_CheckedChanged(object sender, EventArgs e)
        {
            //Disables the alternate choice when a radio button is selected. Clears the pathTextBox and drivesComboBox each time to avoid text stored there when the browse radio button isn't selected. 
            if (chooseDriveRadio.Checked)
            {
                browseButton.Enabled = false;
                pathTextBox.Enabled = false;
                drivesComboBox.Enabled = true;
                pathTextBox.Clear();
            }
            else
            {
                drivesComboBox.Enabled = false;
                browseButton.Enabled = true;
                pathTextBox.Enabled = true;
                drivesComboBox.SelectedIndex = -1;
            }
        }

        //Sets the path when selected/changed in the driveComboBox
        private void drivesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            driveSelected = drivesComboBox.Text;
        }

        //Sets the path when selected/changed by browsing
        private void browseButton_Click(object sender, EventArgs e)
        {
            pathToTdsFiles = GetFilePath();
            pathTextBox.Text = pathToTdsFiles;
        }

        //Validate the input of the currentIdentifierTextBox
        private void currentIndentifierTextBox_TextChanged(object sender, EventArgs e)
        {
            oldValid = validateIdentifier(currentIdentifierTextBox);
            bothValid();
        }

        //Validate the input of newIdentifierTextBox
        private void newIdentifierTextBox_TextChanged(object sender, EventArgs e)
        {
            newValid = validateIdentifier(newIdentifierTextBox);
            bothValid();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            currentIdentifier = currentIdentifierTextBox.Text;
            newIdentifier = newIdentifierTextBox.Text;
            
            //Checks if chooseDriveRadio is checked, and if so, runs the file rename method. If not, checks to see if Browse box was used to pick a path, and if so, runs the file rename method. If neither, an error dialogbox is opened.            
            if (chooseDriveRadio.Checked)
            {
                if (!drivesComboBox.Items.Contains(drivesComboBox.Text))
                {
                    MessageBox.Show("Please Select a Drive From the Drop Down Box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else renameFiles(driveSelected);
            }
            else
            {
                if (string.IsNullOrEmpty(pathTextBox.Text))
                {
                    MessageBox.Show("Please select the Browse button to select a path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else renameFiles(pathToTdsFiles);
            }
        }

    }
}
