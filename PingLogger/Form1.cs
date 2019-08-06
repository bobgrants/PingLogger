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

        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine("Test !! ");
            pc.Start();
            pc.InitializeTimer();
            pc.f1 = this;

        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox2.Text = dialog.FileName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartPingBtn_Click(object sender, EventArgs e)
        {
            pc.EnablePing();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
