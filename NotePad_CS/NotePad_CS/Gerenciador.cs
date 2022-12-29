using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad_CS
{
    public static class Gerenciador
    {
        //default values
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string DefaultFileName => "Arquivo";
        public static string DefaultFileExtension => ".txt.";

        //valores durante o uso
        public static string FolderPath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExtension { get; set; } = DefaultFileExtension;
        public static string FilePath => FolderPath + FileName + FileExtension;
    }
}
