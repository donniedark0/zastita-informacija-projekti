using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _17248_dom1
{
    class FileSystem
    {
        private FileSystemWatcher watcher;
        private string watchedDirectory;
        private string outputDirectory;
        private bool isWatcherOn;
        private Random rnd;
        private string keyFile = @"./keys.txt";
        // private Dictionary<string, int> savedKeys;
       // private RailFence rf;

        public FileSystem()
        {
            
            watcher = new FileSystemWatcher();
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = false;
            isWatcherOn = false;
            watchedDirectory = "";
            outputDirectory = "";
            rnd = new Random();
           // savedKeys = new Dictionary<string, int>();


        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);

            if (outputDirectory.Length != 0)
                this.EncodeTextFile(e.FullPath, this.outputDirectory);
            else
                Console.WriteLine("Output diretory isn't set!");
        }

        public void SetWatchedDirectory(string directory)
        {
            if (!isWatcherOn)
                if (outputDirectory.Length == 0 || outputDirectory.CompareTo(directory) != 0)
                {
                    this.watchedDirectory = directory;
                    watcher.Path = directory;
                }

        }

      /*  public void SetNewKey(int key)
        {
            rf.SetKey(key);
        }*/
        public void SetOutputDirectory(string dir)
        {
            if (!isWatcherOn)
            {
                if (watchedDirectory.Length == 0 || watchedDirectory.CompareTo(dir) != 0)
                    this.outputDirectory = dir;
            }
        }

        public bool IsWatcherSystemOn()
        {
            return this.isWatcherOn;
        }

        public string GetTargetDirectory()
        {
            return this.watchedDirectory;
        }
        public string GetDestinationDirectory()
        {
            return this.outputDirectory;
        }

        public void TurnOnFileSystemWatcher()
        {
            if (this.watchedDirectory == "" || this.outputDirectory == "")
                throw new Exception("You need to specify target and destination folders before turning on File Watcher System!");
            if (!isWatcherOn)
            {
                isWatcherOn = true;
                watcher.EnableRaisingEvents = true;
            }
        }

        public void TurnOffFileSystemWatcher()
        {
            if (isWatcherOn)
            {
                isWatcherOn = false;
                watcher.EnableRaisingEvents = false;
            }
        }

        public void EncodeAllFilesFromDirectory(string path)
        {
            if (this.outputDirectory.Length == 0)
                throw new Exception("Destination folder not set!");
            foreach (string txtFile in Directory.GetFiles(path, "*.txt"))
                this.EncodeTextFile(txtFile, this.outputDirectory);
        }

        private bool EncodeTextFile(string fullFileName, string outputDirectory)
        {
            string outputFileName = outputDirectory + @"\" + Path.GetFileName(fullFileName);
            int key = GenerateKey();

           
                char[] textForCoding = this.ReadTextFile(fullFileName);
                char[] encodedText = RailFence.EncodeStream(textForCoding,key);
                this.WriteToTextFile(outputFileName, encodedText);
                this.WriteKeyToKeyFile(outputFileName, key);
                return true;
            
            

         }
        private void WriteKeyToKeyFile(string fileName,int key)
        {
            string entry = fileName + " " + key;
            using (StreamWriter sw = File.AppendText(this.keyFile))
            {
                sw.WriteLine(entry);
            }
        }

        public bool DecodeTextFile(string fullFileName, string targetFolder)
        {
            if (this.isWatcherOn) return false;
            string outputFileName = targetFolder + @"\" + Path.GetFileName(fullFileName);
           
            char[] codedText = this.ReadTextFile(fullFileName);
            int key = this.GetKey(fullFileName);
            if (key == -1) return false;
            char[] decodedText = RailFence.DecodeStream(codedText,key);
            this.WriteToTextFile(outputFileName, decodedText);

            return true;
           
        }

        public int GetKey(string fileName)
        {
            int key = -1;
            using (StreamReader sr = File.OpenText(this.keyFile))
            {
                string s = "";
               
                while ((s = sr.ReadLine()) != null)
                {
                    if(s.StartsWith(fileName))
                    {
                        int index = fileName.Length + 1;
                        key =int.Parse(s.Substring(index));
                        return key;
                    }
                }
            }
            return key;
        }

        private int GenerateKey()
        {
            return rnd.Next(3, 100);
        }

       /* public int GetKey(string path)
        {
            if (savedKeys.ContainsKey(path))
                return savedKeys[path];
            return 0;
        }*/

        private char[] ReadTextFile(string path)
        {

            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd().ToCharArray();
            }


        }

        private void WriteToTextFile(string path, char[] content)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(content);
                }

            }
            finally
            {
                if (fs != null)
                    fs.Dispose();

            }
        }



    }
}
