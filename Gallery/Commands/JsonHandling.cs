using Gallery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gallery.Commands
{
    public static class JsonHandling
    {
        public static string p = "";
        public static List<Galery> paths = new();
        public static void WriteData<T>(T? list, string filename)
        {
            JsonSerializerOptions op = new();
            op.WriteIndented = true;

            File.WriteAllText(p + filename + ".json", JsonSerializer.Serialize(list, op));
        }

        public static void ReadData<T>(string filename) where T : new()
        {
            T? readData = new T();

            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;
            using FileStream fs = new FileStream(p + filename + ".json", FileMode.OpenOrCreate);
            if (fs.Length != 0) readData = JsonSerializer.Deserialize<T>(fs, op);

            paths = readData as List<Galery>;
        }
    }
}
