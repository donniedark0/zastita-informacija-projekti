using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17248_Darko_Milicevic_prvi_domaci
{
    class FileSystem
    {
        private FileSystemWatcher _watcher;
        private bool _watcherTrigger;
        private string _targetDirectory;
        private string _destDirectory;
        public Rotor rr;


        public FileSystem()
        {
            _watcher = new FileSystemWatcher();

            _watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            _watcher.Changed += OnChanged;
            _watcher.Filter = "*.txt";
            _watcher.IncludeSubdirectories = true;
            _watcher.EnableRaisingEvents = false;

            _watcherTrigger = false;
            _targetDirectory = "";
            _destDirectory = "";
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);

            if (_destDirectory.Length != 0)
                EncodeTextFile(e.FullPath, this.rr);
            else
                Console.WriteLine("Output diretory isn't set!");
        }

        public bool IsWatcherOn()
        {
            return this._watcherTrigger;
        }

        public void TurnWatcherON()
        {
            if (string.IsNullOrEmpty(this._targetDirectory) || string.IsNullOrEmpty(this._destDirectory))
                throw new Exception("Please choose target and destination folders first.");
            else if (!_watcherTrigger)
            {
                _watcherTrigger = true;
                _watcher.EnableRaisingEvents = true;
            }
        }

        public void TurnWatcherOFF()
        {
            if (_watcherTrigger)
            {
                _watcherTrigger = false;
                _watcher.EnableRaisingEvents = false;
            }
        }

        public string GetTargetDirectory()
        {
            return this._targetDirectory;
        }

        public void SetTargetDirectory(string directory)
        {
            if (!_watcherTrigger)
                if (_destDirectory.Length == 0 || _destDirectory.CompareTo(directory) != 0)
                {
                    this._targetDirectory = directory;
                    _watcher.Path = directory;
                }
        }

        public string GetDestinationDirectory()
        {
            return this._destDirectory;
        }

        public void SetOutputDirectory(string dir)
        {
            if (!_watcherTrigger)
            {
                if (_targetDirectory.Length == 0 || _targetDirectory.CompareTo(dir) != 0)
                    this._destDirectory = dir;
            }
        }

        public void EncodeFilesFromDirectory(string path, Rotor rr)
        {
            if (this._destDirectory.Length == 0)
                throw new Exception("Please choose your destination folder!");
            System.Diagnostics.Trace.WriteLine(_destDirectory);


            foreach (string txtFile in Directory.GetFiles(path, "*.txt"))
                this.EncodeTextFile(txtFile, rr);
        }

        private bool EncodeTextFile(string fullFileName, Rotor rr)
        {
            string outputFile = _destDirectory + @"\" + Path.GetFileName(fullFileName);
            System.Diagnostics.Trace.WriteLine(outputFile);

            char[] txtForEncoding = this.GetFileContent(fullFileName);

            char[] encodedText = new char[txtForEncoding.Length];
            for (int i = 0; i < txtForEncoding.Length; i++)
            {
                if (txtForEncoding[i] >= 65 && txtForEncoding[i] <= 90)
                {
                    rr.Move();
                    rr.PutDataIn(txtForEncoding[i]);
                    encodedText[i] = rr.GetDataOut();

                    //System.Diagnostics.Trace.WriteLine();
                }
            }

            this.WriteInFile(outputFile, encodedText);
            return true;
        }

        public void DecodeFilesFromDirectory(string path, Rotor rr)
        {
            if (this._destDirectory.Length == 0)
                throw new Exception("Please choose your destination folder!");

                string outputFile = _destDirectory + @"\" + Path.GetFileName(path);

                char[] txtForEncoding = this.GetFileContent(path);

                char[] encodedText = new char[txtForEncoding.Length];
                for (int i = 0; i < txtForEncoding.Length; i++)
                {
                    if (txtForEncoding[i] >= 65 && txtForEncoding[i] <= 90)
                    {
                        rr.Move();
                        rr.PutDataIn(txtForEncoding[i]);
                        encodedText[i] = rr.GetDataOut();
                        //System.Diagnostics.Trace.WriteLine();
                    }
                }

                this.WriteInFile(outputFile, encodedText);
        }

        private char[] GetFileContent(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd().ToCharArray();
            }
        }

        private void WriteInFile(string path, char[] content)
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
