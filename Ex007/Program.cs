Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "marley")
{
    Console.WriteLine("Ура, это же my love");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
