// See https://aka.ms/new-console-template for more information
using C__24_2_Konsole;

var password = "password";
Console.WriteLine("Bitte Passwort eingeben: ");
var eingabe = Console.ReadLine();
if (eingabe == password)
{
    Console.WriteLine("Das Passwort ist korrekt");
}
else if (eingabe != "")
{
    Console.WriteLine("Bitte ein Passwort eingeben");
}
else
{
    Console.WriteLine("Das Passwort stimmt nicht");
}