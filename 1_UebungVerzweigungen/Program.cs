
//Aufgabe 1

int x = 9,z = 6; double y = 8;
Console.WriteLine(x-- == y);                                    //Ausgabe False
Console.WriteLine(x == (int)y);                                 //Ausgabe True
Console.WriteLine("{0:F1}", 0.123);                             //Ausgabe 0,1
Console.WriteLine(z / y);                                       //Ausgabe 0,75
Console.WriteLine(x -= 10);                                     //Ausgabe -2
Console.WriteLine(x-- == y & true);                             //Ausgabe False
Console.WriteLine(!(z == 6) | false);                           //Ausgabe False
Console.WriteLine((x *= -2) == z);                              //Ausgabe True

//Aufgabe 2

Console.WriteLine("Welche Temperatur willst du umrechnen? (Nur Zahlen keine Zeichen)");
double temp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("(1) für die Umrechnung von Celsius nach Kelvin");
Console.WriteLine("(2) für die Umrechnung von Celsius nach Fahrenheit");
Console.WriteLine("(3) für die Umrechnung von Kelvin nach Celsius");
Console.WriteLine("(4) für die Umrechnung von Kelvin nach Fahrenheit");
int Auswahl = Convert.ToInt16(Console.ReadLine());

if (Auswahl == 1)
{
    Console.WriteLine($"{temp + 273.15}K");
}
else if (Auswahl == 2)
{
    Console.WriteLine($"{temp * 9 / 5 + 32}°F");
}
else if (Auswahl == 3)
{
    Console.WriteLine($"{temp - 273.15}°C");
}
else if (Auswahl == 4)
{
    Console.WriteLine($"{(temp - 273.15) * 9 / 5 + 32}°F");
}
else
{
    Console.WriteLine("ERROR");
}
