using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220105
{
    internal class Program
    {
        static Dictionary<string, List<Player>> teams = new Dictionary<string, List<Player>>();
        static void Main()
        {
            T01();
            Console.WriteLine("***********************************");
            T02();
            Console.WriteLine("***********************************");
            //T03();
            Console.WriteLine("***********************************");
            T04();
            Console.WriteLine("***********************************");
            //T05();
            Console.WriteLine("***********************************");
            //T06();
            Console.WriteLine("***********************************");
            //T07();
            Console.WriteLine("***********************************");
            //T08();
            Console.WriteLine("***********************************");
            //T09();
            Console.WriteLine("***********************************");
            //T10();
            Console.ReadKey(true);
        }

        private static void T01()
        {
            using (var sr = new StreamReader(
                path: @"..\..\res\NBA2003.csv",
                encoding: Encoding.UTF8))
            {
                int numberOfPplayers = int.Parse(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    var lineSlices = sr.ReadLine().Replace('\"', '\0').Split(';');

                    if (teams.ContainsKey(lineSlices[0]))
                    {
                        teams[lineSlices[0]].Add(new Player(lineSlices[1], lineSlices[2], lineSlices[3]));
                    }
                    else
                    {
                        teams.Add(
                            key: lineSlices[0],
                            value: new List<Player>()
                            {
                                new Player(lineSlices[1], lineSlices[2], lineSlices[3])
                            });
                    }
                }
            }
        }
        private static void T02()
        {
            foreach (var players in teams.Values)
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"{player.Name} - ${player.AnnualSalary * player.ContractPeriod}");
                }
            }
        }
        private static void T03()
        {
            throw new NotImplementedException();
        }
        private static void T04()
        {
            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Key} - ${team.Value.Sum(x => x.AnnualSalary)}");
            }
        }
        private static void T05()
        {
            throw new NotImplementedException();
        }
        private static void T06()
        {
            throw new NotImplementedException();
        }
        private static void T07()
        {
            throw new NotImplementedException();
        }
        private static void T08()
        {
            throw new NotImplementedException();
        }
        private static void T09()
        {
            throw new NotImplementedException();
        }
        private static void T10()
        {
            throw new NotImplementedException();
        }
    }
}
