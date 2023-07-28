using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17248_Darko_Milicevic_prvi_domaci
{
    public partial class Form1 : Form
    {
        private FileSystem fs;
        private Rotor rr, rm, rl, reflector;
        private string key;


        public Form1()
        {
            InitializeComponent();
            fs = new FileSystem();
            txtBoxKey.Enabled = false;
        }
        private void btnFileSystemWatcher_Click(object sender, EventArgs e)
        {
            this.rr.watcherTrigger = true;
            this.rm.watcherTrigger = true;
            this.rl.watcherTrigger = true;
            fs.rr = rr;
            fs.key = txtBoxKey.Text;
            
            if (!fs.IsWatcherOn())
            {
                try
                {
                    fs.TurnWatcherON();
                    btnFileSystemWatcher.Text = "Turn OFF File Watcher System";
                    TurnOnOrOffButtons(false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Couldn't turn on File Watcher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fs.TurnWatcherOFF();
                btnFileSystemWatcher.Text = "Turn ON File Watcher System";
                 TurnOnOrOffButtons(true);
                this.rr.watcherTrigger = false;
                this.rm.watcherTrigger = false;
                this.rl.watcherTrigger = false;
            }
            lblRR.Text = "" + ((char)(65 + rr.offset));
            lblRM.Text = "" + ((char)(65 + rm.offset));
            lblRL.Text = "" + ((char)(65 + rl.offset));
        }

        private void TurnOnOrOffButtons(bool value)
        {
            this.bttnUPrr.Enabled = value;
            this.bttnUPrm.Enabled = value;
            this.bttnUPrl.Enabled = value;
            this.bttnDOWNrr.Enabled = value;
            this.bttnDOWNrm.Enabled = value;
            this.bttnDOWNrl.Enabled = value;

            this.bttnBrowseDestFolder.Enabled = value;
            this.bttnBrowseTargetFolder.Enabled = value;
            this.bttnSubmitDecode.Enabled = value;
            this.bttnSubmitEncode.Enabled = value;
            this.btnBrowseTargetDecoded.Enabled = value;
            this.btnBrowseToEncode.Enabled = value;
            this.btnSubmitDestFolder.Enabled = value;
            this.btnSubmitTargetFolder.Enabled = value;
            this.btnSwitch.Enabled = value;
            
        }

        private void btnSubmitTargetFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtBoxTarget.Text))
            {
                fs.SetTargetDirectory(txtBoxTarget.Text);
                this.lblTargetFolder.Text = fs.GetTargetDirectory();
                this.txtBoxTarget.Text = "";
            }
            else MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubmitDestFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtBoxDest.Text))
            {
                fs.SetOutputDirectory(txtBoxDest.Text);
                this.lblDestFolder.Text = fs.GetDestinationDirectory();
                this.txtBoxDest.Text = "";
            }
            else MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChooseFolder(TextBox tbResult)
        {
            DialogResult result = this.fbdBrowseFolder.ShowDialog();
            if (result == DialogResult.OK)

                tbResult.Text = fbdBrowseFolder.SelectedPath;
        }

        private void bttnBrowseDestFolder_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.txtBoxDest);
        }

        private void bttnBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.txtBoxTarget);
        }

        private void btnBrowseTargetDecoded_Click(object sender, EventArgs e)
        {
            this.ofdBrowseFile.Filter = "Text|*.txt";
            DialogResult result = this.ofdBrowseFile.ShowDialog();
            if (result == DialogResult.OK)
                this.txtBoxTargetDecode.Text = ofdBrowseFile.FileName;
        }

        private void bttnSubmitDecode_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtBoxTargetDecode.Text))
            {
                if (!fs._switch)
                {
                    try
                    {
                        fs.DecodeFilesFromDirectory(txtBoxTargetDecode.Text, rr);
                        MessageBox.Show("Successful decoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {

                        fs.DecodeXTEA(txtBoxTargetDecode.Text, txtBoxKey.Text);
                        MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid file or directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnUPrl_Click(object sender, EventArgs e)
        {
            rl.Move();
        }

        private void bttnUPrm_Click(object sender, EventArgs e)
        {
            rm.Move();
        }

        private void bttnUPrr_Click(object sender, EventArgs e)
        {
            rr.Move();
        }

        private void bttnDOWNrl_Click(object sender, EventArgs e)
        {
            rl.MoveBack();
        }

        private void bttnDOWNrm_Click(object sender, EventArgs e)
        {
            rm.MoveBack();
        }

        private void bttnDOWNrr_Click(object sender, EventArgs e)
        {
            rr.MoveBack();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (!fs._switch)
            {
                try
                {
                    fs.SwitchToXTEA();
                    btnSwitch.Text = "XTEA";
                    txtBoxKey.Enabled = true;
                    this.bttnUPrr.Enabled = false;
                    this.bttnUPrm.Enabled = false;
                    this.bttnUPrl.Enabled = false;
                    this.bttnDOWNrr.Enabled = false;
                    this.bttnDOWNrm.Enabled = false;
                    this.bttnDOWNrl.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Couldn't turn on File Watcher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fs.SwitchToEnigma();
                btnSwitch.Text = "Enigma";
                txtBoxKey.Enabled = false;
                this.bttnUPrr.Enabled = true;
                this.bttnUPrm.Enabled = true;
                this.bttnUPrl.Enabled = true;
                this.bttnDOWNrr.Enabled = true;
                this.bttnDOWNrm.Enabled = true;
                this.bttnDOWNrl.Enabled = true;
            }
        }
        private void TurnOffEnigma(bool value)
        {
            this.bttnUPrr.Enabled = value;
            this.bttnUPrm.Enabled = value;
            this.bttnUPrl.Enabled = value;
            this.bttnDOWNrr.Enabled = value;
            this.bttnDOWNrm.Enabled = value;
            this.bttnDOWNrl.Enabled = value;

            this.bttnBrowseDestFolder.Enabled = value;
            this.bttnBrowseTargetFolder.Enabled = value;
            this.bttnSubmitDecode.Enabled = value;
            this.bttnSubmitEncode.Enabled = value;
            this.btnBrowseTargetDecoded.Enabled = value;
            this.btnBrowseToEncode.Enabled = value;
            this.btnSubmitDestFolder.Enabled = value;
            this.btnSubmitTargetFolder.Enabled = value;

        }
        private void btnBrowseToEncode_Click(object sender, EventArgs e)
        {
            this.ChooseFolder(this.txtBoxTargetEncode);
        }

        private void bttnSubmitEncode_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtBoxTargetEncode.Text))
            {
                if (!fs._switch)
                {
                    try
                    {
                        fs.EncodeFilesFromDirectory(txtBoxTargetEncode.Text, rr);
                        MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        
                        fs.EncodeAllFilesXTEA(txtBoxTargetEncode.Text, txtBoxKey.Text);
                        MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rr = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", lblRR, 'V');
            rm = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", lblRM, 'E');
            rl = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", lblRL, 'Q');
            reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');

            //J,Z

            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);
        }
    }
}
