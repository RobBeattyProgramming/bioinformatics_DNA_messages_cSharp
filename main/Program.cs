string vibrioCholeraeSegment = "atcaatgatcaacgtaagcttctaagcatgatcaaggtgctcacacagtttatccacaacctgagtggatgacatcaagataggtcgttgtatctccttcctctcgtactctcatgaccacggaaagatgatcaagagaggatgatttcttggccatatcgcaatgaatacttgtgacttgtgcttccaattgacatcttcagcgccatattgcgctggccaaggtgacggagcgggattacgaaagcatgatcatggctgttgttctgtttatcttgttttgactgagacttgttaggatagacggtttttcatcactgactagccaaagccttactctgcctgacatcgaccgtaaattgataatgaatttacatgcttccgcgacgatttacctcttgatcatcgatccgattgaagatcttcaattgttaattctcttgcctcgactcatagccatgatgagctcttgatcatgtttccttaaccctctattttttacggaagaatgatcaagctgctgctcttgatcatcgtttc";
int dnaLength = vibrioCholeraeSegment.Length;

int count = 0;
int kmer = 9;

List<string> fullKmerList = new List<string>();


while (count < dnaLength - kmer + 1)
{
    //Console.WriteLine(vibrioCholeraeSegment.Substring(count, kmer));
    fullKmerList.Add(vibrioCholeraeSegment.Substring(count, kmer));

    count++;
}

int indexCount = (dnaLength / kmer);
int test = (dnaLength / kmer) + 30;
string[,] countedKmerList = new string[test, 2];


for (int i = 0; i < indexCount; i++)
{
    bool containsSegment = false; 

    for (int y = 0; y < indexCount; y++)
    {
        if (countedKmerList[y, 0] == fullKmerList[i])
        {
            containsSegment = true;
        }
    }

    if (containsSegment == false)
    {
        countedKmerList[i, 0] = fullKmerList[i];
    } 
}

//Test run
for(int z = 0; z < indexCount; z++)
{
    Console.WriteLine(countedKmerList[z, 0]);
}