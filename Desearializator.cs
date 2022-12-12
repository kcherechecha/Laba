using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace katelabb4
{
    class Desearializator
    {
        string filepath;

        public Desearializator(string filepath)
        {
            this.filepath = filepath;
        }

        public List<Item> Deserealize()
        {
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Open))
                {
                    var items = JsonSerializer.Deserialize<List<Item>>(fs);
                    return items;
                }
            }
            catch
            {
                MessageBox.Show("Error");
                return null;
            }
        }
    }
}
