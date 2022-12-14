namespace cursovaya
{
    public class Data
    {
        public List<INumbers> hotelNumbers = new List<INumbers>();
        public Data()
        {
            hotelNumbers.AddRange(new List<Numbers<int>>
            {
                new Numbers<int>(1, 101, 1, MessageConstants.FREE, 25),
                new Numbers<int>(2, 102, 1, MessageConstants.FREE, 30),
                new Numbers<int>(3, 103, 1, MessageConstants.FREE, 30),
                new Numbers<int>(4, 104, 1, MessageConstants.FREE, 35),
                new Numbers<int>(5, 105, 1, MessageConstants.FREE, 25),
                new Numbers<int>(6, 201, 2, MessageConstants.FREE, 25),
                new Numbers<int>(7, 202, 2, MessageConstants.FREE, 35),
                new Numbers<int>(8, 203, 2, MessageConstants.FREE, 30),
                new Numbers<int>(9, 204, 2, MessageConstants.FREE, 25),
                new Numbers<int>(10, 205, 2, MessageConstants.FREE, 25),

            });
            hotelNumbers.AddRange(new List<Numbers<double>>
            {
                new Numbers<double>(10, 206, 2, MessageConstants.FREE, 25.50),
                new Numbers<double>(10, 207, 2, MessageConstants.FREE, 25.75)
            });
        }
    }
}
