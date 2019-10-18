using System;
using System.Collections.Generic;
using System.IO;

namespace TeleprompterConsole
{
    class Code1
    {
        public void Run()
        {
            var lines = ReadFrom("sampleQuotes.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        private IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    foreach (var word in words)
                    {
                        yield return word + " ";
                    }
                    yield return Environment.NewLine;
                }
            }
        }
    }
}
