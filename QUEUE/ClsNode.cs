using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    internal class ClsNode
    {
        private Int32 cod;
        private string nam;
        private string proc;
        private ClsNode next;
        private ClsNode prev;

        public ClsNode left
        {
            get { return prev; }
            set { prev = value; }
        }

        public ClsNode right
        {
            get { return next; }
            set { next = value; }
        }

        public ClsNode previous
        {
            get { return prev; }
            set { prev = value; }
        }

        public Int32 Code
        {
            get { return cod; }
            set { cod = value; }
        }
        public String Name
        {
            get { return nam; }
            set { nam = value; }
        }
        public String Proccess
        {
            get { return proc; }
            set { proc = value; }
        }

        public ClsNode NEXT
        {
            get { return next; }
            set { next = value; }
        }
    }
}
