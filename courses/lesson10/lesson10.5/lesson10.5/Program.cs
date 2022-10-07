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
        
        void GetAccess(Employee employee, AccesLevelType accesLevelType)
        {
            
            Type type = employee.GetType();
            object[] attributes = type.GetCustomAttributes(true);
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
        Manager manager = new Manager();
        Console.WriteLine("manager");
        GetAccess(manager, AccesLevelType.FullAccess);
        GetAccess(manager, AccesLevelType.PartAccess);
        GetAccess(manager, AccesLevelType.NonAccess);
        Console.WriteLine();
        Director director = new Director();
        Console.WriteLine("director");
        GetAccess(director, AccesLevelType.FullAccess);
        GetAccess(director, AccesLevelType.PartAccess);
        GetAccess(director, AccesLevelType.NonAccess);
        Console.WriteLine();
        Worker worker = new Worker();
        Console.WriteLine("worker");
        GetAccess(worker, AccesLevelType.FullAccess);
        GetAccess(worker, AccesLevelType.PartAccess);
        GetAccess(worker, AccesLevelType.NonAccess);
        Console.WriteLine();
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


