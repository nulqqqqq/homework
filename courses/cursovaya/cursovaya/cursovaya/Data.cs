namespace cursovaya
{
    public class Data
    {
        public List<Numbers<int>>    hotelNumberInt    = new List<Numbers<int>>();
        public List<Numbers<double>> hotelNumberDouble = new List<Numbers<double>>();
        public Data()
        {
            hotelNumberInt.AddRange(new List<Numbers<int>>
            {
                new Numbers<int>(1, 101, 1, ServiceClass.FREE, 25),
                new Numbers<int>(2, 102, 1, ServiceClass.FREE, 30),
                new Numbers<int>(3, 103, 1, ServiceClass.FREE, 30),
                new Numbers<int>(4, 104, 1, ServiceClass.FREE, 35),
                new Numbers<int>(5, 105, 1, ServiceClass.FREE, 25),
                new Numbers<int>(6, 201, 2, ServiceClass.FREE, 25),
                new Numbers<int>(7, 202, 2, ServiceClass.FREE, 25)
            });

            hotelNumberDouble.AddRange(new List<Numbers<double>>
            {
                new Numbers<double>(8, 203, 2, ServiceClass.FREE, 25.5),
                new Numbers<double>(9, 204, 2, ServiceClass.FREE, 15.5),
                new Numbers<double>(10, 205, 2, ServiceClass.FREE, 25.5) 
            });
            
        }
    }
}
