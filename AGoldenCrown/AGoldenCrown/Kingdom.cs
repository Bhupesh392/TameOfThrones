using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_AGoldenCrown
{
    class Kingdom
    {
        public string Name { get; set; }
        public bool IsAllies { get; set; }
        public Dictionary<char, int> MyKeys;
        public bool IsValid { get; set; }
        public Kingdom(string pName)
        {
            IsValid = true;
            IsAllies = false;
            Name = pName;
            MyKeys = new Dictionary<char, int>();
            pName = pName.ToUpper();
            if (pName == "LAND")
            {
                //Pandaa
                MyKeys.Add('P', 1);
                MyKeys.Add('A', 2);
                MyKeys.Add('N', 1);
                MyKeys.Add('D', 1);
            }
            else if (pName == "WATER")
            {
                //OCTOPUS
                MyKeys.Add('O', 2);
                MyKeys.Add('C', 1);
                MyKeys.Add('T', 1);
                MyKeys.Add('P', 1);
                MyKeys.Add('U', 1);
                MyKeys.Add('S', 1);
            }
            else if (pName == "ICE")
            {
                //MAMMOTH
                MyKeys.Add('M', 3);
                MyKeys.Add('A', 1);
                MyKeys.Add('O', 1);
                MyKeys.Add('T', 1);
                MyKeys.Add('H', 1);
            }
            else if (pName == "AIR")
            {
                //OWL
                MyKeys.Add('O', 1);
                MyKeys.Add('W', 1);
                MyKeys.Add('L', 1);
            }
            else if (pName == "FIRE")
            {
                //DRAGON
                MyKeys.Add('D', 1);
                MyKeys.Add('R', 1);
                MyKeys.Add('A', 1);
                MyKeys.Add('G', 1);
                MyKeys.Add('O', 1);
                MyKeys.Add('N', 1);
            }
            else if (pName == "SPACE")
            {
                //GORILLA
                MyKeys.Add('G', 1);
                MyKeys.Add('O', 1);
                MyKeys.Add('R', 1);
                MyKeys.Add('I', 1);
                MyKeys.Add('L', 2);
                MyKeys.Add('A', 1);
            }
            else
            {
                IsValid = false;
            }
        }
        public bool IsSecretMsgCorrect(string SecretMessage)
        {
            SecretMessage = SecretMessage.ToUpper();
            foreach (var k in MyKeys)
            {
                if (SecretMessage.Count(x => x == k.Key) < k.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
