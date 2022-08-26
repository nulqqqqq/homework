using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public abstract class FileParser
    {
        public abstract void Read();
        public abstract void Open();
        public abstract void Analize();
        public abstract void Close();

    }
}
