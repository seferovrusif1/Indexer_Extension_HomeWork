using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Extension_HomeWork.Models
{
    internal class Gallery
    {
        //evvelceden size vermekle add etmek

        //public string Name { get; set; }
        //public Car[] cars = new Car[10];

        //public Car this[int index]
        //{
        //    get => cars[index];
        //    set => cars[index] = value;
        //}



        ////Add methodun yazib set etmek ile
        ///
        public string Name { get; set; }
        public Car[] cars = new Car[0];
        public void AddTeacher(Car t)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = t;
        }
        public Car this[int index]
        {
            get => cars[index];
            set => AddTeacher(value);
        }


        //task 2.2
        public bool this[string name]
        {
            get 
            {
                foreach (var item in cars)
                {
                    if (item.Name==name)
                    {
                        return true;
                    }
                }
                return false;
            }
           
        }


       


    }
}
