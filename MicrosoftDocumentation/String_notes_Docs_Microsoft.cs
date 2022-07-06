string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maira";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");


//length
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


//cortar espaços final da mensagem e começo

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

Console.WriteLine($"[{greeting}]");




//substituir texto

string sayHello = "O peito do pé de Pedro e preto";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Pedro", "Mauro");
Console.WriteLine(sayHello);

//tudo em maiusculas: 
Console.WriteLine(sayHello.ToUpper());
//tudo em minusculas:
Console.WriteLine(sayHello.ToLower());

//localizar texto em uma cadeia de caracteres
//Contains
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

//Começa com ../ terminna com ..
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
//***
string songLyrics = "You say goodbye, and I say hello.";
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));
//Fique atento à pontuação quando testar o texto no final da cadeia de //caracteres. Se a cadeia de caracteres terminar com um ponto, verifique se há //uma cadeia de caracteres que termina com um ponto.





Sobre a pergunta que me foi feita a respeito da pregação na praça segue o anúncio de Betel: