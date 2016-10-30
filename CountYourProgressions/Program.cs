using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourProgressions
{
    class Program
    {
        //WalmartLabs Codesprint(Algorithms)  Count Your Progressions
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            SubSequence sq = new SubSequence(num, n);
            sq.findSubSeqAP();
            Console.WriteLine(sq.getNumAP());
        }
    }

    class SubSequence
    {
        int[] Sequence;
        int[] SubSeq;
        int nSeq, nSub, seqBegin;
        int numofAps;
        public SubSequence(int[] Sequence, int nSeq)
        {
            this.Sequence = Sequence;
            this.SubSeq = new int[nSeq];
            this.nSeq = nSeq;
            this.nSub = 0;
            this.numofAps = 0;
            this.seqBegin = 0;
        }
        public SubSequence(int[] Sequence, int nSeq, int seqBegin, int[] SubSeq, int nSub)
        {
            this.Sequence = Sequence;
            this.SubSeq = SubSeq;
            this.nSeq = nSeq;
            this.nSub = nSub;
            this.numofAps = 0;
            this.seqBegin = seqBegin;
        }

        public void findSubSeqAP()
        {
            if (isAP(SubSeq, nSub))
            {
                numofAps++;
            }
            for (int i = seqBegin; i < nSeq; i++)
            {
                SubSeq[nSub] = Sequence[i];
                SubSequence sq = new SubSequence(Sequence, nSeq, i + 1, SubSeq, nSub + 1);
                sq.findSubSeqAP();
                numofAps += sq.getNumAP();
            }
        }

        public int getNumAP()
        {
            return numofAps;
        }
        bool isAP(int[] a, int n)
        {
            bool isseqAP = true;
            int d = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0) d = a[1] - a[0];
                else if ((a[i + 1] - a[i]) != d)
                {
                    isseqAP = false;
                    break;
                }
            }
            return isseqAP;
        }
    }
}
