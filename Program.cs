using System;

namespace Klasse
{
    class Program
    {
        static void Main(string[] args)
        { // Deklaration von Variablen
            Auto a1;  // Verweistypen
        
            int[] zliste=new int[5]; // Verweistyp
            int Wert1 =45; // Wertetyp;
            string Wert2 = "gelb";
            int rg;
            // Iitialisiere Variablen
            
            a1=new Auto(); // Instanziierung
            a1.farbe="rot";
            a1.ps=90;
            a1.tanken(60);
            a1.tanken(5);
           
            rg=a1.zeigeTankinhalt();

            Console.WriteLine("Tankinhalt:{0}",rg);
            gibAus(Wert1,Wert2);
            gibAus(a1);
 // Ausgabe


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

         static void gibAus(int DIePS, string Diefarbe )
         {
                Console.WriteLine("Farbe {0} und PS {1}",Diefarbe,DIePS);


         }

        static void gibAus(Auto DasAuto)
         {
                Console.WriteLine("Farbe {0} und PS {1}",DasAuto.farbe,DasAuto.ps);


         }


    }

// Klasse (Bauplan) deklarieren
 public class Auto
 {
     // EIgenschaften deklarieren
     // Gekapselte Variablendeklaration
     private int _tankinhalt;

    // Variable mit öffentlichen Zugriff
    public string farbe;
    public  int ps;

    // Methoden
    public void tanken(int liter)
    {
        this._tankinhalt=rechne(this._tankinhalt,liter);

    }

    public int zeigeTankinhalt()
    {

        return this._tankinhalt;

    }

    private int rechne(int a,int b)
    {
        return a+b;

    }




 }






}
