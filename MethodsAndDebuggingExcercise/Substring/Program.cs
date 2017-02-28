using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        char search = 'p';
        bool hasMatch = false;
        int lastP = 0;

        for (int i = 0; i < text.Length; i++)
        {
            int endIndex = jump + 1;
            
            if (hasMatch && text[i] == search && (i + 1) - (lastP + 1) < jump)
            {
              continue;
            }

            if (text[i] == search)
            {
                hasMatch = true;
              
                if (endIndex > text.Length - i)
                {
                    endIndex = text.Length - i;
                }

                string matchedString = text.Substring(i, endIndex);

                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (hasMatch == false)
        {
            Console.WriteLine("no");
        }
    }
}


