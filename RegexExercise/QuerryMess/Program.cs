using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuerryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                var inp = Console.ReadLine();
                if (inp == "END")
                {
                    break;
                }

                var inputReg = Regex.Replace(inp, @"%20\+", " ");
                inputReg = Regex.Replace(inputReg, "%20", "");
                

                var regHttp = new Regex(@"http");

                if (!regHttp.IsMatch(inputReg))
                {
                    var data = new Dictionary<string, List<string>>();
                    var inputReg2 = Regex.Replace(inputReg, @"\+", "");

                    var regUnHttp = new Regex(@"[^=]http");

                    var inp2 = "";

                    if (regUnHttp.IsMatch(inputReg2))
                    {
                        var input2 = inputReg2.Split('h', 't', 't', 'p').ToList();
                        inp2 = input2[0];
                    }

                    var input = inp2.Split('&')
                    .ToArray();
                    
                    for (int i = 0; i < input.Length; i++)
                    {
                        var value = new List<string>();
                        var couple = new List<string>();

                        couple = input[i].Split('=').ToList();
                        
                        value.Add(couple[1]);

                        if (!data.ContainsKey(couple[0]))
                        {
                            data[couple[0]] = value;
                        }
                        else
                        {
                            data[couple[0]].AddRange(value);
                        }
                        
                    }
                    foreach (var item in data)
                    {
                        Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                    }

                }
                else
                {
                    var data = new Dictionary<string, List<string>>();
                    var inputt = inputReg.Split('?').ToArray();
                    var inp1 = inputt[1];
                    var inputReg2 = Regex.Replace(inp1, @"\+", "");

                    var input = inputReg2.Split('&')
                    .ToArray();

                    for (int i = 0; i < input.Length; i++)
                    {
                        var value = new List<string>();
                        var couple = new List<string>();

                        couple = input[i].Split('=').ToList();

                        value.Add(couple[1]);

                        if (!data.ContainsKey(couple[0]))
                        {
                            data[couple[0]] = value;
                        }
                        else
                        {
                            data[couple[0]].AddRange(value);
                        }

                    }
                    foreach (var item in data)
                    {
                        Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                    }

                }
                
            }
           
        }
    }
}
