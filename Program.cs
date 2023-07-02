string name = "John";
bool isWomen = false;
int age = 29;

if (isWomen)
    if (age < 30)
        Console.WriteLine("Kobieta poniżej 30 lat.");
    else 
        if (name == "Ewa" && age == 33)
            Console.WriteLine("Ewa, lat 33.");
        else
            Console.WriteLine(name + " jest dojrzałą kobietą."); 
else
    if (age < 18)
        Console.WriteLine("Niepełnoletni meżczyzna.");
    else
        Console.WriteLine(name + " jest pełnoletni.");
