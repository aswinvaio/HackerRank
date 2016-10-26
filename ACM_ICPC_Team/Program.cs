using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC_Team
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int nm = int.Parse(tokens_n[0]);
            int nt = int.Parse(tokens_n[1]);
            var bitArray = new BitArray[nm];
            for (int n = 0; n < nm; n++)
            {
                bitArray[n] = new BitArray(nt);

                string memberTopics = Console.ReadLine();
                for (int m = 0; m < nt; m++) bitArray[n].Set(m, memberTopics[m] == '1');
            }
            int maxTopics = 0;
            for (int i = 0; i < nm - 1; i++)
            {
                for (int j = i + 1; j < nm; j++)
                {
                    int numberOfTeamTopics = NoOfSetBits(new BitArray(nt).Or(bitArray[i]).Or(bitArray[j]));
                    if (numberOfTeamTopics > maxTopics) maxTopics = numberOfTeamTopics;
                }
            }
            int maxTeams = 0;
            for (int i = 0; i < nm - 1; i++)
            {
                for (int j = i + 1; j < nm; j++)
                {
                    int numberOfTeamTopics = NoOfSetBits(new BitArray(nt).Or(bitArray[i]).Or(bitArray[j]));
                    if (numberOfTeamTopics == maxTopics) maxTeams++;
                }
            }
            Console.WriteLine(maxTopics);
            Console.WriteLine(maxTeams);
        }

        static int NoOfSetBits(BitArray b)
        {
            int count = 0;
            for (int i = 0; i < b.Length; i++)
                if (b.Get(i))
                    count++;
            return count;
        }
    }
}
