using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Stack
    {
        
        private List<object> lists = new List<object>();
        private List<object> otherlists = new List<object>();

        public void Push(object obje)
        {
            if(obje==null)
            {
                throw new System.InvalidOperationException();
            }
            else
            {
                lists.Add(obje);
                otherlists = lists.ToList();
                otherlists.Reverse();
            }
        }
        public object pop()
        {
            if(otherlists==null)
            {
                throw new System.InvalidOperationException();
            }
            else
            {
                object x = otherlists[0];
                otherlists.RemoveAt(0);
                return x;
            }
        }
        public void Clear()
        {
            otherlists.Clear();
        }


    }
}
