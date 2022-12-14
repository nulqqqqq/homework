namespace cursovaya
{
    public class Data
    {
        public List<Numbers> hotelNumber = new List<Numbers>();
        public Data()
        {
            hotelNumber.AddRange(new List<Numbers>
            {
                new Numbers(1, 101, 1, MessageConstants.FREE, 25),
                new Numbers(2, 102, 1, MessageConstants.FREE, 30),
                new Numbers(3, 103, 1, MessageConstants.FREE, 30),
                new Numbers(4, 104, 1, MessageConstants.FREE, 35),
                new Numbers(5, 105, 1, MessageConstants.FREE, 25),
                new Numbers(6, 201, 2, MessageConstants.FREE, 25),
                new Numbers(7, 202, 2, MessageConstants.FREE, 35),
                new Numbers(8, 203, 2, MessageConstants.FREE, 30),
                new Numbers(9, 204, 2, MessageConstants.FREE, 25),
                new Numbers(10, 205, 2, MessageConstants.FREE, 25)
            });
        }
    }
}
