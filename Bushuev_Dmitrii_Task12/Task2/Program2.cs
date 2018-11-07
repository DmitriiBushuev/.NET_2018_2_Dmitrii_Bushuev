using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program2
    {
        static FileSystemWatcher myFSW;
        //static bool stopRequested = false;
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        static string backupFolder;
        static string watchingFolder;

        static void Main(string[] args)
        {
            string backUpFoulderPath = @"C:\Users\Di Ma\Desktop\.NET_2018_2_Dmitrii_Bushuev\Bushuev_Dmitrii_Task12\myFolder_12_backup";
            backupFolder = backUpFoulderPath;// Path.Combine(Environment.CurrentDirectory, "myFolder_12_backup");
            if (!Directory.Exists(backupFolder))
            {
                var dirInfo = Directory.CreateDirectory(backupFolder);
                dirInfo.Attributes =  dirInfo.Attributes | FileAttributes.Hidden;
            }

            string FoulderPath = @"C:\Users\Di Ma\Desktop\.NET_2018_2_Dmitrii_Bushuev\Bushuev_Dmitrii_Task12\myFolder_12";
            watchingFolder = FoulderPath;// Path.Combine(Environment.CurrentDirectory, "myFolder_12");
            if (!Directory.Exists(watchingFolder))
            {
                Directory.CreateDirectory(watchingFolder);
            }

            Console.WriteLine("Выберите режим:\n" +
                "1. Наблюдение\n" +
                "2. Откат изменений");

            var myChoose = Console.ReadLine();

            int.TryParse((myChoose), out int theChoice);

            switch (theChoice)
            {
                case 1:
                    Console.WriteLine("Режим наблюдения изменений");
                    //Task.Factory.StartNew(Watching);
                    Watching();
                    Console.ReadKey();
                    //stopRequested = true;
                    //autoResetEvent.WaitOne();
                    return;

                case 2:
                    Console.WriteLine("Выберите дату для отката");
                    WatchBackUp();
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("Режим не выбран. Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }

        static void Watching()
        {
            DirectoryInfo dir = new DirectoryInfo(watchingFolder);

            // Получить все файлы с расширением .txt
            FileInfo[] txtFiles = dir.GetFiles("*.txt", SearchOption.AllDirectories);

            // Сколько файлов найдено
            Console.WriteLine($"Найдено {txtFiles.Length} txt файла(ов)");

            // Вывести информацию о каждом файле
            foreach (FileInfo f in txtFiles)
            {
                Console.WriteLine("\n******************\n");
                Console.WriteLine($"Имя файла: {f.Name}");
                Console.WriteLine($"Размер файла: { f.Length}");
                Console.WriteLine($"Время создания файла: { f.CreationTime}");
            }
            Console.WriteLine("Наблюдение изменнений активировано.");

            myFSW = new FileSystemWatcher(watchingFolder, "*.txt");
            myFSW.IncludeSubdirectories = true;

            myFSW.Changed +=fsw_Changed;
            myFSW.Renamed += new RenamedEventHandler(fsw_Changed);
            myFSW.Deleted += new FileSystemEventHandler(fsw_Changed);
            myFSW.Created += new FileSystemEventHandler(fsw_Changed);
            myFSW.EnableRaisingEvents = true;

            Console.WriteLine("Нажите любую клавишу для выхода.");
            //while (!stopRequested)
            //{
            //Task.Delay(5000);
            //}
            //myFSW.EnableRaisingEvents = false;
            //autoResetEvent.Set();
        }

        static void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                string changeType = "изменен";
                switch (e.ChangeType)
                {
                    case WatcherChangeTypes.Deleted:
                        changeType = "удален";
                        break;

                    case WatcherChangeTypes.Renamed:
                        changeType = "переименован";
                        break;

                    case WatcherChangeTypes.Created:
                        changeType = "создан";
                        break;
                }
                string destinationPath = Path.Combine(backupFolder, DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss"));
                CopyFolder(watchingFolder, destinationPath);
                Console.WriteLine($"Файл {e.FullPath} {changeType}!");
                myFSW.EnableRaisingEvents = false; //отключаем слежение
            }

            finally
            {
                myFSW.EnableRaisingEvents = true; //переподключаем слежение
            }
        }

        static void CopyFolder(string copyFrom, string copyTo)
        {
            //Создаем идентичную структуру папок
            foreach (string dirPath in Directory.GetDirectories(copyFrom, "*", SearchOption.AllDirectories))
            {
                try
                {
                    Directory.CreateDirectory(dirPath.Replace(copyFrom, copyTo));
                }
                catch (Exception e)
                {
 
                }
            }

            //Копировать все файлы и перезаписать файлы с идентичным именем
            foreach (string newPath in Directory.GetFiles(copyFrom, "*.*", SearchOption.AllDirectories))
            {
                try
                {
                    File.Copy(newPath, newPath.Replace(copyFrom, copyTo), true);
                }
                catch (Exception e)
                {

                }
            }
        }

        static void WatchBackUp()
        {
            string[] backupnames = Directory.GetDirectories(backupFolder, "*", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < backupnames.Length; i++)
            {
                Console.WriteLine($"{i+1}. {backupnames[i]}");
            }

            if (int.TryParse(Console.ReadLine(), out int choose) && choose-1 >= 0 && choose-1 < backupnames.Length)
            {
                new DirectoryInfo(watchingFolder).Delete(true);
                CopyFolder(backupnames[choose-1], watchingFolder);
                Console.WriteLine("BackUp восстановлен!");
            }
            else
            {
                Console.WriteLine("Некорректное значение!");
            }
        }
    }
}
