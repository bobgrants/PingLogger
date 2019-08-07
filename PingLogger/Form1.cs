using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PingLogger
{
    public partial class Form1 : Form
    {

        PingClass pc = new PingClass();

        public bool logErrorOnly;

        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine("Test !! ");
            pc.Start();
            pc.InitializeTimer();
            pc.f1 = this;
            logErrorOnly = false;
        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputPathBox.Text = dialog.FileName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void ipAdressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartPingBtn_Click(object sender, EventArgs e)
        {
            pc.EnablePing();
        }

        private void errorOnlyRadioB_CheckedChanged(object sender, EventArgs e)
        {
            logErrorOnly = true;

        }

        private void allLogRadioB_CheckedChanged(object sender, EventArgs e)
        {
            logErrorOnly = false;

        }

        private void OutputText_TextChanged(object sender, EventArgs e)
        {
            OutputText.SelectionStart = OutputText.Text.Length;
            OutputText.ScrollToCaret();
        }
    }
}
