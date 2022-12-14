using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursovaya
{
    public interface INumbers
    {
        Type Type { get; }
        int Hotelnumber { get; set; }
        int Codeofnumber { get; set; }
        int Floor { get; set; }
        string Status { get; set; }
    }
}
