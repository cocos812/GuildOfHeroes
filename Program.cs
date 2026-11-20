using System.Runtime.InteropServices;

//Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

// Hero? found = guild.FindHeroByName(" аРтЁм ");
// if (found != null) {
//     Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
// } else {
//     Console.WriteLine("По запросу « аРтЁм » никого нет.");
// }

Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}






///////////////////////
games cs2 = new games("Counter-Strike 2", 2023, 2,1200, 0);
games pubg = new games("PUBG", 2017, 10,600, 0);
games gta6 = new games("GTA VI", 2026, 1,0, 0);
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
Console.WriteLine();
Console.WriteLine("=== ПРОВЕРКА ДОСТИЖЕНИЙ ===");
Console.WriteLine($"CS2 до действия: {cs2.Dostizheniya}");

cs2.AddDostizhenie(3);
Console.WriteLine($"CS2 после допустимого действия (+3): {cs2.Dostizheniya}");

cs2.AddDostizhenie(-5);
Console.WriteLine($"CS2 после недопустимого действия (-5): {cs2.Dostizheniya}");



GameCatalog catalog = new GameCatalog("Жестки Гамес");

Console.WriteLine();
Console.WriteLine($"Принята CS2: {catalog.AddGame(cs2)}");
Console.WriteLine($"Принята PUBG: {catalog.AddGame(pubg)}");
Console.WriteLine($"Принята GTA VI: {catalog.AddGame(gta6)}");

games eldenRing = new games("Elden Ring", 2022, 9, 300, 0);
Console.WriteLine($"Принята Elden Ring: {catalog.AddGame(eldenRing)}");

Console.WriteLine($"Повтор CS2 принят: {catalog.AddGame(cs2)}");
Console.WriteLine($"В каталоге игр: {catalog.GameCount}");

List<games> slov = catalog.GetGames();
Console.WriteLine();
foreach (games g in slov) {
    Console.WriteLine($">>> {g.Nazv} ({g.God}) <<<");
    Console.WriteLine($"Рейтинг: {g.Reyt}");
    Console.WriteLine($"Часов: {g.Proces}");
    Console.WriteLine($"Достижений: {g.Dostizheniya}");
    Console.WriteLine();
}

games? found = catalog.FindByName("  counter-strike 2 ");
if (found != null) {
    Console.WriteLine($"Найден по запросу «  counter-strike 2 »: {found.Nazv}");
} else {
    Console.WriteLine("По запросу «  counter-strike 2 » ничего нет.");
}

games? missing = catalog.FindByName("Minecraft");
Console.WriteLine($"Minecraft найден: {missing != null}");

Console.WriteLine($"Удалён отсутствующий: {catalog.RemoveByName("Minecraft")}");
Console.WriteLine($"Удалена PUBG: {catalog.RemoveByName("pubg")}");
Console.WriteLine($"Игр после удаления: {catalog.GameCount}");

Console.WriteLine($"Игр с рейтингом от 9: {catalog.CountHighRated(9)}");







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
