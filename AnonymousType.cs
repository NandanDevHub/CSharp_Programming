using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programming
{
    internal class AnonymousType
    {
        public void AnonymousTypeExample()
        {
            var anonymoys = new
            {
                Name = "John Doe",
                Age = 30,
                Address = new // Nested Anonymous Type
                {
                    Street = "123 Main St",
                    City = "Anytown"
                }
            };

            Console.WriteLine("Name: " + anonymoys.Name);
            Console.WriteLine("Age: " + anonymoys.Age);
            Console.WriteLine("Street: " + anonymoys.Address.Street);
            Console.WriteLine("City: " + anonymoys.Address.City);
        }
    }
}
