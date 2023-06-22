using static HomeTask20_06.MOney;

Console.WriteLine("Hello, World!");


var converter = new CurrencyConverter();
Console.WriteLine("Valyuta kurslariga baholamoqchi bolgan somingizni kiriting:");
decimal  UZS = decimal.Parse(Console.ReadLine());

var EUR = converter.GetConversion("EUR");
var USD = converter.GetConversion("USD");
var RUB = converter.GetConversion("RUB");

Console.WriteLine($"{UZS} UZS ga teng {EUR(UZS)} EUR");
Console.WriteLine($"{UZS} UZS ga teng {USD(UZS)} USD");
Console.WriteLine($"{UZS} UZS ga teng {RUB(UZS)} RUB");

