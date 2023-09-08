using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("Вася",1) ;
            Person person1 = new Person("Гена",2) ;
            Person person2= new Person("Илья",3) ;
            Person person3 = new Person("Антон",4) ;
           
            List<Person> list = new List<Person>() {person,person1,person2,person3 };
            var selectedSoent = list.OrderByDescending(x => x.age);
            
                                
                                
            
            foreach ( var item in selectedSoent )
            {
                Console.WriteLine( item.Name );
            }
            Console.ReadLine();
        }
        class Person
        {
            public int age;
            public string Name;
           public Person  (string name,int age)
            {
                this.Name = name;
                this.age = age;
            }
           
            
        }
    }
}
