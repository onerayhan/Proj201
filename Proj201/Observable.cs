using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj201
{
    public interface Observable
    {
        void notifyAllObservers();
        void notifyReset();
        void notifyAllObserversDataEnd();
        void attach(string name , Observer observer);
    }
}
