using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputFiles = int.Parse(Console.ReadLine());
            var root = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberOfInputFiles; i++)
            {
                var input = Console.ReadLine();

                var regex = new Regex(@".+\\");
                var match = regex.Match(input).ToString();

                var rootName = match;
                
                    var inputArr = input.Split(new[] { '\\', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
           
                var fileNameAndSize = inputArr[inputArr.Length - 1];
                var fileNameAndSizeArr = fileNameAndSize
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var fileName = fileNameAndSizeArr[0];
                var fileSize = long.Parse(fileNameAndSizeArr[1]);

                var files = new Dictionary<string, long>();
                files[fileName] = fileSize;

                if (!root.ContainsKey(rootName))
                {
                    root[rootName] = files;
                }
                else
                {
                    foreach (var item in root)
                    {
                        if (item.Key == rootName)
                        {
                            item.Value[fileName] = fileSize;
                        }
                    }
                }
            }

            var searchedExtensionAndRoot = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var searchedExtension = searchedExtensionAndRoot[0];
            var searchedRoot = searchedExtensionAndRoot[2];

            var result = new Dictionary<string, long>();
            var unContains = true;
            foreach(var item in root)
            {
                foreach (var file in item.Value)
                {
                    var fileName = file.Key
                        .Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    var extension = fileName[fileName.Length - 1];

                    var rootArr = item.Key
                            .Split(new[] { '\\', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                    var mainRoot = rootArr[0];

                    if (extension == searchedExtension && mainRoot == searchedRoot)
                    {
                        if (!result.ContainsKey(file.Key))
                        {
                            result[file.Key] = file.Value;
                        }
                        
                        unContains = false;
                    }
                   
                }
            }
            foreach (var f in result.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
            {
                Console.WriteLine($"{f.Key} - {f.Value} KB");
            }

            if (unContains)
            {
                Console.WriteLine("No");
            }

        }
    }
}
