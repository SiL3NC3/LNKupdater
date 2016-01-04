using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNKupdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _directory = string.Empty;
        List<string> _fileList = new List<string>();
        string _strFind = string.Empty;
        string _strReplace = string.Empty;

        #region GUI METHODS
        public void LogToListBoxResult(string text)
        {
            listBoxResult.Items.Add(text);
            listBoxResult.TopIndex = listBoxResult.Items.Count - 1;
        }
        void DisableGui()
        {
            textBoxDirectory.Enabled = false;
            textBoxFilter.Enabled = false;
            textBoxFind.Enabled = false;
            textBoxReplace.Enabled = false;
            buttonDirectory.Enabled = false;
            buttonFind.Enabled = false;
            buttonDelete.Enabled = false;
            buttonReplace.Text = "STOP";
        }
        void EnableGui()
        {
            textBoxDirectory.Enabled = true;
            textBoxFilter.Enabled = true;
            textBoxFind.Enabled = true;
            textBoxReplace.Enabled = true;
            buttonDirectory.Enabled = true;
            buttonFind.Enabled = true;
            buttonDelete.Enabled = true;
            buttonReplace.Text = "Replace Targets";
        }
        bool FindReplaceEmpty()
        {
            if (textBoxFind.Text == string.Empty)
            {
                MessageBox.Show("'Find' string should be defined.");
                textBoxFind.Focus();
                return true;
            }
            if (textBoxReplace.Text == string.Empty)
            {
                MessageBox.Show("'Replace' string should be defined.");
                textBoxReplace.Focus();
                return true;
            }
            return false;
        }
        #endregion

        #region BUTTON EVENTS
        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindFiles();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteFiles();
        }
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            ReplaceFiles();
        }
        #endregion

        #region BUTTON METHODS
        void ChooseDirectory()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath != "")
                textBoxDirectory.Text = fbd.SelectedPath;
        }
        void FindFiles()
        {
            if (textBoxDirectory.Text == string.Empty)
            {
                MessageBox.Show("Please choose a directory or paste a path.");
                textBoxDirectory.Focus();
                return;
            }
            this.UseWaitCursor = true;
            _directory = textBoxDirectory.Text;
            listBoxFiles.DataSource = null;
            ReadFilesList();
            listBoxFiles.DataSource = _fileList;
            buttonDelete.Enabled = true;
            buttonReplace.Enabled = true;
            this.UseWaitCursor = false;
        }
        void DeleteFiles()
        {
            if (_fileList.Count != 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete all files in list (unrecoverable)??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (var path in _fileList)
                    {
                        File.Delete(path);
                    }
                }
            }
            else
            {
                MessageBox.Show("No files in FilesList.");
            }
        }
        void ReplaceFiles()
        {
            if (FindReplaceEmpty())
                return;

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation of replacing targetURLs of LNK filesList
                DisableGui();
                backgroundWorker1.RunWorkerAsync();
                LogToListBoxResult("Replacing TargetURLs in FilesList ...");
            }
            else
            {
                if (backgroundWorker1.WorkerSupportsCancellation == true)
                {
                    // Cancel the asynchronous operation.
                    EnableGui();
                    backgroundWorker1.CancelAsync();
                }
            }
        }
        #endregion

        #region WORKING METHODS
        void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        AddToFiles(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        void AddToFiles(string path)
        {
            string ext = Path.GetExtension(path);
            string fileName = Path.GetFileName(path);
            string filter = textBoxFilter.Text;
            if (ext == ".lnk")
            {
                if (fileName.Contains(filter))
                    this._fileList.Add(path);
            }

        }
        void ReadFilesList()
        {
            this._fileList.Clear();
            LogToListBoxResult("Reading files ...");
            string strFind = textBoxFind.Text;
            try
            {
                foreach (string f in Directory.GetFiles(this._directory))
                {
                    if (f.Contains(strFind))
                        AddToFiles(f);
                }
                if (checkBoxSubDirs.Checked)
                {
                    // Include sub-directories in "folder" path
                    DirSearch(this._directory);
                }
                LogToListBoxResult("... DONE! (" + _fileList.Count + " files found)");
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
                LogToListBoxResult("... ERROR: " + excpt.Message);
            }
        }
        string UpdateLnkTarget(string path, string strOld, string strNew)
        {
            Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
            dynamic shell = Activator.CreateInstance(t);
            try
            {
                if (File.Exists(path))
                {
                    var lnk = shell.CreateShortcut(path);
                    string targetNew = string.Empty;
                    try
                    {
                        string targetOld = lnk.TargetPath;
                        targetNew = targetOld.Replace(strOld, strNew);
                        lnk.TargetPath = targetNew;
                        lnk.Save();
                        return (string.Format(
                            "File '{0}' >>> TargetURL changed to: '{1}'.",
                            Path.GetFileName(path), targetNew
                            ));
                    }
                    finally
                    {
                        Marshal.FinalReleaseComObject(lnk);
                    }
                }
                return string.Empty;
            }
            finally
            {
                Marshal.FinalReleaseComObject(shell);
            }
        }
        #endregion

        #region BACKGROUND WORKER (LNK renaming process)
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string strOld = textBoxFind.Text;
            string strNew = textBoxReplace.Text;
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < _fileList.Count; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    string result = UpdateLnkTarget(_fileList[i], strOld, strNew);
                    worker.ReportProgress((i / _fileList.Count) * 100, result);
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
                LogToListBoxResult(e.UserState.ToString());
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                LogToListBoxResult("... canceled.");
                EnableGui();
            }
            else if (e.Error != null)
            {
                LogToListBoxResult("... completed with Error: " + e.Error.Message);
                EnableGui();
            }
            else
            {
                LogToListBoxResult("... DONE!");
                EnableGui();
            }
        }
        #endregion
    }
}
