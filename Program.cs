int number = 1266664442;
string numericalSequence = number.ToString();
int[] stats = new int[10];
char[] numbers = {'0','1','2','3','4','5','6','7','8','9'};
char[] sequence = numericalSequence.ToArray();

foreach (var leter in sequence)
    for (int i = 0; i < 10; i++)
        if (numbers[i] == leter)
            stats[i]++;

Console.WriteLine("W liczbie: " + number + " znajduje się:");
for (int i = 0; i < 10; i++)
    Console.WriteLine(i + " => " + stats[i]);