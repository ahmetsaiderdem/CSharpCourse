using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class EagerInitializedSingleton 
    {
        private static EagerInitializedSingleton instance = new EagerInitializedSingleton();
        private EagerInitializedSingleton() { }
        public static EagerInitializedSingleton getInstance()
        {
            return instance;
        }
    }
}
