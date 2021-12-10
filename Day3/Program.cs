// Read file
List<string> fileLines = File.ReadAllLines("day3.txt").ToList();
    int binaryLength = fileLines[0].Length;

Part1();
Part2();

void Part1() {
    int[] gamma = new int[binaryLength];
    int[] epsilon = new int[binaryLength];

    for (int i = 0; i < binaryLength; i++) {
        gamma[i] = fileLines.Where(x => x[i] == '1').Count() > (fileLines.Count() / 2) ? 1 : 0;
    }

    for (int i = 0; i < binaryLength; i++) {
        epsilon[i] = fileLines.Where(x => x[i] == '1').Count() < (fileLines.Count() / 2) ? 1 : 0;
    }

    int gammaDec = Convert.ToInt32(string.Join("", gamma), 2);
    int epsilonDec = Convert.ToInt32(string.Join("", epsilon), 2);

    int power = gammaDec * epsilonDec;
    Console.WriteLine("Power: " + power);
}

void Part2() {
    int[] oxygen = new int[binaryLength];
    List<string> oxygenList = fileLines.ToList();

    for (int i = 0; i < binaryLength; i++) {
        oxygen[i] = oxygenList.Where(x => x[i] == '1').Count() >= oxygenList.Where(x => x[i] == '0').Count() ? 1 : 0;
        oxygenList.RemoveAll(x => x[i].ToString() != oxygen[i].ToString());
    }

    int oxygenRating = Convert.ToInt32(oxygenList[0], 2);
    Console.WriteLine("Oxygen: " + oxygenRating);


    int[] scrubber = new int[binaryLength];
    List<string> scrubberList = fileLines.ToList();

    for (int i = 0; i < binaryLength; i++) {
        scrubber[i] = scrubberList.Where(x => x[i] == '1').Count() < scrubberList.Where(x => x[i] == '0').Count() ? 1 : 0;
        scrubberList.RemoveAll(x => x[i].ToString() != scrubber[i].ToString());
        if (scrubberList.Count() == 1) {
            break;
        }
    }

    int coRating = Convert.ToInt32(scrubberList[0], 2);
    Console.WriteLine("CO2: " + coRating);

    Console.WriteLine("Life support: " + (coRating * oxygenRating));
}
