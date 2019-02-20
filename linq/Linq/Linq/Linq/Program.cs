using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Linq
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string ruta = @"C:\windows";
            MostrarArchivosGrandesSinLinq(ruta);
            Console.WriteLine("***");
            MostrarArchivosGrandesConLinq(ruta);
            Console.ReadKey();
        }
        private static void MostrarArchivosGrandesConLinq(string ruta)
        {
            var consulta = new DirectoryInfo(ruta).GetFiles()
                            .OrderByDescending(f => f.Length)
                            .Take(5);

            foreach (var file in consulta)
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }
        private static void MostrarArchivosGrandesSinLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }
    }
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
