
namespace CompSciProbsC
{
    public class GeneCompressor
    {
        public bool[] CompressedGene { get; private set; }

        public GeneCompressor(string gene)
        {
            Compress(gene);
        }

        private void Compress(string gene)
        {
            CompressedGene = new bool[gene.Length * 2];
            string upperGene = gene.ToUpper();
            for (int i = 0; i < gene.Length; i++)
            {
                switch (upperGene[i])
                {
                    case 'A':
                        CompressedGene[i * 2] = false;
                        CompressedGene[i * 2 + 1] = false;
                        break;
                    case 'C':
                        CompressedGene[i * 2] = false;
                        CompressedGene[i * 2 + 1] = true;
                        break;
                    case 'G':
                        CompressedGene[i * 2] = true;
                        CompressedGene[i * 2 + 1] = false;
                        break;
                    case 'T':
                        CompressedGene[i * 2] = true;
                        CompressedGene[i * 2 + 1] = true;
                        break;
                }
            }
        }

        public string Decompress()
        {
            string result = "";
            for (int i = 0; i < CompressedGene.Length; i += 2)
            {
                switch ((CompressedGene[i], CompressedGene[i + 1]))
                {
                    case (false, false):
                        result += "A";
                        break;
                    case (false, true):
                        result += "C";
                        break;
                    case (true, false):
                        result += "G";
                        break;
                    case (true, true):
                        result += "T";
                        break;
                }
            }
            return result;
        }
    }
}