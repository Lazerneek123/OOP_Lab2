using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Program
    {
        delegate void Wash(Car car);

        static void Main(string[] args)
        {
            Garage garage = new Garage(); 
            Car AudiA5 = new Car("Audi A5 Quattro 2012"); garage.Add(AudiA5);
            Car NissanXTrail = new Car("Nissan X-Trail 2010"); garage.Add(NissanXTrail);
            Car FordFusion = new Car("Ford Fusion HYBRID 2019"); garage.Add(FordFusion);
            Car ChevroletEpica = new Car("Chevrolet Epica Ls 2007"); garage.Add(ChevroletEpica);
            Car SkodaSuperb = new Car("Skoda Superb 2011"); garage.Add(SkodaSuperb);
            Car SkodaSuperbLAURINKLEMENT = new Car("Skoda Superb LAURINKLEMENT 2016"); garage.Add(SkodaSuperbLAURINKLEMENT);

            Console.WriteLine("Список машин в гражі => ");
            Console.WriteLine();

            foreach (var car in garage)
            {
                Console.WriteLine(car.nameCar + " - " + car.washer);
            }

            Console.WriteLine();            
            
            bool switch_0 = true;

            while (switch_0)
            {
                Console.WriteLine("Яку б машину ви хотіли помити(введіть число від 1 до 6)?");
                string number = Console.ReadLine();

                if (number == "1" || number == "2" || number == "3" || number == "4" || number == "5" || number == "6")
                {
                    Wash wash = Washer.Wash;

                    if (number == "1")
                    {                       
                        wash(AudiA5);
                        Console.WriteLine(AudiA5.nameCar + " - " + AudiA5.washer);
                        switch_0 = false;
                    }

                    if (number == "2")
                    {
                        wash(NissanXTrail);
                        Console.WriteLine(NissanXTrail.nameCar + " - " + NissanXTrail.washer);
                        switch_0 = false;
                    }

                    if (number == "3")
                    {
                        wash(FordFusion);
                        Console.WriteLine(FordFusion.nameCar + " -  " + FordFusion.washer);
                        switch_0 = false;
                    }

                    if (number == "4")
                    {
                        wash(ChevroletEpica);
                        Console.WriteLine(ChevroletEpica.nameCar + " - " + ChevroletEpica.washer);
                        switch_0 = false;
                    }

                    if (number == "5")
                    {
                        wash(SkodaSuperb);
                        Console.WriteLine(SkodaSuperb.nameCar + " - " + SkodaSuperb.washer);
                        switch_0 = false;
                    }

                    if (number == "6")
                    {
                        wash(SkodaSuperbLAURINKLEMENT);
                        Console.WriteLine(SkodaSuperbLAURINKLEMENT.nameCar + " - " + SkodaSuperbLAURINKLEMENT.washer);
                        switch_0 = false;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Ви вели не коректний формат. Спробуйте ще раз!");                    
                }
            }

            Console.ReadKey();
        }
       
    }

    public class Garage : ICollection<Car>     // гараж
    {
        public ICollection<Car> items { get; set; }

        public Garage()
        {           
            items = new List<Car>();
        }

        public int Count => items.Count;
        
        public bool IsReadOnly => items.IsReadOnly;
        

        public void Add(Car item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(Car item)
        {
            return items.Contains(item);
        }

        public void CopyTo(Car[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public bool Remove(Car item)
        {
            return items.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }    

    public class Washer                   // мийка
    {
        public static void Wash(Car car)
        {
            car.washer = "Помита!";
        }

    }

    public class Car                       // машина
    {
        public string nameCar { get; set; }
        public string washer { get; set; }

        public Car() { }

        public Car(string name)
        {
            nameCar = name;
            washer = "Не мита";
        }              
    }
}
