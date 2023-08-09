using LogForU.Core.Exeptions;
using LogForU.Core.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.IO
{
    public class LogFile : ILogFile
    {
        private const string DefaultExtension = "txt";
        private static readonly string DefaultName = $"Log_{DateTime.Now:yyyy-MM-dd-HH-mm-ss}";
        private static readonly string DefaultPath = $"{Directory.GetCurrentDirectory()}";
        
        private string name;
        private string extension;
        private string path;

        private readonly StringBuilder content;

        public LogFile()
        {
            Name = DefaultName;
            Extension = DefaultExtension;
            Path = DefaultPath;

            content = new StringBuilder();
        }

        public LogFile(string name, string extension, string path)
            : this()
        {
            Name = name;
            Extension = extension;
            Path = path;

            content = new StringBuilder();
        }

        public string Name
        {
            get => name;
            //get => $"{name}_{DateTime.Now:yyyy-MM-dd-HH-mm-ss}"; // towa e drug na4in za slagane na data w imeto
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyFileNameExption();
                }

                name = value;
            }
        }

        public string Extension
        {
            get => extension;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyFileExtensionExption();
                }

                extension = value;
            }
        }

        public string Path
        {
            get => path;
            set
            {
                if (!Directory.Exists(value))
                {
                    throw new InvalidPathExeption();
                }

                path = value;
            }
        }

        public string FullPath
        => System.IO.Path.GetFullPath($"{Path}/{Name}.{Extension}");

        public string Content
            => content.ToString();

        public int Size
            => content.Length;

        public void WriteLine(string text)
            => content.AppendLine(text);
    }
}
