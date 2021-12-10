// Read file
var fileLines = File.ReadAllLines("input.txt").ToList();

Part2();

void Part1() {
    int horizontalPos = 0;
    int depth = 0;

    foreach (var line in fileLines) {
        string direction = line.Split(' ')[0];
        int movement = Convert.ToInt32(line.Split(' ')[1]);
        switch (direction) {
            case "forward":
                horizontalPos += movement;
                break;
            case "down":
                depth += movement;
                break;
            case "up":
                depth -= movement;
                break;
        }
    }

    Console.WriteLine("Horizontal: " + horizontalPos);
    Console.WriteLine("Depth: " + depth);
    Console.WriteLine("Multiplied: " + (depth * horizontalPos));
    Console.ReadLine();
}

void Part2() {
    int horizontalPos = 0;
    int depth = 0;
    int aim = 0;

    foreach (var line in fileLines) {
        string direction = line.Split(' ')[0];
        int movement = Convert.ToInt32(line.Split(' ')[1]);
        switch (direction) {
            case "forward":
                horizontalPos += movement;
                depth += (aim * movement);
                break;
            case "down":
                aim += movement;
                break;
            case "up":
                aim -= movement;
                break;
        }
    }

    Console.WriteLine("Horizontal: " + horizontalPos);
    Console.WriteLine("Depth: " + depth);
    Console.WriteLine("Multiplied: " + (depth * horizontalPos));
    Console.ReadLine();
}