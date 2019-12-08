using System;
using System.Collections.Generic;

namespace Automotive.Model
{

    interface IAutomotiveEntity
    {
        string Name { get; set; }
        int HonkCount { get; set; }
    }

    class Car : IAutomotiveEntity
    {
        public string Name { get; set; }
        public int HonkCount { get; set; }

        protected static List<WeakReference> _instances = new List<WeakReference>();
        public Car(string name, int honkCount)
        {
            Name = name;
            HonkCount = honkCount;
            _instances.Add(new WeakReference(this));
        }

        public virtual void HonkOn(IAutomotiveEntity other)
        {
            for (int i = 0; i < HonkCount; i++)
            {
                Console.Beep();
                Console.WriteLine($"{Name} honks on the {other.Name}");
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + " : " + Name + " -----" + HonkCount;
        }
    }
}
