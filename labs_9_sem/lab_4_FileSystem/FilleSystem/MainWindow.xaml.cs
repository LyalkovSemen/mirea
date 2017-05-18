using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace FilleSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<int, List<string>> MaxFiles;
        public const int RecurLvl = 0;
        public const int HowDeepToScan = 15;

        public MainWindow()
        {
            InitializeComponent();
            MaxFiles = new Dictionary<int, List<string>>();
        }
       
        public void ProcessDir(string sourceDir, int recursionLvl)
        {
            if (recursionLvl <= HowDeepToScan)
            {
                // Process the list of files found in the directory. 
                string[] fileEntries = Directory.GetFiles(sourceDir);
                foreach (string fileName in fileEntries)
                {
                    TextBox.Text += fileName + "\r";
                }

                // Recurse into subdirectories of this directory.
                string[] subdirEntries = Directory.GetDirectories(sourceDir);
                foreach (string subdir in subdirEntries)
                    // Do not iterate through reparse points
                    if ((File.GetAttributes(subdir) &
                         FileAttributes.ReparsePoint) !=
                             FileAttributes.ReparsePoint)

                        ProcessDir(subdir, recursionLvl + 1);
            }
        }

        private void BtnOpenFolder_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var rezult = dialog.ShowDialog();
                if (rezult == System.Windows.Forms.DialogResult.OK)
                {
                    tbFolder.Text = dialog.SelectedPath;
                    ProcessDir(dialog.SelectedPath, RecurLvl);
                    TextBox.Text += TextBox.LineCount-1;
                }
                else
                    return;
            }
            
            
        }
    }
}
