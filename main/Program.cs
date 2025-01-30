using System;


class Program {

    static void Main(string[] args)
    {
        Console.Clear();

        string vibrioCholeraeSegment = "atcaatgatcaacgtaagcttctaagcatgatcaaggtgctcacacagtttatccacaacctgagtggatgacatcaagataggtcgttgtatctccttcctctcgtactctcatgaccacggaaagatgatcaagagaggatgatttcttggccatatcgcaatgaatacttgtgacttgtgcttccaattgacatcttcagcgccatattgcgctggccaaggtgacggagcgggattacgaaagcatgatcatggctgttgttctgtttatcttgttttgactgagacttgttaggatagacggtttttcatcactgactagccaaagccttactctgcctgacatcgaccgtaaattgataatgaatttacatgcttccgcgacgatttacctcttgatcatcgatccgattgaagatcttcaattgttaattctcttgcctcgactcatagccatgatgagctcttgatcatgtttccttaaccctctattttttacggaagaatgatcaagctgctgctcttgatcatcgtttc";
        int kmer = 9;
        
        //creates list of segments from dna with length of kmer, iterating over the dna in groups of nine
        int segmentAmount = vibrioCholeraeSegment.Length - kmer - 1;
        List<string> segmentList = new List<string>();

        for (int x = 0; x < segmentAmount; x++)
        {
            
            string segment = "";
            for (int y = x; y < x + 9; y++ )
            {
                segment = segment + vibrioCholeraeSegment[y].ToString();
            }
            segmentList.Add(segment);
        }
        
        //iterates through segmentList and counts how many times that segments repeat
        var countedSegmentList = new List<Tuple<string,int>>();
        int z = 0;
        foreach (string dnaSegment in segmentList)
        {
            countedSegmentList.Add(new Tuple<string, int>(dnaSegment, z));
        }

    }
}



