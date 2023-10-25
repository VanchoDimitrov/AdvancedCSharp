using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Factory<X, Y> where Y : class, X, new()
    {
        public static X GetInstance()
        {
            X objectX = new Y();
            return objectX;
        }
    }
}
