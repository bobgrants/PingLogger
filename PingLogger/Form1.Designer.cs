using System.Windows.Forms;

namespace PingLogger
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
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.SelectFolderBtn = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.ipAdressBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.outputPathBox = new System.Windows.Forms.TextBox();
            this.StartPingBtn = new System.Windows.Forms.Button();
            this.allLogRadioB = new System.Windows.Forms.RadioButton();
            this.errorOnlyRadioB = new System.Windows.Forms.RadioButton();
            this.OutputText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugInstructionsLabel.Location = new System.Drawing.Point(11, 61);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(142, 17);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Logfile output folder :";
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.Location = new System.Drawing.Point(452, 55);
            this.SelectFolderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(97, 28);
            this.SelectFolderBtn.TabIndex = 2;
            this.SelectFolderBtn.Text = "Select Folder...";
            this.SelectFolderBtn.UseVisualStyleBackColor = true;
            this.SelectFolderBtn.Click += new System.EventHandler(this.SelectFolderBtn_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(11, 21);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(137, 17);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Enter Ping address :";
            this.helloWorldLabel.Click += new System.EventHandler(this.helloWorldLabel_Click);
            // 
            // ipAdressBox
            // 
            this.ipAdressBox.Location = new System.Drawing.Point(153, 21);
            this.ipAdressBox.Name = "ipAdressBox";
            this.ipAdressBox.Size = new System.Drawing.Size(100, 20);
            this.ipAdressBox.TabIndex = 4;
            this.ipAdressBox.Text = "8.8.8.8";
            this.ipAdressBox.TextChanged += new System.EventHandler(this.ipAdressBox_TextChanged);
            // 
            // outputPathBox
            // 
            this.outputPathBox.Location = new System.Drawing.Point(158, 60);
            this.outputPathBox.Name = "outputPathBox";
            this.outputPathBox.Size = new System.Drawing.Size(275, 20);
            this.outputPathBox.TabIndex = 5;
            this.outputPathBox.Text = "d:\\";
            this.outputPathBox.TextChanged += new System.EventHandler(this.outputPathBox_TextChanged);
            // 
            // StartPingBtn
            // 
            this.StartPingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPingBtn.Location = new System.Drawing.Point(12, 281);
            this.StartPingBtn.Name = "StartPingBtn";
            this.StartPingBtn.Size = new System.Drawing.Size(133, 56);
            this.StartPingBtn.TabIndex = 6;
            this.StartPingBtn.Text = "Start ping";
            this.StartPingBtn.UseVisualStyleBackColor = true;
            this.StartPingBtn.Click += new System.EventHandler(this.StartPingBtn_Click);
            // 
            // allLogRadioB
            // 
            this.allLogRadioB.AutoSize = true;
            this.allLogRadioB.Location = new System.Drawing.Point(14, 127);
            this.allLogRadioB.Name = "allLogRadioB";
            this.allLogRadioB.Size = new System.Drawing.Size(96, 17);
            this.allLogRadioB.TabIndex = 7;
            this.allLogRadioB.TabStop = true;
            this.allLogRadioB.Text = "Log Everything";
            this.allLogRadioB.UseVisualStyleBackColor = true;
            this.allLogRadioB.CheckedChanged += new System.EventHandler(this.allLogRadioB_CheckedChanged);
            this.allLogRadioB.Checked = true;
            // 
            // errorOnlyRadioB
            // 
            this.errorOnlyRadioB.AutoSize = true;
            this.errorOnlyRadioB.Location = new System.Drawing.Point(14, 104);
            this.errorOnlyRadioB.Name = "errorOnlyRadioB";
            this.errorOnlyRadioB.Size = new System.Drawing.Size(95, 17);
            this.errorOnlyRadioB.TabIndex = 8;
            this.errorOnlyRadioB.TabStop = true;
            this.errorOnlyRadioB.Text = "Log Errors only";
            this.errorOnlyRadioB.UseVisualStyleBackColor = true;
            this.errorOnlyRadioB.CheckedChanged += new System.EventHandler(this.errorOnlyRadioB_CheckedChanged);
            // 
            // OutputText
            // 
            this.OutputText.DetectUrls = false;
            this.OutputText.Location = new System.Drawing.Point(158, 104);
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(401, 246);
            this.OutputText.TabIndex = 9;
            this.OutputText.Text = "";
            this.OutputText.TextChanged += new System.EventHandler(this.OutputText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 362);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.errorOnlyRadioB);
            this.Controls.Add(this.allLogRadioB);
            this.Controls.Add(this.StartPingBtn);
            this.Controls.Add(this.outputPathBox);
            this.Controls.Add(this.ipAdressBox);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.SelectFolderBtn);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PingLogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button SelectFolderBtn;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox ipAdressBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox outputPathBox;
        private System.Windows.Forms.Button StartPingBtn;
        private System.Windows.Forms.RadioButton allLogRadioB;
        private System.Windows.Forms.RadioButton errorOnlyRadioB;
        private RichTextBox OutputText;
    }
}

