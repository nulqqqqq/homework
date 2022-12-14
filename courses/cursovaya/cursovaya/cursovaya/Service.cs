using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text;
using System.Linq;

namespace cursovaya
{
    public delegate void outputMessage(string message);
    public class Service
    {
        Administrator admin;

        outputMessage? output = DisplayMessage;

        public event outputMessage NotifyEndBook;
        public Data data;
        public static List<INumbers> numbers;
        public List<int> roomNumbers = new List<int>();

        public void Greet()
        {
            output?.Invoke(MessageConstants.HELLO);
            string name = Console.ReadLine();
            output?.Invoke(String.Format(MessageConstants.WELCOME, name));
        }

        public void ShowOptions()
        {
            output?.Invoke(MessageConstants.OPTIONS + MessageConstants.FREE_NUMBERS + MessageConstants.ALL_NUMBERS + MessageConstants.EXIT);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == (int)Choises.viewAllFreeRooms)
            {
                Picknumber();
            }
            else if (choice == (int)Choises.viewAllRooms)
            {
                ShowPriceOfNumbers();
            }
            else if (choice == (int)Choises.exit)
            {
                Start();
            }
            else
            {
                output?.Invoke(MessageConstants.MISSING_OPTION);
                ShowOptions();
            }
        }

        public void Picknumber()
        {
            output?.Invoke(MessageConstants.FREE_NUMBERS);
            foreach (INumbers number in numbers)
            {
                if (number.Status == MessageConstants.FREE)
                {
                    output?.Invoke(String.Format(MessageConstants.SHOW_PRICE_OF_FREE_NUMBER, number.Hotelnumber, number.ToString()));
                }
            }

            output?.Invoke(MessageConstants.BACK_TO_OPTIONS);
            output?.Invoke(MessageConstants.ORDER_NUMBER);
            int choiseOfOprions = Convert.ToInt32(Console.ReadLine());
            if (choiseOfOprions == 1)
            {
                ShowOptions();
            }
            else
            {
                OrderNumber();
            }
        }

        public void ShowPriceOfNumbers()
        {
            foreach (INumbers number in numbers)
            {
                output?.Invoke(String.Format(MessageConstants.SHOW_PRICE_AND_STATUS, number.Hotelnumber, number.ToString(), number.Status));
            }
            ShowOptions();
        }

        public DateTime InputDate()
        {
            output?.Invoke(MessageConstants.ENTER_DATE_OF_SETTLEMENT);
            DateTime checkInDate;
            bool parse = DateTime.TryParse(Console.ReadLine(), out checkInDate);
            if (!parse || checkInDate.Date < DateTime.Now.Date)
            {
                output?.Invoke(MessageConstants.ERROR_OF_DATE);
                InputDate();
            }
            return checkInDate;
        }

        public void OrderNumber()
        {
            output?.Invoke(MessageConstants.PERSONAL_DATA);
            output?.Invoke(MessageConstants.FNAME_AND_LNAME);
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            output?.Invoke(MessageConstants.ENTER_PHONE_NUMBER);
            int numberOfPhone = Convert.ToInt32(Console.ReadLine());
            DateTime qwe = InputDate();
            output?.Invoke(MessageConstants.ENTER_CONT_OF_DAY);
            int countOfDays = Convert.ToInt32(Console.ReadLine());
            int number = BookingNumber(countOfDays);
            output(String.Format(MessageConstants.CONGRATULATIONS + MessageConstants.PERIOD_OF_STAY + MessageConstants.GOOD_CHILL,
                qwe.ToString("dd/MM/yyyy"),qwe.AddDays(countOfDays).ToString("dd/MM/yyyy")));
            Client client = new Client(1, firstName, lastName, numberOfPhone, qwe, number, countOfDays);
            List<Client> clients1 = FileJson.ReadTextJson(FileJson.PATH);
            clients1.Add(client);
            FileJson.WriteTextJson(clients1, FileJson.PATH);
            ShowOptions();
        }


        public int BookingNumber(int countOfDays)
        {
            output?.Invoke(MessageConstants.SELECT_HOTEL_NUMBER);
            int number = Convert.ToInt32(Console.ReadLine());
            if (!numbers.Select(item => item.Hotelnumber).Contains(number) || roomNumbers.Contains(number))
            {
                return BookingNumber(countOfDays);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Hotelnumber == number && numbers[i].Status == MessageConstants.FREE)
                {
                    numbers[i].Status = MessageConstants.BUSY;
                    roomNumbers.Add(number);
                    if (numbers[i].Type == typeof(double))
                    {
                        output?.Invoke(String.Format(MessageConstants.TOTAL_PRICE, Convert.ToDouble(countOfDays) * Convert.ToDouble(numbers[i].ToString())));
                    }
                    else if (numbers[i].Type == typeof(int))
                    {
                        output?.Invoke(String.Format(MessageConstants.TOTAL_PRICE, countOfDays * Convert.ToInt32(numbers[i].ToString())));
                    }
                }
            }
            return number;
        }

        public void Start()
        {
            data = new Data();
            numbers = data.hotelNumbers;
            admin = new Administrator();
            Greet();
            List<Client> clients = FileJson.ReadTextJson(FileJson.PATH);
            foreach (Client client in clients)
            {
                roomNumbers.Add(client.Number);
            }
            foreach (INumbers number in numbers)
            {
                if (roomNumbers.Contains(number.Hotelnumber))
                {
                    number.Status = MessageConstants.BUSY;
                }
            }

            output?.Invoke(MessageConstants.ENTER_LIKE_ADMIN + MessageConstants.ENTER_LIKE_GUEST);
            int typerOfUser = Convert.ToInt32(Console.ReadLine());
            if (typerOfUser == (int)Choises.enterAdmin)
            {
                admin.AdminMethod();
            }
            else if (typerOfUser == (int)Choises.enterGuest)
            {
                ShowOptions();
            }
            else
            {
                output?.Invoke(MessageConstants.ERROR_OF_VARIANTS);
                Start();
            }
        }
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void CheekBookExpired(List<Client> clients)
        {
            
            foreach (Client item in clients)
            {
                if (item.Date2.Date >= DateTime.Now.Date)
                {
                    NotifyEndBook?.Invoke(MessageConstants.END_OF_BOOKING);
                }
            }
        }

        enum Choises
        {
            viewAllFreeRooms = 1,
            viewAllRooms = 2,
            enterAdmin = 1,
            enterGuest = 2,
            exit = 3,
        }
    }
}
