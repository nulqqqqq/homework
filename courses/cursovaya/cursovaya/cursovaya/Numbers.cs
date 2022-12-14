using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cursovaya;


namespace cursovaya
{
    public class Numbers
    {
      public int Hotelnumber { get; set; }
      public int Codeofnumber { get; set; }     
      public int Floor { get; set; }
      public string Status { get; set; }
      public decimal Price { get; set; }
      public Numbers(int codeOfnumber, int hotelnumber, int floor, string status, decimal price)
        {
            this.Codeofnumber = codeOfnumber;
            this.Price = price;
            this.Floor = floor;
            this.Status = status;
            this.Hotelnumber = hotelnumber;
        } 
    }
}
