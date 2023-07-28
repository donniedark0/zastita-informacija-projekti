using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17248_Darko_Milicevic_prvi_domaci
{
    class FileSystem
    {
        private FileSystemWatcher _watcher;
        private bool _watcherTrigger;
        private string _targetDirectory;
        private string _destDirectory;
        public Rotor rr;
        public string key;
        public bool _switch;
        public bool _cbcswitch;


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
            _switch = false;
            _targetDirectory = "";
            _destDirectory = "";
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);

            if (_destDirectory.Length != 0)
            {
                if (!_switch)
                    EncodeTextFile(e.FullPath, this.rr);
               else
                    EncodeXTEA(e.FullPath, this.key);
            }
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

        public void SwitchToXTEA()
        {
            if (!_switch)
                _switch = true;
        }

        public void SwitchToEnigma()
        {
            if (_switch)
                _switch = false;
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


            foreach (string txtFile in Directory.GetFiles(path, "*.txt"))
                this.EncodeTextFile(txtFile, rr);
        }

        private bool EncodeTextFile(string fileName, Rotor rr)
        {
            string outputFile = _destDirectory + @"\" + Path.GetFileName(fileName);

            char[] txtForEncoding = this.GetFileContent(fileName);

            char[] encodedText = new char[txtForEncoding.Length];
            for (int i = 0; i < txtForEncoding.Length; i++)
            {
                if ((txtForEncoding[i] >= 65 && txtForEncoding[i] <= 90) || (txtForEncoding[i] >= 97 && txtForEncoding[i] <= 122))
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
                if ((txtForEncoding[i] >= 65 && txtForEncoding[i] <= 90) || (txtForEncoding[i] >= 97 && txtForEncoding[i] <= 122))
                {
                    rr.Move();
                    rr.PutDataIn(txtForEncoding[i]);
                    encodedText[i] = rr.GetDataOut();
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

        /*****************       XTEA      *****************/

        public void EncodeAllFilesXTEA(string path, string key)
        {
            if (this._destDirectory.Length == 0)
                throw new Exception("Please choose your destination folder!");

            foreach (string txtFile in Directory.GetFiles(path, "*.txt"))
                this.EncodeXTEA(txtFile, key);
        }

        public void EncodeXTEA(string fileName, string key/*, string iv*/)
        {
            //byte[] vector = Encoding.ASCII.GetBytes(iv);

            string outputFile = _destDirectory + @"\" + Path.GetFileName(fileName);
            char[] txtFromFile = this.GetFileContent(fileName);

            var sb = new StringBuilder();
            for (int i = 0; i < txtFromFile.Length; i++)
            {
                sb.Append(txtFromFile[i]);
            }
            char[] txtForCBC = new char[txtFromFile.Length / 3];

            /*if (_cbcswitch)
            {
                for(int i = 0; i<txtFromFile.Length; i = i + txtFromFile.Length/3)
                {
                    for(int j = 0; j<txtFromFile.Length / 3; j++)
                    {
                        txtForCBC[j] = txtFromFile[j];
                    }


                }

            }*/
            UInt32[] formattedKey = FormatKey(key);
            if ((txtFromFile.Length % 8) != 0)
                for (int i = 0; i <= ((8 - txtFromFile.Length % 8) - 1); i++)
                    sb.Append('0');
            string txtForEncoding = sb.ToString();
            Byte[] dataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(txtForEncoding);
            string cipher = string.Empty;
            UInt32[] tempData = new UInt32[2];
            Byte[] fourBytes = new Byte[4];

            for (int i = 0; i <= (txtForEncoding.Length - 1); i += 8)
            {
                for (int j = 0; j <= 3; j++)
                    fourBytes[j] = dataBytes[i + j];
                tempData[0] = BitConverter.ToUInt32(fourBytes, 0);

                for(int j = 0; j<=3; j++)
                    fourBytes[j] = dataBytes[i + 4 + j];
                tempData[1] = BitConverter.ToUInt32(fourBytes, 0);

                XTEAalg alg = new XTEAalg();
                alg.Code(tempData, formattedKey);

                cipher += UintToString(tempData[0]) + UintToString(tempData[1]);
            }

            var crc = new CRC();
            UInt32 hashedText = crc.ComputeChecksum(dataBytes);

            string finalText = hashedText + cipher;

            this.WriteInFile(outputFile, finalText.ToCharArray());
        }


        public bool DecodeXTEA(string path, string key)
        {
            if (this._destDirectory.Length == 0)
                throw new Exception("Please choose your destination folder!");

            string outputFile = _destDirectory + @"\" + Path.GetFileName(path);

            char[] txtFromFile = this.GetFileContent(path);

            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();
            for (int i = 0; i < txtFromFile.Length; i++)
            {
                
                if(i<10)
                    sb1.Append(txtFromFile[i]);
                else
                    sb2.Append(txtFromFile[i]);

            }

            string hashedTxtForDecoding = sb1.ToString();
            UInt32 hashedText = UInt32.Parse(hashedTxtForDecoding.Substring(0, 10));

            string txtForDecoding = sb2.ToString();


            UInt32[] formattedKey = FormatKey(key);
            int x = 0;
            Byte[] dataBytes = new Byte[txtForDecoding.Length];

            UInt32[] tempData = new UInt32[2];
            XTEAalg alg = new XTEAalg();
            

            for (int i =0; i <= txtForDecoding.Length - 1; i += 8)
            {
                tempData[0] = StringToUInt(txtForDecoding.Substring(i, 4));
                tempData[1] = StringToUInt(txtForDecoding.Substring(i + 4, 4));
                alg.Decode(tempData, formattedKey);
                for (int j = 0; j <= 3; j++)
                {
                    dataBytes[x] = BitConverter.GetBytes(tempData[0])[j];
                    x++;
                }
                for (int j = 0; j <= 3; j++)
                {
                    dataBytes[x] = BitConverter.GetBytes(tempData[1])[j];
                    x++;
                }
            }

            string decipheredString = System.Text.ASCIIEncoding.ASCII.GetString(dataBytes, 0, txtForDecoding.Length);

            char[] decipheredChars;
            int cutPoint = decipheredString.Length - 1;
            decipheredChars = decipheredString.ToCharArray();

            while (decipheredChars[cutPoint] == ' ')
                cutPoint--;
            decipheredString = decipheredString.Substring(0, cutPoint + 1);
            var crc = new CRC();
            uint hashedTextCheck = crc.ComputeChecksum(dataBytes);

            bool equal = true;
            System.Diagnostics.Trace.WriteLine(hashedTextCheck);
            if (hashedText != hashedTextCheck)
                equal = false;
            this.WriteInFile(outputFile, decipheredString.ToCharArray());
            return equal;
        }

        public string UintToString(UInt32 txt)
        {
            Byte[] byteArray;
            byteArray = BitConverter.GetBytes(txt);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i <= 3; i++)
                output.Append(Convert.ToChar(byteArray[i]));
            return output.ToString();
        }


        public UInt32 StringToUInt(string txt)
        {
            if(txt.Length != 4)
                throw new Exception("String length must be 4 in order to be converted!");

            Byte[] byteArray = new byte[4];
            char[] inputArray;
            UInt32 output;
            inputArray = txt.ToCharArray();

            for (int i = 0; i <= 3; i++)
                byteArray[i] = Convert.ToByte(inputArray[i]);

            output = BitConverter.ToUInt32(byteArray, 0);
            return output;
        }

        public UInt32[] FormatKey(string key)
        {
            if (key.Length <= 0 || key.Length > 16)
                throw new ArgumentException("Key must be between 1 and 16 charachters");

            key = key.PadRight(16).Substring(0, 16);
            UInt32[] formattedKey = new UInt32[4];
            int j = 0;
            for(int i = 0; i <= key.Length - 1; i+=4)
            {
                formattedKey[j] = StringToUInt(key.Substring(i, 4));
                j++;
            }

            return formattedKey;
        }

        
    }
}
