using System.Text.Json;
namespace cursovaya
{
    
    public class Administrator
    {
        Service service = new Service();
        outputMessage? output = Service.DisplayMessage;
        public void AdminMethod()
        {
            
            output?.Invoke(MessageConstants.GREETINGS_ADMIN);
            output?.Invoke(MessageConstants.INFORMATION_ABOUT_CLIENTS);
            List<Client> clients = FileJson.ReadTextJson(FileJson.PATH);
            if (clients.Count > 0)
            {
                foreach (Client item in clients)
                {
                    output?.Invoke(String.Format(MessageConstants.INFORMATION_ABOUT_ORDERS,item.LastNameOfGuest,item.FirstNameOfGuest,
                        item.Number,item.CountOfDays,item.Date1.ToString("dd/MM/yyyy"),item.Date2.ToString("dd/MM/yyyy")));
                }
            }
            else
            {
                output?.Invoke(MessageConstants.SAD_INFORMATION);
            }
            exitAdmin();
        }
        public void exitAdmin()
        {
            output?.Invoke(MessageConstants.EXIT);
            string enter = Console.ReadLine();
            if (enter == MessageConstants.EXITE_ADMIN)
            {
                service.Start();
            }
            else
            {
                exitAdmin();
            }
        }
    }
}
