// 10 км в первый день. каждый сл день >10% от предыдущего дня
// 1) в какой день пробежит больше 20км 2) в какой день суммарно больше 100км

double RangeSki(double range, double days, double sum)
{ 
for (double i = 1; i <= days; i++)
{
    Console.WriteLine($"{i} day ran is {range} km") ;
    if (i < 7 + 1) 
        sum += range;
            range += range * 0.1;
        Console.WriteLine($"ran is 7 days = {sum}");
    }
    return sum;
}

RangeSki(10,10,0);

