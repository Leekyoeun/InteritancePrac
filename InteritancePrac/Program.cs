using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InteritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<animal> animals = new List<Animal>
            {
                new Cat(), new Cat(), new Cat(),
                new Dog(), new Dog(), new Dog()
            };

            foreachh(var item in animals){
                item.Set();
                if(item is Dog)
                {
                    item.bark();
                }

            }
            List<Dog> dogs = new List<Dog> { new Dog(), new Dog(), new Dog() };
            List<Cat> cats = new List<Cat> { new Cat(), new Cat(), new Cat() };

            foreach (Dog dog in dogs)
            {
                dog.Eat();
                dog.Sleep();
            }
            foreach (Cat cat in cats)
            {
                dog.Eat();
                dog.Sleep();
            }
        }
    }
}
