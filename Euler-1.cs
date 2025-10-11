// eular project first problem solution
//Find the sum of all the multiples of 3 or 5 below 1000

int result = 0;
for (int deger = 1; deger < 1000; deger++)
{
    if (deger % 3 == 0 || deger % 5 == 0)
    {
        result += deger;
    }
}

Console.WriteLine("result is: " + result);