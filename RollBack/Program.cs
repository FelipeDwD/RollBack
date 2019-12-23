using System;
using System.IO;

namespace RollBackFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directorySentDelete = new DirectoryInfo(@"C:\Users\FelipeN\Desktop\direct\source\sent");
            DirectoryInfo directoryDestinyRollback = new DirectoryInfo(@"C:\Users\FelipeN\Desktop\direct\destiny");
            string directorySource = @"C:\Users\FelipeN\Desktop\direct\source\";


            foreach (FileInfo file in directorySentDelete.GetFiles())
            {
                file.Delete();
            }

            foreach (FileInfo file in directoryDestinyRollback.GetFiles())
            {
                File.Move(file.FullName, directorySource + file.Name);
            }

            Console.WriteLine("Rollback executado com sucesso!" +
                "\nTodos os arquivos da pasta sent foram deletados!" +
                "\nTodos arquivos da pasta destiny retornou para a pasta source");

            Console.ReadKey();
        }
    }
}
