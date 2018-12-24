using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task6.BackupSystem
{
    public class Program
    {
        private static string backupFolder = "BackupFiles";

        private static FileSystemWatcher watcher = new FileSystemWatcher();

        public static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath);
            }

            Thread.Sleep(1000);
        }

        public static void ChangeHandler(object source, FileSystemEventArgs e)
        {
            string id = DateTime.Now.ToString();
            for (int i = 0; i < id.Length; i++)
            {
                if (char.IsSeparator(id[i]) || id[i] == ':' || id[i] == '.')
                {
                    id = id.Remove(i, 1);
                }
            }

            DirectoryCopy(watcher.Path, $"BackupFiles\\{id}");
        }

        public static void Watcher()
        {
            Directory.CreateDirectory(backupFolder);

            Console.Write("Enter path: ");
            watcher.Path = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter("WatchingFolder.txt"))
            {
                sw.WriteLine(watcher.Path);
            }

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(ChangeHandler);
            watcher.Created += new FileSystemEventHandler(ChangeHandler);
            watcher.Deleted += new FileSystemEventHandler(ChangeHandler);
            watcher.Renamed += new RenamedEventHandler(ChangeHandler);

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        public static void Backuper()
        {
            Console.Write("Enter date and time of backup in format DD.MM.YYYY HH:MM:SS(example: 01.01.2001 11:11:11): ");
            string datime = DateReader();
            for (int i = 0; i < datime.Length; i++)
            {
                if (char.IsSeparator(datime[i]) || datime[i] == ':' || datime[i] == '.')
                {
                    datime = datime.Remove(i, 1);
                }
            }

            DirectoryInfo dir = new DirectoryInfo(backupFolder);
            DirectoryInfo[] dirs = dir.GetDirectories();

            long backup_id = long.MaxValue;
            string backup_path = string.Empty;
            for (int i = 0; i < dirs.Length; i++)
            {
                if (long.Parse(dirs[i].Name) - long.Parse(datime) < backup_id && long.Parse(dirs[i].Name) - long.Parse(datime) >= 0)
                {
                    backup_id = long.Parse(dirs[i].Name) - long.Parse(datime);
                    backup_path = dirs[i].FullName;
                }
            }

            string mainPath;
            using (StreamReader sr = new StreamReader("WatchingFolder.txt"))
            {
                mainPath = sr.ReadLine();
            }

            dir = new DirectoryInfo(mainPath);
            dirs = dir.GetDirectories();
            if (dirs.Length != 0)
            {
                for (int i = 0; i < dirs.Length; i++)
                {
                    dirs[i].Delete(true);
                }
            }

            var files = dir.GetFiles();
            if (files.Length != 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    files[i].Delete();
                }
            }

            DirectoryCopy(backup_path, mainPath);
        }

        public static void Reseter()
        {
            if (Directory.Exists(backupFolder))
            {
                Directory.Delete(backupFolder, true);
            }

            if (File.Exists("WatchingFolder.txt"))
            {
                File.Delete("WatchingFolder.txt");
            }
        }

        public static string DateReader()
        {
            string inp_date = Console.ReadLine();
            DateTime temp = new DateTime();
            try
            {
                temp = DateTime.Parse(inp_date);
            }
            catch
            {
                Console.WriteLine("Wrond date&time format. Try again");
                DateReader();
            }

            return temp.ToString();
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Welcome to Backup System!{Environment.NewLine} If you want to start Backup mode - press B" +
                    $"{Environment.NewLine} If you want to start Watching mode - press W{Environment.NewLine} If you want to delete backup files" +
                    $"and previous path - press N");

                string input = Console.ReadLine().ToUpper();

                while (input != "B" && input != "W" && input != "N")
                {
                    Console.Write("Wrong input data. Enter B, W or N: ");
                    input = Console.ReadLine().ToUpper();
                }

                if (input == "B")
                {
                    Backuper();
                }
                else if (input == "W")
                {
                    Watcher();
                }
                else if (input == "N")
                {
                    Reseter();
                }
            }
            catch
            {
                Console.WriteLine("You have started backuping before watching or entered wrong path!");
            }

            Console.WriteLine("Press S to stop");
            while (Console.ReadLine().ToUpper() != "S")
            {                
            }
        }
    }
}
