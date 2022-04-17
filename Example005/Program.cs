Console.Write("Enter your Name: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Машка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}