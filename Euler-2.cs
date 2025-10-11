//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        long n = 1000;
        long c = 0;
        long a = 0;
        long b = 1;
        long d = 0;

        for (long i = 0; i <= n; i++)
        {
            if (c % 2 != 0)
            {
                d += c;
            }

            a = b;
            b = c;
            c = a + b;
            //Console.WriteLine(c); "fibonnacci numbers"
            if (d > 4000000)
            {
                break;
            }
                
        }
        Console.WriteLine("result is: " + d);
