using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_AGoldenCrown
{
    class AGoldenCrown
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** A Golden Crown ********************");
            Console.WriteLine("**** Program Starts *****");
            Statement oStmt = new Statement();
            const int MaxNumberOfAllies = 3;
            Random rnd = new Random();
            List<Kingdom> lstKingDom = new List<Kingdom>();
            while (true)
            {
                oStmt.GetStatement();
                if (oStmt.TypeOfStatement == 0)
                {
                    break;
                }
                else if (oStmt.TypeOfStatement == 1)
                {
                    //Who Is Ruler?
                    if (lstKingDom.Count >= MaxNumberOfAllies)
                    {
                        Console.WriteLine("King Shan");
                    }
                    else
                    {
                        Console.WriteLine("None");
                    }
                }
                else if (oStmt.TypeOfStatement == 2)
                {
                    //Who are the allies?
                    if (lstKingDom.Count >= MaxNumberOfAllies)
                    {
                        foreach (var x in lstKingDom)
                        {
                            Console.WriteLine(x.Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("None");
                        Console.WriteLine("Enter the kingdoms competing to be the ruler:");
                    }
                }
                else if (oStmt.TypeOfStatement == MaxNumberOfAllies)
                {
                    var oking = new Kingdom(oStmt.Input1);
                    if (!oking.IsValid)
                    {
                        Console.WriteLine("Incorrect Statement");
                        continue;
                    }
                    if (!oking.IsSecretMsgCorrect(oStmt.Input2))
                    {
                        continue;
                    }
                    lstKingDom.Add(oking);
                }
                else if (oStmt.TypeOfStatement == 4)
                {
                    foreach(var kingdom in oStmt.lst_Kindoms)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            var oking = new Kingdom(kingdom);
                            int r = rnd.Next(oStmt.lst_SeceretMsgs.Count);
                            if (!oking.IsValid)
                            {
                                Console.WriteLine("Incorrect Statement");
                                continue;
                            }
                            if (!oking.IsSecretMsgCorrect(oStmt.lst_SeceretMsgs[r]))
                            {
                                continue;
                            }
                            lstKingDom.Add(oking);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!!");
                }
            }
            oStmt.PrintResult(lstKingDom);
            Console.ReadKey();
        }
    }
}

