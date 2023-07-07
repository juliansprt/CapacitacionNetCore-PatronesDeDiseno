using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionNetCore_PatronesDeDiseno.PatronesDiseno.Creacionales
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padLock = new object();

        Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void LogMessage()
        {
            Console.WriteLine("Mensaje desde el patron Singleton");
        }
    }





    public static class DiccionarioSingleton
    {
        public static List<Singleton> singletons = new List<Singleton>();
    }
}
