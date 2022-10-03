using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using project;
Client client = new Client();
Console.WriteLine("Write your name");
client.name = Console.ReadLine();
Console.WriteLine("Write your age");
client.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your name is: {client.name},your age is: {client.Age}");



