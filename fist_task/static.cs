using System;

class Program
{
    static void Main()
    {

        // task 1
        int number = 91; 

        if (number == 91)
        {
            Console.WriteLine("А");
        }
        else if (number == 75)
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("bilinmeyen herf");
        }


        // task 2
        int num1 = 4; 
        int num2 = 6; 

        if (num1 % 2 == 0 && num2 % 2 == 0)
        {
            Console.WriteLine("ededlerin cemi: " + (num1 + num2));
        }
        else
        {
            Console.WriteLine("daxil olunan ededler cut olmalidir!");
        }


        // task 3
        int maas = 50000; 
        int kredit = 25000; 

        if (kredit < maas * 0.6)
        {
            Console.WriteLine("Kredit goture bilmezsiniz!");
        }
        else
        {
            Console.WriteLine("Kredit goture bilersiniz!");
        }


        // task 4
        int num = 45; 

        if (num >= 10 && num <= 99)
        {
            Console.WriteLine("singular????");
        }
        else
        {
            Console.WriteLine("onlug...ne????");
        }


        // task 5
        int length = 10; 
        int width = 5; 

        int sahe = height * width;
        int perimeter = 2 * (height + width);

        Console.WriteLine("sahe: " + sahe);
        Console.WriteLine("perimeter: " + perimeter);


        // task 6  (emin deyilem)
        int a = 5; 
        int b = 10; 
        int c;

        c = a;
        a = b;
        b = c;

        Console.WriteLine("deyisdikden sonra: a = " + a + ", b = " + b);

    }
}
