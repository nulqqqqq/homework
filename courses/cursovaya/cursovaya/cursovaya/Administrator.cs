using System.Text.Json;
namespace cursovaya
{
    public static class Administrator
    {
        public static void AdminMethod()
        {
            Console.WriteLine("Вы вошли как администратор.Добро пожаловать!");
            Console.WriteLine("Информация о клиентах:");
            if (File.Exists("data.json"))
            {
                string readText = File.ReadAllText("data.json");

                List<Clients> clients = new List<Clients>();

                foreach (var item in JsonSerializer.Deserialize<List<Clients>>(readText))
                {
                    Console.WriteLine($"{item.lastNameOfGuest} забронил комнату {item.number} на {item.countOfDays} дней");
                }
            }
            else
            {
                Console.WriteLine("Клиентов на данный момент нет");
            }
            ServiceClass.Start();
        }
    }
}
