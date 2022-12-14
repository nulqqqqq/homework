namespace cursovaya
{
    public class Program
    {
        Message2? mess = Service.DisplayMessage;
        static public void Main()
        {
            try
            {
                Service service = new Service();
                service.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
