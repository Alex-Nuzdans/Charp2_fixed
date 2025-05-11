using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Door
    {
        private bool _open;
        private bool _lock;

        public Door()
        {
            _open = false;
            _lock = false;
        }

        
        public bool op
        {
            get { return _open; }
            set { _open = value; }
        }

        
        public bool lo
        {
            get { return _lock; }
            set { _lock = value; }
        }
        

        public Door(Door D)
        {
            this._open = D._open;
            this._lock = D._lock;
        }

        
        public bool Close()
        {
            if ((Open == false) && (Lock == false))
            {
                return false;
            }
            return true;
        }

        
        public override string ToString()
        {
            return ("Открыта: " + Open +
                "\nЗафиксирована: " + Lock);
        }
    }

}
