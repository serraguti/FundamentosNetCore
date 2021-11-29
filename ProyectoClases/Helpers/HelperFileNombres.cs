using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFileNombres
    {
        //DESEAMOS LEER EL ARCHIVO NOMBRES1.TXT
        //SI LOS METODOS SON ASYNC, DEBEMOS DEVOLVER
        //Task<Tipo>
        public async Task<List<String>> ReadFileNombresAsync(String path)
        {
            FileInfo file = new FileInfo(path);
            String contenido = "";
            using (TextReader reader = file.OpenText())
            {
                contenido = await reader.ReadToEndAsync();
                reader.Close();
            }
            return this.GetNombres(contenido);
        }

        //SI ES UN void, SOLO SE ESCRIBE Task EN LOS async
        public async Task WriteFileNombresAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        private List<String> GetNombres(string data)
        {
            string[] nombres = data.Split(',');
            List<String> listanombres = new List<string>(nombres);
            return listanombres;
        }
    }
}
