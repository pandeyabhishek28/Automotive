using System;
using System.Collections.Generic;

namespace Automotive.Model
{

    class Truck : Car, IAutomotiveEntity
    {
        public Truck(string name, int honkCount) :
            base(name, honkCount)
        {

        }

        public override void HonkOn(IAutomotiveEntity other)
        {
            base.HonkOn(other);

            Console.WriteLine();

            var carInstances = GetInstances<Car>();
            foreach (var car in carInstances)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine();
            var truckInstances = GetInstances<Truck>();
            foreach (var truck in truckInstances)
            {
                Console.WriteLine(truck.ToString());
            }
        }

        public IList<T> GetInstances<T>() where T : class
        {
            var activeInstances = new List<T>();
            var toBeDelete = new List<WeakReference>();

            foreach (WeakReference reference in _instances)
            {
                if (reference.IsAlive)
                {
                    if (reference.Target.GetType() == typeof(T))
                        activeInstances.Add((T)reference.Target);
                }
                else
                {
                    toBeDelete.Add(reference);
                }
            }

            foreach (WeakReference reference in toBeDelete) _instances.Remove(reference);

            return activeInstances;
        }
    }
}
