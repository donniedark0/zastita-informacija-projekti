using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17248_dom1
{
    public partial class Form1 : Form
    {
        private FileSystem fs;
        public Form1()
        {
            InitializeComponent();
            fs = new FileSystem();

        }

        private void TurnOnOrOffButtons(bool value)
        {
            this.btnDecodeFile.Enabled = value;
            this.btnChangeDestinationFolder.Enabled = value;
           
            this.btnChangeDestinationFolder.Enabled = value;
            this.btnChangeTargetFolder.Enabled = value;
            this.btnCodeFilesFromDirectory.Enabled = value;
        }

        private void ChooseFolder(TextBox tbResult)
        {
            DialogResult result = this.fbdChooseFolder.ShowDialog();
            if (result == DialogResult.OK)
               
                tbResult.Text = fbdChooseFolder.SelectedPath;
        }

        private void btnFileWathcerOnOff_Click(object sender, EventArgs e)
        {
            if(!fs.IsWatcherSystemOn())
            {
                try
                {
                    fs.TurnOnFileSystemWatcher();
                    btnFileWathcerOnOff.Text = "Turn OFF File Watcher System";
                    TurnOnOrOffButtons(false);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Couldn't turn on File Watcher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fs.TurnOffFileSystemWatcher();
                btnFileWathcerOnOff.Text = "Turn ON File Watcher System";
                TurnOnOrOffButtons(true);
            }
        }

        private void btnBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.tbTargetPath);
           
        }

        private void btnChangeTargetFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbTargetPath.Text))
            {
                fs.SetWatchedDirectory(this.tbTargetPath.Text);
                this.lblTargetFolderName.Text = fs.GetTargetDirectory();
                this.tbTargetPath.Text = "";
            }
            else MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBrowseDestinationFolder_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.tbDestinationPath);
        }

        private void btnChangeDestinationFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbDestinationPath.Text))
            {
                fs.SetOutputDirectory(tbDestinationPath.Text);
                this.lblDestinationFolderName.Text = fs.GetDestinationDirectory();
                this.tbDestinationPath.Text = "";
            }
            else MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBrowseFileToDecode_Click(object sender, EventArgs e)
        {
            this.ofdChooseFile.Filter = "Text|*.txt";
            DialogResult result = this.ofdChooseFile.ShowDialog();
            if (result == DialogResult.OK)
                this.tbDecodeFile.Text = ofdChooseFile.FileName;
        }

        private void btnBrowseDecodeDestFolder_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.tbDestDecodeFolder);
        }

        private void btnDecodeFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbDestDecodeFolder.Text) && File.Exists(tbDecodeFile.Text))
                try {
                    fs.DecodeTextFile(tbDecodeFile.Text, tbDestDecodeFolder.Text);
                    MessageBox.Show("Successful decoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                MessageBox.Show("Invalid file or directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnbrowseEncodePath_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.tbEncodePath);
        }

        private void btnCodeFilesFromDirectory_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbEncodePath.Text))
                try {
                    fs.EncodeAllFilesFromDirectory(tbEncodePath.Text);
                    MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            else
                MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fbdChooseFolder_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
