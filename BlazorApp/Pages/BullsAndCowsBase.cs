using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class BullsAndCowsBase: ComponentBase
    {
        public string showcode = "display:none";
        public void Show()
        {
            showcode = "display:flex";
        }

        public string secret= "7325";

        public string guess="";

        public string res = "";

        public void GetHint()
        {
            int bull = 0, cow = 0;
            int[] setSecret = new int[10], listGuess = new int[10];
            for (int i = 0; i < secret.Length; i++)
                if (secret[i] == guess[i]) bull++;
                else
                {
                    setSecret[secret[i] - '0']++;
                    listGuess[guess[i] - '0']++;
                }
            for (int i = 0; i < 10; i++)
                while (listGuess[i]-- > 0 && setSecret[i]-- > 0)
                    cow++;
            res =  bull + " Bulls and " + cow + " Cows";
        }
    }
}
