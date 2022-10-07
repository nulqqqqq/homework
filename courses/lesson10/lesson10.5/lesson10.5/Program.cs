using lesson10._5;
public enum AccesLevelType
{
    NonAccess,
    PartAccess,
    FullAccess
}

public class Program
{
    
    static void Main(string[] args)
    {
        Worker worker = new Worker();
        Director director = new Director();
        Manager manager = new Manager();
        GetAccess(manager, AccesLevelType.FullAccess);
        GetAccess(worker, AccesLevelType.NonAccess);
        GetAccess(director, AccesLevelType.FullAccess);
        
        void GetAccess(Employee employee, AccesLevelType accesLevelType)
        {
            
            Type type = employee.GetType();
            object[] attributes = type.GetCustomAttributes(false);
            foreach (Attribute attr in attributes)
            {

                if (attr is AccessLevelAttribute accessLevelAttribute)
                {
                    if (accessLevelAttribute.a >= accesLevelType)
                    {
                        Console.WriteLine("Доступ к данным разрешен");
                    }
                    else
                    {
                        Console.WriteLine("Доступ к данным запрещен");
                    }
                }
            }
        }


    }
}
    public class Employee
    {

    }
    public class AccessLevelAttribute : System.Attribute
    {
        public AccesLevelType a;
        public AccessLevelAttribute(AttributeTargets attributeTargets, AccesLevelType accesLevelType)
        {
            a = accesLevelType;
        }
    }

