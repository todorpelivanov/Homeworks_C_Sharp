using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets = new List<T>();

        public PetStore()
        {
            ListOfPets = new List<T>();
        }

        public void PrintPets()
        {
            for (int i = 0; i < ListOfPets.Count; i++)
            {
                if (ListOfPets.Count == 0)
                {
                    Console.WriteLine("No Pets for sale in the Store");
                }
                else
                {
                    Console.WriteLine($"{i + 1}) {ListOfPets[i].PrintInfo()}");
                }
            }
        }

        public void BuyPet(string name)
        {
            try
            {
                var pet = ListOfPets.Single(x => string.Equals(x.Name, name, StringComparison.InvariantCultureIgnoreCase));
                ListOfPets.Remove(pet);
                Console.WriteLine($"Success!!! {name} is ready for sale");
            }
            catch (Exception)
            {
                Console.WriteLine($"A pet with the name {name} does not exist");
            }
        }

        public void Add(T pet)
        {
            ListOfPets.Add(pet);
        }
    }
}
