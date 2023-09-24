﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    abstract class Item
    {
        protected long invNumber;
        protected bool taken;

        abstract public void Return();
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }

        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;
        }

        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения: \nИнвентарный номер: {0}\n Наличие: {1}", 
                invNumber, taken);
        }
    }
}
