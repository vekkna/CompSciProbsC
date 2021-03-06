using System;
using System.Collections.Generic;

namespace CompSciProbsC
{
    public class Gene
    {
        public enum Nucleotide
        {
            A,
            C,
            G,
            T
        }
        
        public readonly List<Codon> Codons = new List<Codon>();

        public Gene(string geneStr)
        {
            for (int i = 0; i < geneStr.Length - 3; i += 3)
            {
                Codons.Add(new Codon(geneStr.Substring(i, i + 3)));
            }
            Codons.Sort();
        }

        public bool Search(Codon codon)
        {
            int mid = Codons.Count / 2;
            return false;
        }
    }

    public class Codon: IComparable
    {
        public readonly Gene.Nucleotide First, Second, Third;

        public Codon(string gene)
        {
            First = Enum.Parse<Gene.Nucleotide>(gene.Substring(0, 1));
            Second = Enum.Parse<Gene.Nucleotide>(gene.Substring(1, 2));
            Third = Enum.Parse<Gene.Nucleotide>(gene.Substring(2, 3));
        }

        private int CompareNucleotide(Gene.Nucleotide first, Gene.Nucleotide second)
        {
            if (first < second) return -1;
            if (first > second) return 1;
            return 0;
        }

        public int CompareTo(object? other)
        {
            if (other is not Codon)
            {
                throw new ArgumentException();
            }
            other = (Codon) other;

            if (First < other.First)
            {
                return -1;
            }

            if (First > other.First)
            {
                return 1;
            }
            else
            {
                if (Second < other.Second)
                {
                    return -1;
                }

                if (Second > other.Second)
                {
                    return 1;
                }
                else
                {
                    if (Third < other.Third)
                    {
                        return -1;
                    }

                    if (Third > other.Third)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}