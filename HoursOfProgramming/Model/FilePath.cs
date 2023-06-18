using HoursOfProgramming.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace HoursOfProgramming.Model
{
    /// <summary>
    /// Получает путь к файлу.
    /// </summary>
    public class FilePath : IFilePath
    {
        /// <summary>
        /// Получает путь к файлу из папки Документы.
        /// </summary>
        /// <returns> Путь к файлу </returns>
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

        /// <summary>
        /// Проверяе существование файла
        /// </summary>
        /// <param name="appStorageFolder"> Путь к файлу </param>
        /// <returns> Возвращает bool значение создан файл или нет </returns>
        private bool IsExistence(string appStorageFolder)
        {
            var fileInfo = new FileInfo(appStorageFolder);

            return fileInfo.Exists;
        }

        /// <summary>
        /// Создает файл
        /// </summary>
        /// <param name="appStorageFolder"></param>
        /// <param name="baseFolder"></param>
        private void Create(string appStorageFolder, string baseFolder)
        {
            using (FileStream file = File.Create(appStorageFolder)) { }
            MessageBox.Show($"В папке -> {baseFolder} был создан файл StopwatchData.txt");
        }
    }
}
