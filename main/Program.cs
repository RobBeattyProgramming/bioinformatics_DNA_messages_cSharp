string vibrioCholeraeSegment = "atcaatgatcaacgtaagcttctaagcatgatcaaggtgctcacacagtttatccacaacctgagtggatgacatcaagataggtcgttgtatctccttcctctcgtactctcatgaccacggaaagatgatcaagagaggatgatttcttggccatatcgcaatgaatacttgtgacttgtgcttccaattgacatcttcagcgccatattgcgctggccaaggtgacggagcgggattacgaaagcatgatcatggctgttgttctgtttatcttgttttgactgagacttgttaggatagacggtttttcatcactgactagccaaagccttactctgcctgacatcgaccgtaaattgataatgaatttacatgcttccgcgacgatttacctcttgatcatcgatccgattgaagatcttcaattgttaattctcttgcctcgactcatagccatgatgagctcttgatcatgtttccttaaccctctattttttacggaagaatgatcaagctgctgctcttgatcatcgtttc";
int dnaLength = vibrioCholeraeSegment.Length;

int count = 0;
int kmer = 9;

List<string> fullKmerList = new List<string>();

//adds kmers to list
while (count < dnaLength - kmer + 1)
{
    fullKmerList.Add(vibrioCholeraeSegment.Substring(count, kmer));

    count++;
}


string[,] countedKmerList = new string[count, 2];
int countListAmount = 0;
//creates counted list for repeating kmers
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
        countedKmerList[countedListLocation, 0] = fullKmerList[countedListLocation];
        countListAmount++;

        foreach(string segment in fullKmerList)
        {
            if (segment == countedKmerList[countedListLocation, 0])
            {
                repetitionCount++;
            }
        } 
        
        countedKmerList[countedListLocation, 1] = repetitionCount.ToString();
    }
}


List<int> multipleTopRepeats = new List<int>();
int topLocation = 0;

for (int x = 0; x < countListAmount; x++)
{
    if (topLocation == Int32.Parse(countedKmerList[x,1]))
    {
        multipleTopRepeats.Add(Int32.Parse(countedKmerList[x,1]));
    }
    else if (topLocation < Int32.Parse(countedKmerList[x,1]))
    {
        topLocation = Int32.Parse(countedKmerList[x,1]);
        //might be the issue if clear stops loop
        multipleTopRepeats.Clear();
    }
}

foreach (int x in multipleTopRepeats)
{
    Console.WriteLine($"Most repeating kmer: {countedKmerList[x, 0]} repeating {topLocation} times");
}










