Console.WriteLine(" ВВедите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower == "Петя")//ToLower -  позволяет все символы в строке перевести в нижний регистр
{
Console.WriteLine("Пошли пить пиво,мой дорогой");
}
else 
{
Console.Write("Здарова , ");
Console.Write(username);
}