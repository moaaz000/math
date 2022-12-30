// See https://aka.ms/new-console-template for more information
int n1, n2;
Console.WriteLine("please enter first number");
n1=int.Parse(Console.ReadLine());
Console.WriteLine("please enter second number");
n2=int.Parse(Console.ReadLine());
Console.WriteLine("the prime numbers between {0} and {1}",n1 , n2  );
for(int x = n1; x <= n2; x++)
{ int counter = 0;

    for (int j = 2; j <= x / 2; j++)
        if (x % j == 0)
        {
            counter++;
            break;

        }

    if ( counter == 0 && x !=1)
    {
        Console.WriteLine("{0}", x);
    }
}