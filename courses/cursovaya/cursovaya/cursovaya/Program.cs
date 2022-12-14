namespace cursovaya
{
    public class Program
    {
        static public void Main()
        {
            try
            {
                Service service = new Service();
                service.Start();
            }
            catch (Exception ex)
            {
                Service.DisplayMessage(ex.Message);
            }  
        }
    }
}
