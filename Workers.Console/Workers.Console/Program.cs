﻿using Workers.Console.Models;
using Workers.Console.Repo;

Console.WriteLine("1. feladat");

try
{
    Employee empty = new Employee("", "Null");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("2. feladat");
Employee janos = new Employee("janos@ceg.hu", "Dolgozó János");
Console.WriteLine(janos);

Console.WriteLine("3. feladat");
try
{
    janos.AddPay(-300000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("4. feladat");
janos.AddPay(200000);
janos.AddPay(300000);
Console.WriteLine(janos);

EmployeeRepo repo = new EmployeeRepo();
Console.WriteLine($"Dolgozók száma: {repo.GetNumberOfEmployees()}");
