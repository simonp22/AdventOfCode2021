// See https://aka.ms/new-console-template for more information

//Part1();

Part2();

void Part1() {
    // Read file
    var fileLines = File.ReadAllLines("input.txt").Select(x => Convert.ToInt32(x)).ToList();
    int increasedCount = 0;
    for (int i = 0; i < fileLines.Count; i++) {
        if (i > 0) {
            if (fileLines[i] > fileLines[i-1]) increasedCount++;
        }
    }
    Console.WriteLine(increasedCount);
    Console.ReadLine();
}

void Part2() {
    // Read file
    var fileLines = File.ReadAllLines("input.txt").Select(x => Convert.ToInt32(x)).ToList();
    int increasedCount = 0;
    for (int i = 0; i < fileLines.Count - 3; i++) {       
            if ((fileLines[i+1] + fileLines[i+2] + fileLines[i+3]) > (fileLines[i] + fileLines[i+1] + fileLines[i+2])) increasedCount++;        
    }
    Console.WriteLine(increasedCount);
    Console.ReadLine();
}
