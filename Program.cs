using System.ComponentModel;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------Atama ve Islemli atama-------");
        //Atama ve Islemli atama
        int x= 6;
        int y= 8;

        y= y+2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        Console.WriteLine("-------Mantiksal Operatorler(||, &&, !)-------");
        //Mantiksal Operatorler(||, &&, !)

        bool isSuccess= true;
        bool isCompleted= false;

        if(isSuccess && isCompleted)
        {
            Console.WriteLine("perfect!");
        }
        if(isSuccess || isCompleted)
        {
            Console.WriteLine("great!");
        }

        Console.WriteLine("-------Iliskisel Operatorler(<, >, <=, >=, ==, !=)-------");            
        //Iliskisel Operatorler(<, >, <=, >=, ==, !=)

        int a=3;
        int b=5;

        bool sonuc1=a<b;
        Console.WriteLine(sonuc1);
        bool sonuc2=a>b;
        Console.WriteLine(sonuc2);
        bool sonuc3=a==b;
        Console.WriteLine(sonuc3);
        bool sonuc4=a<=b;
        Console.WriteLine(sonuc4);
        bool sonuc5=a>=b;
        Console.WriteLine(sonuc5);
        bool sonuc6=a!=b;
        Console.WriteLine(sonuc6);

        Console.WriteLine("-------Aritmetik Operatorler (+, -, *, /, %)-------");
        //Aritmetik Operatorler (+, -, *, /, %)

        int sayi1=10;
        int sayi2=5;

        int toplama=sayi1+sayi2;
        Console.WriteLine(toplama);
        int cikarma=sayi1-sayi2;
        Console.WriteLine(cikarma);
        int carpma=sayi1*sayi2;
        Console.WriteLine(carpma);
        int bolme=sayi1/sayi2;
        Console.WriteLine(bolme);
        int mod=sayi1%sayi2;
        Console.WriteLine(mod);



    }
}