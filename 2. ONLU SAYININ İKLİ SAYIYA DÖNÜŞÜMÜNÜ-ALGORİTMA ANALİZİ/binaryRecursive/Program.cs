using System;

class Program
{
    static string OndalikToIkili(int n)
    {
        if (n == 0) 							                            //n
            return "";						                                //1
        else
            return OndalikToIkili(n / 2) + (n % 2).ToString();	            // n
    }								                                        //2n+1

    static void Main(string[] args)
    {
        Console.WriteLine("Ondalık sayıyı girin:");
        int ondalikSayi = int.Parse(Console.ReadLine());

        string ikiliSayi = OndalikToIkili(ondalikSayi);

        Console.WriteLine("İkili sayı: " + ikiliSayi);
    }
}
