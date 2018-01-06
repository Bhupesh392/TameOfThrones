using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_AGoldenCrown
{
    class Statement
    {
        public int TypeOfStatement { get; set; }
        public string Input1 { get; set; }
        public string Input2 { get; set; }

        private int counter = 0;
        public List<string> lst_Kindoms { get; set; }

        public List<string> lst_SeceretMsgs { get; set; }
        internal void GetStatement()
        {
            string str = Console.ReadLine();
            str = str.ToUpper();
            Input1 = str;
            TypeOfStatement = -1;
            if (string.IsNullOrWhiteSpace(str))
            {
                TypeOfStatement = 0;
            }
            else if (str.Contains("ALLIES OF"))
            {
                TypeOfStatement = 2;
            }
            else if (str.Contains("RULER"))
            {
                TypeOfStatement = 1;
            }
            else if (str.Contains(","))
            {
                TypeOfStatement = 3;
                string[] str_arr = str.Split(',');
                Input1 = str_arr[0];
                Input2 = str_arr[1];
            }
            else if (str.Contains("LAND") || str.Contains("WATER") || str.Contains("ICE") || str.Contains("AIR") || str.Contains("FIRE") || str.Contains("SPACE"))
            {
                string[] str_arr = str.Split(' ');
                lst_Kindoms = new List<string>();
                foreach(var Kindom in str_arr)
                {
                    lst_Kindoms.Add(str_arr[counter]);
                    counter++;
                }
                FillSecretMsgsLst();
                TypeOfStatement = 4;
            }
        }

        private void FillSecretMsgsLst()
        {
            lst_SeceretMsgs = new List<string>();
            lst_SeceretMsgs.Add("Summer is coming");
            lst_SeceretMsgs.Add("a1d22n333a4444p");
            lst_SeceretMsgs.Add("oaaawaala");
            lst_SeceretMsgs.Add("zmzmzmzaztzozh");
            lst_SeceretMsgs.Add("Go, risk it all");
            lst_SeceretMsgs.Add("Let's swing the sword together");
            lst_SeceretMsgs.Add("Die or play the tame of thrones");
            lst_SeceretMsgs.Add("Ahoy! Fight for me with men and money");
            lst_SeceretMsgs.Add("Drag on Martin!");
            lst_SeceretMsgs.Add("When you play the tame of thrones, you win or you die.");
            lst_SeceretMsgs.Add("What could we say to the Lord of Death? Game on?");
            lst_SeceretMsgs.Add("Turn us away, and we will burn you first");
            lst_SeceretMsgs.Add("Death is so terribly final, while life is full of possibilities.");
            lst_SeceretMsgs.Add("You Win or You Die");
            lst_SeceretMsgs.Add("His watch is Ended");
            lst_SeceretMsgs.Add("Sphinx of black quartz, judge my dozen vows");
            lst_SeceretMsgs.Add("Fear cuts deeper than swords, My Lord.");
            lst_SeceretMsgs.Add("Different roads sometimes lead to the same castle.");
            lst_SeceretMsgs.Add("A DRAGON IS NOT A SLAVE.");
            lst_SeceretMsgs.Add("Do not waste paper");
            lst_SeceretMsgs.Add("Go ring all the bells");
            lst_SeceretMsgs.Add("Crazy Fredrick bought many very exquisite pearl, emerald and diamond jewels.");
            lst_SeceretMsgs.Add("The quick brown fox jumps over a lazy dog multiple times.");
            lst_SeceretMsgs.Add("We promptly judged antique ivory buckles for the next prize.");
            lst_SeceretMsgs.Add("Walar Morghulis: All men must die.");
        }

        internal void PrintResult(List<Kingdom> lstKingDom)
        {
            Console.WriteLine("Results after round one ballot count");
            foreach(var kingdom in lst_Kindoms)
            {
                int count = lstKingDom.Count(x => x.Name == kingdom);
                Console.WriteLine("Allies for {0} : {1} ", kingdom, count);
            }
        }
    }
}
