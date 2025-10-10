//problem zero?
//Among the first "?" square numbers, what is the sum of all the odd squares?
// The "?" is random for every person who wants to register.
long n = 10;
long a = 0;
long b = 0;
long c = 0;
for (long i = 1; i <= n; i++)
{
    a = i * i;
    b = a;
    
    if (a % 2 != 0)
    {
        c += b;
    }
    
}
Console.WriteLine("Sum of the first " + n + " odd perfect square number "+ " is: " + "= " + c);