using System.Text.Json;
namespace cursovaya
{
    
    public class Administrator
    {
        Service service = new Service();
        Message2? mess = Service.DisplayMessage;
        public void AdminMethod()
        {
            
            mess?.Invoke(MessageConstants.GREETINGS_ADMIN);
            mess?.Invoke(MessageConstants.INFORMATION_ABOUT_CLIENTS);
            List<Client> clients = FileJson.ReadTextJson(FileJson.PATH);
            if (clients.Count > 0)
            {
                foreach (Client item in clients)
                {
                    mess?.Invoke(String.Format(MessageConstants.INFORMATION_ABOUT_ORDERS,item.LastNameOfGuest,item.Number,item.CountOfDays));
                }
            }
            else
            {
                mess?.Invoke(MessageConstants.SAD_INFORMATION);
            }
            service.Start();
        }
    }
}
