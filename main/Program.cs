string vibrioCholeraeSegment = "atcaatgatcaacgtaagcttctaagcatgatcaaggtgctcacacagtttatccacaacctgagtggatgacatcaagataggtcgttgtatctccttcctctcgtactctcatgaccacggaaagatgatcaagagaggatgatttcttggccatatcgcaatgaatacttgtgacttgtgcttccaattgacatcttcagcgccatattgcgctggccaaggtgacggagcgggattacgaaagcatgatcatggctgttgttctgtttatcttgttttgactgagacttgttaggatagacggtttttcatcactgactagccaaagccttactctgcctgacatcgaccgtaaattgataatgaatttacatgcttccgcgacgatttacctcttgatcatcgatccgattgaagatcttcaattgttaattctcttgcctcgactcatagccatgatgagctcttgatcatgtttccttaaccctctattttttacggaagaatgatcaagctgctgctcttgatcatcgtttc";
int dnaLength = vibrioCholeraeSegment.Length;

int count = 0;
int kmer = 9;

List<string> fullKmerList = new List<string>();


while (count < dnaLength - kmer + 1)
{
    fullKmerList.Add(vibrioCholeraeSegment.Substring(count, kmer));

    count++;
}


string[,] countedKmerList = new string[count, 2];

for (int countedListLocation = 0; countedListLocation < count; countedListLocation++)
{
    bool doesntContainKmer = true;
    int repetitionCount = 0;

    //checks for repeitiion
    for (int fullListSegment = 0; fullListSegment < count; fullListSegment++)
    {
        if (countedKmerList[countedListLocation, 0] == fullKmerList[fullListSegment])
        {
            doesntContainKmer = false;
        }
    }

    //if not already in list, kmer is iterated through full list to count how many times it is repeated
    if (doesntContainKmer == true) 
    {
        foreach(string segment in fullKmerList)
        {
            if (segment == countedKmerList[countedListLocation, 0])
            {
                Console.WriteLine("yipee!");
            }
        }
        
        countedKmerList[countedListLocation, 0] = fullKmerList[countedListLocation];
        countedKmerList[countedListLocation, 1] = repetitionCount.ToString();
    }
}


//Test run
for(int z = 0; z < count; z++)
{
    Console.WriteLine(countedKmerList[z, 0]);
    Console.WriteLine(countedKmerList[z, 1]);
} 




