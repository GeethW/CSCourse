using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    public class Stack
    {
        private List<object> _list;
        private int size;

        public Stack()
        {
            _list = new List<object>();
            size = 0;
        }
        
        public void Push(object obj)
        {
            if(obj==null)
            {
                throw new ArgumentNullException();
            }
            _list.Add(obj);
            size++;
        }

        public object Pop()
        {
            var obj = _list[0];
            if(size==0)
            {
                throw new InvalidOperationException();
            }
            _list.RemoveAt(0);
            return obj;
        }

        public void Clear()
        {
            if(size==0)
            {
                Console.WriteLine
                    ("Nothing to clear.");
            }
            _list.Clear();
        }
    }
}
