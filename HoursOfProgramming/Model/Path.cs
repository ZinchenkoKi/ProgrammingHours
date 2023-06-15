using System;
using System.IO;
using System.Windows.Forms;

namespace HoursOfProgramming.Model
{
    public class DataPath
    {
        public string GetPath()
        {
            string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "StopwatchData.txt";
            string appStorageFolder = Path.Combine(baseFolder, fileName);

            if (IsExistence(appStorageFolder))
            {
                return appStorageFolder;
            }
            else
            {
                Create(appStorageFolder, baseFolder);
                return appStorageFolder;
            }
        }

        private bool IsExistence(string appStorageFolder)
        {
            var fileInfo = new FileInfo(appStorageFolder);

            if (fileInfo.Exists)
            {
                return true;
            }
            return false;
        }

        private void Create(string appStorageFolder, string baseFolder)
        {
            using (FileStream file = File.Create(appStorageFolder)) { }
            MessageBox.Show($"В папке -> {baseFolder} был создан файл StopwatchData.txt");
        }
    }
}
