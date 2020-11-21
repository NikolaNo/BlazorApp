using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class GoatLatinBase : ComponentBase
    {
        public string showcode = "display:none";
        public void Show()
        {
            showcode = "display:flex";
        }

        public string s = "";
        public string res = "";
        public void ToGoatLatin()
        {

            ISet<char> vowels = new HashSet<char>() { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            var builders = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(w => new StringBuilder(w)).ToArray();

            int endCount = 1;
            foreach (var builder in builders)
            {
                if (vowels.Contains(builder[0]))
                {
                    builder.Append("ma");
                }
                else
                {
                    var first = builder[0];
                    builder.Remove(0, 1);
                    builder.Append(first);
                    builder.Append("ma");
                }

                builder.Append('a', endCount++);
            }

            res =  string.Join(" ", builders.Select(b => b.ToString()).ToArray());
        }
    }
}
