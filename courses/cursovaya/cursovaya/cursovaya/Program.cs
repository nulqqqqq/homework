namespace cursovaya
{
    public class Program
    {

        static public void Main()
        {
            try
            {
                ServiceClass serviceClass = new ServiceClass();
                serviceClass.NotifyHandler();
                ServiceClass.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
