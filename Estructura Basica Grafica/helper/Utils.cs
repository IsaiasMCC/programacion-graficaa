using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace Estructura_Basica_Grafica.negocio
{
    class Utils
    {
        public static void Save<T>(T objeto, string path)
        {

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };
            try
            {
                string fileName = path;
                string fileJson = JsonConvert.SerializeObject(objeto, settings);
                TextWriter file = new StreamWriter($"{fileName}");
                file.Write(fileJson);
                file.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static T Open<T>(string path)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };
            try
            {
                T objeto = default(T);
                TextReader readFile = new StreamReader($"{path}");
                string s = readFile.ReadToEnd();
                objeto = JsonConvert.DeserializeObject<T>(s, settings);
                Console.WriteLine(objeto);
                readFile.Close();
                return objeto;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
