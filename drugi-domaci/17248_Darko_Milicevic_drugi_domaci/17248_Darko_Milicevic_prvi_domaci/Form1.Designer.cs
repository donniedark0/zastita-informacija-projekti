
namespace _17248_Darko_Milicevic_prvi_domaci
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnBrowseTargetFolder = new System.Windows.Forms.Button();
            this.bttnBrowseDestFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.lblDestFolder = new System.Windows.Forms.Label();
            this.btnSubmitTargetFolder = new System.Windows.Forms.Button();
            this.btnSubmitDestFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxTarget = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxDest = new System.Windows.Forms.TextBox();
            this.btnFileSystemWatcher = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxTargetEncode = new System.Windows.Forms.TextBox();
            this.bttnSubmitEncode = new System.Windows.Forms.Button();
            this.btnBrowseToEncode = new System.Windows.Forms.Button();
            this.txtBoxTargetDecode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bttnSubmitDecode = new System.Windows.Forms.Button();
            this.btnBrowseTargetDecoded = new System.Windows.Forms.Button();
            this.fbdBrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdBrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.bttnUPrl = new System.Windows.Forms.Button();
            this.bttnDOWNrl = new System.Windows.Forms.Button();
            this.bttnUPrm = new System.Windows.Forms.Button();
            this.bttnDOWNrm = new System.Windows.Forms.Button();
            this.bttnUPrr = new System.Windows.Forms.Button();
            this.bttnDOWNrr = new System.Windows.Forms.Button();
            this.lblRL = new System.Windows.Forms.Label();
            this.lblRM = new System.Windows.Forms.Label();
            this.lblRR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnBrowseTargetFolder
            // 
            this.bttnBrowseTargetFolder.Location = new System.Drawing.Point(29, 47);
            this.bttnBrowseTargetFolder.Name = "bttnBrowseTargetFolder";
            this.bttnBrowseTargetFolder.Size = new System.Drawing.Size(82, 37);
            this.bttnBrowseTargetFolder.TabIndex = 1;
            this.bttnBrowseTargetFolder.Text = "Browse";
            this.bttnBrowseTargetFolder.UseVisualStyleBackColor = true;
            this.bttnBrowseTargetFolder.Click += new System.EventHandler(this.bttnBrowseTargetFolder_Click);
            // 
            // bttnBrowseDestFolder
            // 
            this.bttnBrowseDestFolder.Location = new System.Drawing.Point(29, 44);
            this.bttnBrowseDestFolder.Name = "bttnBrowseDestFolder";
            this.bttnBrowseDestFolder.Size = new System.Drawing.Size(82, 37);
            this.bttnBrowseDestFolder.TabIndex = 2;
            this.bttnBrowseDestFolder.Text = "Browse";
            this.bttnBrowseDestFolder.UseVisualStyleBackColor = true;
            this.bttnBrowseDestFolder.Click += new System.EventHandler(this.bttnBrowseDestFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chosen target folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chosen destination folder:";
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(26, 137);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(138, 17);
            this.lblTargetFolder.TabIndex = 6;
            this.lblTargetFolder.Text = "--------------------------";
            // 
            // lblDestFolder
            // 
            this.lblDestFolder.AutoSize = true;
            this.lblDestFolder.Location = new System.Drawing.Point(26, 135);
            this.lblDestFolder.Name = "lblDestFolder";
            this.lblDestFolder.Size = new System.Drawing.Size(168, 17);
            this.lblDestFolder.TabIndex = 7;
            this.lblDestFolder.Text = "--------------------------------";
            // 
            // btnSubmitTargetFolder
            // 
            this.btnSubmitTargetFolder.Location = new System.Drawing.Point(283, 96);
            this.btnSubmitTargetFolder.Name = "btnSubmitTargetFolder";
            this.btnSubmitTargetFolder.Size = new System.Drawing.Size(81, 37);
            this.btnSubmitTargetFolder.TabIndex = 8;
            this.btnSubmitTargetFolder.Text = "Submit";
            this.btnSubmitTargetFolder.UseVisualStyleBackColor = true;
            this.btnSubmitTargetFolder.Click += new System.EventHandler(this.btnSubmitTargetFolder_Click);
            // 
            // btnSubmitDestFolder
            // 
            this.btnSubmitDestFolder.Location = new System.Drawing.Point(283, 94);
            this.btnSubmitDestFolder.Name = "btnSubmitDestFolder";
            this.btnSubmitDestFolder.Size = new System.Drawing.Size(81, 37);
            this.btnSubmitDestFolder.TabIndex = 9;
            this.btnSubmitDestFolder.Text = "Submit";
            this.btnSubmitDestFolder.UseVisualStyleBackColor = true;
            this.btnSubmitDestFolder.Click += new System.EventHandler(this.btnSubmitDestFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxTarget);
            this.groupBox1.Controls.Add(this.btnSubmitTargetFolder);
            this.groupBox1.Controls.Add(this.lblTargetFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bttnBrowseTargetFolder);
            this.groupBox1.Location = new System.Drawing.Point(28, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 166);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Folder";
            // 
            // txtBoxTarget
            // 
            this.txtBoxTarget.Location = new System.Drawing.Point(135, 54);
            this.txtBoxTarget.Name = "txtBoxTarget";
            this.txtBoxTarget.Size = new System.Drawing.Size(229, 22);
            this.txtBoxTarget.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxDest);
            this.groupBox2.Controls.Add(this.btnSubmitDestFolder);
            this.groupBox2.Controls.Add(this.lblDestFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bttnBrowseDestFolder);
            this.groupBox2.Location = new System.Drawing.Point(28, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Folder";
            // 
            // txtBoxDest
            // 
            this.txtBoxDest.Location = new System.Drawing.Point(135, 51);
            this.txtBoxDest.Name = "txtBoxDest";
            this.txtBoxDest.Size = new System.Drawing.Size(229, 22);
            this.txtBoxDest.TabIndex = 11;
            // 
            // btnFileSystemWatcher
            // 
            this.btnFileSystemWatcher.Location = new System.Drawing.Point(491, 19);
            this.btnFileSystemWatcher.Name = "btnFileSystemWatcher";
            this.btnFileSystemWatcher.Size = new System.Drawing.Size(205, 62);
            this.btnFileSystemWatcher.TabIndex = 12;
            this.btnFileSystemWatcher.Text = "Turn ON File System Watcher";
            this.btnFileSystemWatcher.UseVisualStyleBackColor = true;
            this.btnFileSystemWatcher.Click += new System.EventHandler(this.btnFileSystemWatcher_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxTargetEncode);
            this.groupBox3.Controls.Add(this.bttnSubmitEncode);
            this.groupBox3.Controls.Add(this.btnBrowseToEncode);
            this.groupBox3.Location = new System.Drawing.Point(789, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 166);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose a folder to encode:";
            // 
            // txtBoxTargetEncode
            // 
            this.txtBoxTargetEncode.Location = new System.Drawing.Point(135, 55);
            this.txtBoxTargetEncode.Name = "txtBoxTargetEncode";
            this.txtBoxTargetEncode.Size = new System.Drawing.Size(229, 22);
            this.txtBoxTargetEncode.TabIndex = 12;
            // 
            // bttnSubmitEncode
            // 
            this.bttnSubmitEncode.Location = new System.Drawing.Point(284, 96);
            this.bttnSubmitEncode.Name = "bttnSubmitEncode";
            this.bttnSubmitEncode.Size = new System.Drawing.Size(81, 34);
            this.bttnSubmitEncode.TabIndex = 10;
            this.bttnSubmitEncode.Text = "Submit";
            this.bttnSubmitEncode.UseVisualStyleBackColor = true;
            this.bttnSubmitEncode.Click += new System.EventHandler(this.bttnSubmitEncode_Click);
            // 
            // btnBrowseToEncode
            // 
            this.btnBrowseToEncode.Location = new System.Drawing.Point(21, 48);
            this.btnBrowseToEncode.Name = "btnBrowseToEncode";
            this.btnBrowseToEncode.Size = new System.Drawing.Size(82, 37);
            this.btnBrowseToEncode.TabIndex = 9;
            this.btnBrowseToEncode.Text = "Browse";
            this.btnBrowseToEncode.UseVisualStyleBackColor = true;
            this.btnBrowseToEncode.Click += new System.EventHandler(this.btnBrowseToEncode_Click);
            // 
            // txtBoxTargetDecode
            // 
            this.txtBoxTargetDecode.Location = new System.Drawing.Point(133, 55);
            this.txtBoxTargetDecode.Name = "txtBoxTargetDecode";
            this.txtBoxTargetDecode.Size = new System.Drawing.Size(229, 22);
            this.txtBoxTargetDecode.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxTargetDecode);
            this.groupBox4.Controls.Add(this.bttnSubmitDecode);
            this.groupBox4.Controls.Add(this.btnBrowseTargetDecoded);
            this.groupBox4.Location = new System.Drawing.Point(792, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 166);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose a file to decode:";
            // 
            // bttnSubmitDecode
            // 
            this.bttnSubmitDecode.Location = new System.Drawing.Point(281, 110);
            this.bttnSubmitDecode.Name = "bttnSubmitDecode";
            this.bttnSubmitDecode.Size = new System.Drawing.Size(81, 34);
            this.bttnSubmitDecode.TabIndex = 10;
            this.bttnSubmitDecode.Text = "Submit";
            this.bttnSubmitDecode.UseVisualStyleBackColor = true;
            this.bttnSubmitDecode.Click += new System.EventHandler(this.bttnSubmitDecode_Click);
            // 
            // btnBrowseTargetDecoded
            // 
            this.btnBrowseTargetDecoded.Location = new System.Drawing.Point(18, 47);
            this.btnBrowseTargetDecoded.Name = "btnBrowseTargetDecoded";
            this.btnBrowseTargetDecoded.Size = new System.Drawing.Size(82, 38);
            this.btnBrowseTargetDecoded.TabIndex = 9;
            this.btnBrowseTargetDecoded.Text = "Browse";
            this.btnBrowseTargetDecoded.UseVisualStyleBackColor = true;
            this.btnBrowseTargetDecoded.Click += new System.EventHandler(this.btnBrowseTargetDecoded_Click);
            // 
            // ofdBrowseFile
            // 
            this.ofdBrowseFile.FileName = "openFileDialog1";
            // 
            // bttnUPrl
            // 
            this.bttnUPrl.Location = new System.Drawing.Point(488, 238);
            this.bttnUPrl.Name = "bttnUPrl";
            this.bttnUPrl.Size = new System.Drawing.Size(54, 42);
            this.bttnUPrl.TabIndex = 15;
            this.bttnUPrl.Text = "↑";
            this.bttnUPrl.UseVisualStyleBackColor = true;
            this.bttnUPrl.Click += new System.EventHandler(this.bttnUPrl_Click);
            // 
            // bttnDOWNrl
            // 
            this.bttnDOWNrl.Location = new System.Drawing.Point(488, 360);
            this.bttnDOWNrl.Name = "bttnDOWNrl";
            this.bttnDOWNrl.Size = new System.Drawing.Size(54, 42);
            this.bttnDOWNrl.TabIndex = 16;
            this.bttnDOWNrl.Text = "↓";
            this.bttnDOWNrl.UseVisualStyleBackColor = true;
            this.bttnDOWNrl.Click += new System.EventHandler(this.bttnDOWNrl_Click);
            // 
            // bttnUPrm
            // 
            this.bttnUPrm.Location = new System.Drawing.Point(568, 238);
            this.bttnUPrm.Name = "bttnUPrm";
            this.bttnUPrm.Size = new System.Drawing.Size(52, 42);
            this.bttnUPrm.TabIndex = 17;
            this.bttnUPrm.Text = "↑";
            this.bttnUPrm.UseVisualStyleBackColor = true;
            this.bttnUPrm.Click += new System.EventHandler(this.bttnUPrm_Click);
            // 
            // bttnDOWNrm
            // 
            this.bttnDOWNrm.Location = new System.Drawing.Point(566, 360);
            this.bttnDOWNrm.Name = "bttnDOWNrm";
            this.bttnDOWNrm.Size = new System.Drawing.Size(54, 42);
            this.bttnDOWNrm.TabIndex = 18;
            this.bttnDOWNrm.Text = "↓";
            this.bttnDOWNrm.UseVisualStyleBackColor = true;
            this.bttnDOWNrm.Click += new System.EventHandler(this.bttnDOWNrm_Click);
            // 
            // bttnUPrr
            // 
            this.bttnUPrr.Location = new System.Drawing.Point(647, 238);
            this.bttnUPrr.Name = "bttnUPrr";
            this.bttnUPrr.Size = new System.Drawing.Size(54, 42);
            this.bttnUPrr.TabIndex = 19;
            this.bttnUPrr.Text = "↑";
            this.bttnUPrr.UseVisualStyleBackColor = true;
            this.bttnUPrr.Click += new System.EventHandler(this.bttnUPrr_Click);
            // 
            // bttnDOWNrr
            // 
            this.bttnDOWNrr.Location = new System.Drawing.Point(647, 360);
            this.bttnDOWNrr.Name = "bttnDOWNrr";
            this.bttnDOWNrr.Size = new System.Drawing.Size(54, 42);
            this.bttnDOWNrr.TabIndex = 20;
            this.bttnDOWNrr.Text = "↓";
            this.bttnDOWNrr.UseVisualStyleBackColor = true;
            this.bttnDOWNrr.Click += new System.EventHandler(this.bttnDOWNrr_Click);
            // 
            // lblRL
            // 
            this.lblRL.AutoSize = true;
            this.lblRL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRL.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold);
            this.lblRL.Location = new System.Drawing.Point(490, 298);
            this.lblRL.Name = "lblRL";
            this.lblRL.Size = new System.Drawing.Size(52, 48);
            this.lblRL.TabIndex = 21;
            this.lblRL.Text = "A";
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRM.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold);
            this.lblRM.Location = new System.Drawing.Point(568, 298);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(52, 48);
            this.lblRM.TabIndex = 22;
            this.lblRM.Text = "A";
            // 
            // lblRR
            // 
            this.lblRR.AutoSize = true;
            this.lblRR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRR.Font = new System.Drawing.Font("Georgia", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRR.Location = new System.Drawing.Point(646, 297);
            this.lblRR.Name = "lblRR";
            this.lblRR.Size = new System.Drawing.Size(55, 49);
            this.lblRR.TabIndex = 23;
            this.lblRR.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(474, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Use with upper case letters only!";
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(491, 120);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(205, 22);
            this.txtBoxKey.TabIndex = 24;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(491, 166);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(205, 50);
            this.btnSwitch.TabIndex = 25;
            this.btnSwitch.Text = "Enigma";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter a key for XTEA cipher:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.txtBoxKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRR);
            this.Controls.Add(this.lblRM);
            this.Controls.Add(this.lblRL);
            this.Controls.Add(this.bttnDOWNrr);
            this.Controls.Add(this.bttnUPrr);
            this.Controls.Add(this.bttnDOWNrm);
            this.Controls.Add(this.bttnUPrm);
            this.Controls.Add(this.bttnDOWNrl);
            this.Controls.Add(this.bttnUPrl);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFileSystemWatcher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnBrowseTargetFolder;
        private System.Windows.Forms.Button bttnBrowseDestFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.Label lblDestFolder;
        private System.Windows.Forms.Button btnSubmitTargetFolder;
        private System.Windows.Forms.Button btnSubmitDestFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFileSystemWatcher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttnSubmitEncode;
        private System.Windows.Forms.Button btnBrowseToEncode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseTargetDecoded;
        private System.Windows.Forms.TextBox txtBoxDest;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowseFolder;
        private System.Windows.Forms.TextBox txtBoxTargetEncode;
        private System.Windows.Forms.TextBox txtBoxTarget;
        private System.Windows.Forms.TextBox txtBoxTargetDecode;
        private System.Windows.Forms.OpenFileDialog ofdBrowseFile;
        private System.Windows.Forms.Button bttnUPrl;
        private System.Windows.Forms.Button bttnDOWNrl;
        private System.Windows.Forms.Button bttnUPrm;
        private System.Windows.Forms.Button bttnDOWNrm;
        private System.Windows.Forms.Button bttnUPrr;
        private System.Windows.Forms.Button bttnDOWNrr;
        private System.Windows.Forms.Label lblRL;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Label lblRR;
        private System.Windows.Forms.Button bttnSubmitDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label4;
    }
}

