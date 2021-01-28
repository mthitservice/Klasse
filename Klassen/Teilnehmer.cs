using System;

namespace Klasse.Hilfsklassen
{

public class Teilnehmer
{






private string _nachname;
private string _vorname;

public string  Nachname { get{
return _nachname;}
 }
public string Vorname { get { return _vorname;}  }     
// Konstruktor
public Teilnehmer(){
 Console.WriteLine("Teilnehmer lebt");

}
public Teilnehmer(string name, string firstname){
 Console.WriteLine("Teilnehmer lebt");
 _nachname=name;
 _vorname=firstname;

}



}
}




