﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento
    {
        private string state;
        public Memento(string newStateToSave)
        {
            state = newStateToSave;
        }
        public string getSavedState(){ return state; }
    }
}
