using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text;
using System.Linq;

namespace cursovaya
{
    public delegate void Message2(string message);
    public class Service
    {
        Administrator admin;
        public delegate void Message();
        public delegate void Message1(string messd);

        Message2? mess = DisplayMessage;

        
        public event Message1? Notify;
        

        public Data data;
        public static List<Numbers> numbers;
        public List<int> roomNumbers = new List<int>();

        public void NotifyHandler()
        { 
            mess?.Invoke(MessageConstants.HELLO);
            string name = Console.ReadLine();
            mess?.Invoke(String.Format(MessageConstants.WELCOME, name));

        }
        
        public void ShowOptions()
        {
            Message mes;
            mes = ShowPriceOfNumbers;
            mes += ShowOptions;
            mes += Start;
            mess?.Invoke(MessageConstants.OPTIONS + MessageConstants.FREE_NUMBERS + MessageConstants.ALL_NUMBERS + MessageConstants.EXIT);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == (int)Choises.viewAllFreeRooms)
            {
                Picknumber();
            }
            else if (choice == (int)Choises.viewAllRooms)
            {
                mes();
            }
            else if (choice == (int)Choises.exit)
            {
                Start();
            }
            else
            {
                mess?.Invoke(MessageConstants.MISSING_OPTION);
                ShowOptions();
            }
            
        }

        public void Picknumber()
        {
            mess?.Invoke(MessageConstants.FREE_NUMBERS);
            foreach (Numbers i in numbers)
            {
                if (i.Status == MessageConstants.FREE)
                {
                    mess?.Invoke(String.Format(MessageConstants.SHOW_PRICE_OF_FREE_NUMBER,i.Hotelnumber,i.Price));
                }
            }

            mess?.Invoke(MessageConstants.BACK_TO_OPTIONS);
            mess?.Invoke(MessageConstants.ORDER_NUMBER);
            int choise1 = Convert.ToInt32(Console.ReadLine());
            if (choise1 == 1)
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
            foreach (Numbers i in numbers)
            {
                mess?.Invoke(String.Format(MessageConstants.SHOW_PRICE_AND_STATUS,i.Hotelnumber,i.Price,i.Status));
            }
            ShowOptions();
        }

        public DateTime InputDate()
        {
            mess?.Invoke(MessageConstants.ENTER_DATE_OF_SETTLEMENT);
            DateTime dt;
            bool parse = DateTime.TryParse(Console.ReadLine(), out dt);
            if (!parse||dt.Date < DateTime.Now.Date)
            {
                mess?.Invoke(MessageConstants.ERROR_OF_DATE);
                InputDate();
            }
            return dt;
        }

        public void OrderNumber()
        {
            mess?.Invoke(MessageConstants.PERSONAL_DATA);
            mess?.Invoke(MessageConstants.FNAME_AND_LNAME);
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            mess?.Invoke(MessageConstants.ENTER_PHONE_NUMBER);
            int numberOfPhone = Convert.ToInt32(Console.ReadLine());
            DateTime qwe = InputDate();
            mess?.Invoke(MessageConstants.ENTER_CONT_OF_DAY);
            int countOfDays = Convert.ToInt32(Console.ReadLine());
            int number = BookingNumber(countOfDays);
            mess(MessageConstants.CONGRATULATIONS + MessageConstants.GOOD_CHILL);
            Client client = new Client(1, firstName, lastName, numberOfPhone, qwe, number, countOfDays);
            List<Client> clients1 = FileJson.ReadTextJson(FileJson.PATH);
            clients1.Add(client);
            FileJson.WriteTextJson(clients1, FileJson.PATH);
            ShowOptions();
        }


        public int BookingNumber(int countOfDays)
        {
            mess?.Invoke(MessageConstants.SELECT_HOTEL_NUMBER);
            int number = Convert.ToInt32(Console.ReadLine());
            if(!numbers.Select(i => i.Hotelnumber).Contains(number) || roomNumbers.Contains(number))
            {
                return BookingNumber(countOfDays);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Hotelnumber == number && numbers[i].Status == MessageConstants.FREE)
                {
                    numbers[i].Status = MessageConstants.BUSY;
                    roomNumbers.Add(number);
                    mess?.Invoke(String.Format(MessageConstants.TOTAL_PRICE, numbers[i].Price * countOfDays));
                }
            }
            return number;
        }

        public void Start()
        {
            data = new Data();
            numbers = data.hotelNumber;
            admin = new Administrator();
            NotifyHandler();
            List<Client> clients = FileJson.ReadTextJson(FileJson.PATH);
            foreach (Client item in clients)
            {
                roomNumbers.Add(item.Number);
            }
            foreach (Numbers i in numbers)
            {
                if (roomNumbers.Contains(i.Hotelnumber))
                {
                    i.Status = MessageConstants.BUSY;
                }
            }

            mess?.Invoke(MessageConstants.ENTER_LIKE_ADMIN + MessageConstants.ENTER_LIKE_GUEST);
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == (int)Choises.enterAdmin)
            {
                admin.AdminMethod();
            }
            else if (a == (int)Choises.enterGuest)
            {
                ShowOptions();
            }
            else
            {
                mess?.Invoke(MessageConstants.ERROR_OF_VARIANTS);
                Start();
            }
          
        }
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
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
