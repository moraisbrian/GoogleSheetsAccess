using System;
using Newtonsoft.Json;

namespace GoogleSheetsAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = WebService.GetData();

            foreach (var data in result)
            {
                Console.WriteLine("Titulo: {0} Conteudo: {1}", data.Title, data.Content);
            }
        }
    }
}
