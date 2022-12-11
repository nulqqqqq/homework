using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cursovaya;
using System.ComponentModel.DataAnnotations;

namespace cursovaya
{
    public class Clients
    {
        public string firstNameOfGuest { get; set; }
        public string lastNameOfGuest { get; set; }
        public int codeOfGuest { get; set; }
        public DateTime date1 {get;set; }
        public int countOfDays { get; set; }
        public long numberOfPhone { get; set; }
        [Range(1, 100)]
        public int number { get; set; }
        public Clients(int codeOfGuest, string firstNameOfGuest, string lastNameOfGuest, long numberOfPhone, DateTime date1,int number, int countOfDays)
        {
            this.codeOfGuest = codeOfGuest;
            this.firstNameOfGuest = firstNameOfGuest;
            this.lastNameOfGuest = lastNameOfGuest;
            this.numberOfPhone = numberOfPhone;
            this.date1 = date1;
            this.countOfDays = countOfDays;
            this.number = number;
        }
    }
}
