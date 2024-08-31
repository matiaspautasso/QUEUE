using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUEUE
{
    internal class ClsQueue
    {
        private ClsNode first;
        private ClsNode last;

        public ClsNode First
        {
            get { return first; }
            set { first = value; }

        }
        public ClsNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public void iNSERT  (ClsNode New)
        {
            if (First == null)
            {
                First = New;
                Last = New;
            }
            else
            {
                Last.NEXT = New;
                Last = New;

            }
        }
        public void Delete()
        {
            if (First == Last)
            {
                First = null;
                Last = null;
            }
            else
            {
                First = First.NEXT;

            }
        }
        public void Navigate(ListBox LIST)
        {
            ClsNode aux = First;
            LIST.Items.Clear();
            while (aux != null)
            {
                LIST.Items.Add(aux.Code);
                aux = aux.NEXT;
            }
        }

        public void Navigate(DataGridView DGV)
        {
            ClsNode aux = First;
            DGV.Rows.Clear();

            while (aux != null)
            {
                DGV.Rows.Add(aux.Code, aux.Name, aux.Proccess);
                aux = aux.NEXT;
            }
        }
        public void Navigate()
        {
            ClsNode aux = First;
            StreamWriter AD = new StreamWriter("Queue.csv", false, Encoding.UTF8);
            AD.WriteLine("Waiting List\n");
            AD.WriteLine("Code;Name;Process");
            while (aux != null)
            {
                AD.Write(aux.Code);
                AD.Write(";");
                AD.Write(aux.Name);
                AD.Write(";");
                AD.WriteLine(aux.Proccess);
                aux = aux.NEXT;

            }
            AD.Close();
        }
    }
}
