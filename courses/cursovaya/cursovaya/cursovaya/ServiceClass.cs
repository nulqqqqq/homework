using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace cursovaya
{
    public class ServiceClass : IGreetings
    {
        public delegate void Message();
        public delegate void Message1(string messd);
        

        public event Message1? Notify;
        public const string FREE = "Свободен";
        public const string BUSY = "Занят";

        public static Data data = new Data();
        public static List<Numbers<int>> numbersInt = data.hotelNumberInt;
        public static List<Numbers<double>> numbersDouble = data.hotelNumberDouble;
        public static List<int> roomNumbers = new List<int>();

        public void Hello(string message)
        {
            Console.WriteLine(message);
        }
        public void NotifyHandler()
        {
            Notify += Hello;
            Notify?.Invoke("Здравствуйте ,как к вам обращаться?");
            string name = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать {name}");
        }
        
        public static void Variable()
        {
            Message mes;
            mes = PriceOfNumbers;
            mes += Variable;
            mes += Start;
            Console.WriteLine("доступныые опции для вас:\n" +
                "1.Посмотреть список доступных номеров\n" +
                "2.Посмотреть список всех номеров\n "+
                "3.Выход");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ServiceClass.Picknumber();
                    break;
                case 2:
                    mes();
                    break;
                case 3:
                    Start();
                    break;
                default:
                    Console.WriteLine("Такого варианта нет,пожалуйста выберете команду из доступных");
                    ServiceClass.Variable();
                    break;
            }
        }

        public static void Picknumber()
        {
            Console.WriteLine("Вот список доступных номеров:");
            foreach (Numbers<int> i in numbersInt)
            {
                if (i.status == ServiceClass.FREE)
                {
                    Console.WriteLine($"номер {i.hotelnumber} cвободен по цене: {i.price}$ за сутки");
                }
            }

            foreach (Numbers<double> i in numbersDouble)
            {
                if (i.status == ServiceClass.FREE)
                {
                    Console.WriteLine($"номер {i.hotelnumber} cвободен по цене: {i.price}$ за сутки");
                }
            }
            Console.WriteLine("чтобы вернуться к опциям,нажмите 1");
            Console.WriteLine("чтобы забронировать номер,нажмите 2");
            string choise1 = Console.ReadLine();
            if (choise1 == "1")
            {
                Variable();
            }
            else
            {
                OrderNumber();
            }
        }

        public static void PriceOfNumbers()
        {
            foreach (Numbers<int> i in numbersInt)
            {
             Console.WriteLine($"цена на номер {i.hotelnumber} = {i.price}$ в сутки. На данный момент:{i.status}");
            }
            foreach (Numbers<double> i in numbersDouble)
            {
                Console.WriteLine($"цена на номер {i.hotelnumber} = {i.price}$ в сутки. На данный момент:{i.status}");
            }
            Variable();
        }

        public static  DateTime InputDate()
        {
            Console.WriteLine("Введите вашу дату заселения: ");
            DateTime dt;
            bool parse = DateTime.TryParse(Console.ReadLine(), out dt);
            if (!parse)
            {
                Console.WriteLine("неверно,введите дату в формате: 21.01.2022");
                InputDate();
            }
            return dt;
        }

        public static void OrderNumber()
        {
            Console.WriteLine("Чтобы заказать один из номеров ,потребуются ваши персональные данные");
            Console.WriteLine("Пожалуйста,напомните свое полное Имя и Фамилию:");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine("введите свой номер телефона ");
            int numberOfPhone = Convert.ToInt32(Console.ReadLine());
            DateTime qwe = InputDate();
            Console.WriteLine("Введите количество дней проживания:");
            int countOfDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите номер комнаты для проживания из свободных на данный момент");
            int number = Convert.ToInt32(Console.ReadLine());
            BookingNumber(number, countOfDays);
            Clients client = new Clients(1, firstName, lastName, numberOfPhone, qwe, number, countOfDays);
            List<Clients> clients1 = new List<Clients>();
            clients1.Add(client);
            //чтение
            if (File.Exists("data.json"))
            {
                string readText = File.ReadAllText("data.json");
                List<Clients> clients = new List<Clients>();
                foreach (var item in JsonSerializer.Deserialize<List<Clients>>(readText))
                {
                    clients1.Add(item);
                    roomNumbers.Add(item.number);
                }
                
            }
           
            //зпись
            var options = new JsonSerializerOptions { WriteIndented = true };
            string text = JsonSerializer.Serialize(clients1, options);
            File.WriteAllText("data.json", text);
            Variable();
        }

        public static void BookingNumber(int number,int countOfDays)
        { 
            for (int i = 0; i < numbersInt.Count; i++)
            {
                if (numbersInt[i].hotelnumber == number && numbersInt[i].status == FREE)
                {
                    numbersInt[i].status = BUSY;
                    Console.WriteLine($"стоимсть этого номера будет {numbersInt[i].price * countOfDays}$");
                }
            }

            for (int i = 0; i < numbersDouble.Count; i++)
            {
                if (numbersDouble[i].hotelnumber == number && numbersDouble[i].status == FREE)
                {
                    numbersDouble[i].status = BUSY;
                    Console.WriteLine($"стоимсть этого номера будет {numbersDouble[i].price * countOfDays}$");
                }
            }
            Console.WriteLine("Поздравляем, данный номер забронирован за вами.\n" +
                    "Хорошего отдыха!");
        }

        public static void Start()
        {
            
            if (File.Exists("data.json"))
            {
                string readText = File.ReadAllText("data.json");
                List<Clients> clients = new List<Clients>();
                foreach (var item in JsonSerializer.Deserialize<List<Clients>>(readText))
                {
                    roomNumbers.Add(item.number);
                }

            }
            foreach (Numbers<int> i in numbersInt)
            {
                if (roomNumbers.Contains(i.hotelnumber))
                {
                    i.status = BUSY;
                }
            }

            foreach (Numbers<double> i in numbersDouble)
            {
                if (roomNumbers.Contains(i.hotelnumber))
                {
                    i.status = BUSY;
                }
            }

            Console.WriteLine("1.Войти как администратор\n"
                + "2.Войти как гость");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Administrator.AdminMethod();
                    break;
                case 2:
                    ServiceClass.Variable();
                    break;
                default:
                    Console.WriteLine("Такого варианта нету ,выбирете из предоставленных:");
                    Start();
                    break;
            }
        }
        
    }
}
