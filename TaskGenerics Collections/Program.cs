using System.Collections.Generic;

namespace TaskGenerics_Collections;

class Program
{
    static void Main(string[] args)
    {
        //List classını Custom yazmaq(Generic olacaq) .
        //List -in Add() Find() FindAll() Remove() RemoveAll() metodları da olacaq.

        CustomList<int> customList = new CustomList<int>(); //ishlemir heccur

        customList.Add(10);
        customList.Add(20);
        customList.Add(30);

        bool removed = customList.Remove(20);





    }


    class Customlist<T>
    {
       
         T[] items;


        public Customlist()
        {
            items = Array.Empty<T>();
            
        }


        public void Add(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[^1] = item;
        }


        public T Find(Predicate<T> something)
        {
            foreach (T item in items)
            {
                if (something(item))
                {
                    return item;
                }
            }
            return default(T);
        }


        public Customlist<T> FindAll(Predicate<T> match)
        {
            Customlist<T> tapilanlar = new Customlist<T>();

            foreach (T item in items)
            {
                if (match(item))
                {
                    tapilanlar.Add(item);
                }
            }

            return tapilanlar;
        }

      //Removlar????


    }
}

