using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace katelabb4
{
    class Searializator
    {
        string filepath;

        public Searializator(string filePath)
        {
            this.filepath = filePath;
        }

        public void Serialize(List<Item> Items)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Create))
                {
                    JsonSerializer.Serialize<List<Item>>(fs, Items, options);
                }
                MessageBox.Show("File saved");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
