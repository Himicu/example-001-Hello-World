Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша"){ //.ToLower() переводит строку в нижний регистр 
    Console.WriteLine("Ура это ты!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
