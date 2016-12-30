using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        public class Person
        {
            protected string _name;
        }
        /// <summary>
        /// When a class inherits from other class, it can access your protected and public members
        /// above your created members
        /// </summary>
        public class Warrior : Person
        {
            public void SetName(string name)
            {
                // Protected members can be accessed by internal methods or constructors of class
                // so, it can be accessed by inherit class too
                base._name = name;
            }
        }



        public class ProductId
        {
            public int id;
            public string name;

            public ProductId()
            {
                id = 1;
                name = "test";
            }
        }



        public class Generic<T>
        {
            public List<T> lista;

            public Generic()
            {
                lista = new List<T>();
            }

            public void AddItem(T item)
            {
                lista.Add(item);
            }
        }



        static void Main(string[] args)
        {
            List<int> ilist = new List<int>(2);
            ilist.Add(1);
            ilist.Add(2);
            ilist.Add(4);
            ilist.Add(2);


            foreach (int item in ilist)
            {
            }
            ProductId prodId = new ProductId();
            object obj = prodId.GetType();
        }

    }
}
