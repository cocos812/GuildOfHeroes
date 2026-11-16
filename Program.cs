using System.Runtime.InteropServices;

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
yaroslav.Health = 75;

///////////////////////
games cs2 = new games("Counter-Strike 2", 2023, 2);
games pubg = new games("PUBG", 2017, 10);
games gta6 = new games("GTA VI", 2026, 1);
Console.WriteLine();

Console.WriteLine(">>> Жестки Гамес 1 <<<");
Console.WriteLine($"Название: {cs2.Nazv}");
Console.WriteLine($"Год выпуска:{cs2.God}");
Console.WriteLine($"Рейтинг: {cs2.Reyt}");
Console.WriteLine($"Жанр: {cs2.Janr}");
Console.WriteLine();

Console.WriteLine(">>> Жестки Гамес 2 <<<");
Console.WriteLine($"Название: {pubg.Nazv}");
Console.WriteLine($"Год выпуска:{pubg.God}");
Console.WriteLine($"Рейтинг: {pubg.Reyt}");
Console.WriteLine($"Жанр: {pubg.Janr}");
Console.WriteLine();

Console.WriteLine(">>> Жестки Гамес 3 <<<");
Console.WriteLine($"Название: {gta6.Nazv}");
Console.WriteLine($"Год выпуска:{gta6.God}");
Console.WriteLine($"Рейтинг: {gta6.Reyt}");
Console.WriteLine($"Жанр: {gta6.Janr}");
/////////////////////////
Console.WriteLine();



Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");
