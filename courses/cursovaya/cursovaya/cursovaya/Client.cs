using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cursovaya;
using System.ComponentModel.DataAnnotations;

namespace cursovaya
{
    public class Client
    {
        public string FirstNameOfGuest { get; set; }
        public string LastNameOfGuest { get; set; }
        public int CodeOfGuest { get; set; }
        public DateTime Date1 {get;set; }
        public int CountOfDays { get; set; }
        public long NumberOfPhone { get; set; }
        [Range(1, 100)]
        public int Number { get; set; }
        public Client(int codeOfGuest, string firstNameOfGuest, string lastNameOfGuest, long numberOfPhone, DateTime date1,int number, int countOfDays)
        {
            this.CodeOfGuest = codeOfGuest;
            this.FirstNameOfGuest = firstNameOfGuest;
            this.LastNameOfGuest = lastNameOfGuest;
            this.NumberOfPhone = numberOfPhone;
            this.Date1 = date1;
            this.CountOfDays = countOfDays;
            this.Number = number;
        }
    }
}
