using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cursovaya;


namespace cursovaya
{
    public class Numbers<T>
    {
      public int hotelnumber { get; set; }
      public int codeofnumber { get; set; }     
      public int floor { get; set; }
      public string status { get; set; }
      public T price { get; set; }
      public Numbers(int codeOfnumber, int hotelnumber, int floor, string status, T price)
        {
            this.codeofnumber = codeOfnumber;
            this.price = price;
            this.floor = floor;
            this.status = status;
            this.hotelnumber = hotelnumber;
        } 
    }
}
