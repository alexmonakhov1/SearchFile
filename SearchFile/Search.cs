using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFile
{
    class Search
    {
        public int count;

        public List<string> Searching(string fullPath, string pattern, string searchText)
        {
            List<string> needFiles = new List<string>();

            try
            {
                string[] findFiles = Directory.GetFiles(fullPath, pattern, SearchOption.AllDirectories);

                foreach (var file in findFiles)
                {
                    ++count;

                    try
                    {
                        using (StreamReader sr = new StreamReader(file))
                        {
                            string line = sr.ReadToEnd();

                            if (line.Contains(searchText))
                                needFiles.Add(file);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return needFiles;
        }
    }
}
