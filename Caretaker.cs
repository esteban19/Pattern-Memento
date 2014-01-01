using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //can be serialized
    public class Caretaker
    {
        List<Memento> savedStates = new List<Memento>();
        public void AddMemento(Memento m)
        {
            savedStates.Add(m);
        }
        public Memento GetMemento(int index)
        {
            return savedStates[index];
        }
    }
}
