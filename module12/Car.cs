using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module12
{
    public abstract class Car
    {
        public string Name { get; private set; }
        public int Speed { get; protected set; }
        public int Distance { get; private set; }

        public event EventHandler Finished;

        protected Car(string name)
        {
            Name = name;
        }

        public void Drive()
        {
            Distance += Speed;
            if (Distance >= 100)
            {
                OnFinished();
            }
        }

        protected virtual void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }
    }
}
