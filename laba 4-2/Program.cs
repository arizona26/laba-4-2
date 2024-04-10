using laba_4_2;
using laba_4_2.laba_4_2;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
Sportsstore equipment = new Sportsstore();
equipment.AddProduct(new Sportsequipment("Лижi", 2000, "зима"));
equipment.AddProduct(new Sportsequipment("Ролики", 1500, "лiто"));
equipment.AddProduct(new Bar("BioGym", 865, "будь-який", 5));
equipment.AddProduct(new Metallwieghts("Диск обважнювач IRON", 539, "будь-який", 10, "спортпіт"));
equipment.AddProduct(new Protein("ELITE WHEY PROTEIN", 50, "будь-який", "спортпiт", "Vegetable protein"));
equipment.AddProduct(new Nutritionalsupplements("Батончик", 20, "будь-який", "спортпiт"));
var sortedEquipment = equipment.SortByTypeAndCost();
Console.WriteLine("\nСписок спортивного обладнання:");
foreach (var product in sortedEquipment)
{
    Console.WriteLine($"Назва: {product.Name}, Вартiсть: {product.Cost}, Сезон: {product.Season}");
}
Console.WriteLine("_____________________________________________________");
var foodAdditives = equipment.FindFoodAdditivesInRange(10, 30);
Console.WriteLine("Харчовi добавки в дiапазонi вартостi вiд 10 до 30:");
foreach (var additive in foodAdditives)
{
    Console.WriteLine($"Назва: {additive.Name}, Вартість: {additive.Cost}, Тип: {additive.Type}");
}
