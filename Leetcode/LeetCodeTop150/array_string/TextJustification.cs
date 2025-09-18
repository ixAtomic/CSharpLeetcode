using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class TextJustification
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> lines = new List<string>();
        List<string> values = new List<string>();
        int currentLength = 0;
        int space = 0;
        foreach(string word in words)
        {
            currentLength += word.Length;
            space = maxWidth - currentLength;

            if(space < values.Count())
            {
                space += word.Length; //set the space back to what it was before element got added
                string line = GetLine(values, space, false);

                currentLength = word.Length;
                lines.Add(line);
                values = [word];
                space = maxWidth - currentLength;
                continue;
            }

            values.Add(word);
        }

        lines.Add(GetLine(values, space, true));

        return lines;
    }

    private string GetLine(List<string> values, int space, bool leftJustify)
    {
        double remainingSpaces = values.Count > 1 ? values.Count() - 1 : 1;
        string line = string.Empty;
        foreach (var value in values)
        {
            int padding = 0;
            if (space > 0)
            {
                padding = leftJustify ? 1 : Convert.ToInt32(Math.Ceiling(space / remainingSpaces));
                space -= padding;
                remainingSpaces--;
            }

            line += value;
            for (int p = 0; p < padding; p++)
            {
                line += ' ';
            }
        }

        for(int i = 0; i < space; i++)
        {
            line += ' ';
        }

        return line;
    }
}
