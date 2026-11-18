using System.Runtime.InteropServices;

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}
string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine($"Ярослав: {yaroslav.Health}");
Console.WriteLine($"Анастасия: {anastasia.Health}");

anastasia.TakeDamage(10);anastasia.TakeDamage(10);

Console.WriteLine($"Ярослав: {yaroslav.Health}");
Console.WriteLine($"Анастасия: {anastasia.Health}");
Hero margarita = new Hero("Маргарита", 80);
margarita.TakeDamage(30);margarita.TakeDamage(30);
margarita.Heal(15);margarita.Heal(15);
margarita.GainExperience(50);margarita.GainExperience(50);
bool margoAlive = margarita.IsAlive();
Console.WriteLine($"Маргарита жива: {margoAlive}");
Console.WriteLine(margarita.GetInfo());Console.WriteLine(margarita.GetInfo());





///////////////////////
games cs2 = new games("Counter-Strike 2", 2023, 2,1200);
games pubg = new games("PUBG", 2017, 10,600);
games gta6 = new games("GTA VI", 2026, 1,0);
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

bool cs2igral = cs2.igral();
bool pubgigral = pubg.igral();
bool gta6igral = gta6.igral();
Console.WriteLine();
Console.WriteLine("Во что ты играл?");
Console.WriteLine();


if (cs2igral) {
    Console.WriteLine($"Да,я играл в {cs2.Nazv},{cs2.Proces} часов");
}
else {
    Console.WriteLine($"Я не играл {cs2.Nazv}");
}

Console.WriteLine();


if (pubgigral) {
    Console.WriteLine($"Да,я играл в {pubg.Nazv},{pubg.Proces} часов");
}
else {
    Console.WriteLine($"Я не играл {pubg.Nazv}");
}

Console.WriteLine();


if (gta6igral) {
    Console.WriteLine($"Да,я играл в {gta6.Nazv},{gta6.Proces} часов");
}
else {
    Console.WriteLine($"Я не играл {gta6.Nazv}");
}
// --- Достижения ---
cs2.AddDostizhenie(2);   
pubg.AddDostizhenie(1);

Console.WriteLine();
Console.WriteLine("=== ДОСТИЖЕНИЯ ===");

if (cs2.Dostizheniya > 0) {
    Console.WriteLine($"{cs2.Nazv}: достижений {cs2.Dostizheniya}");
} else {
    Console.WriteLine($"{cs2.Nazv}: достижений нет");
}

if (pubg.Dostizheniya > 0) {
    Console.WriteLine($"{pubg.Nazv}: достижений {pubg.Dostizheniya}");
} else {
    Console.WriteLine($"{pubg.Nazv}: достижений нет");
}

if (gta6.Dostizheniya > 0) {
    Console.WriteLine($"{gta6.Nazv}: достижений {gta6.Dostizheniya}");
} else {
    Console.WriteLine($"{gta6.Nazv}: достижений нет");
}







/////////////////////////
// Console.WriteLine();



// Console.WriteLine(">>> Герой 1 <<<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Health}");
// Console.WriteLine($"Уровень: {yaroslav.Level}");
// Console.WriteLine($"Опыт: {yaroslav.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Health}");
// Console.WriteLine($"Уровень: {anastasia.Level}");
// Console.WriteLine($"Опыт: {anastasia.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Health}");
// Console.WriteLine($"Уровень: {artem.Level}");
// Console.WriteLine($"Опыт: {artem.Experience}");
