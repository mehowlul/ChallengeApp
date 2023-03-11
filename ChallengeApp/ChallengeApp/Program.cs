string name = "Ewa";
bool women = true;
int age = 29;

if (women == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (women == false && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
    Console.WriteLine("Hello World!");