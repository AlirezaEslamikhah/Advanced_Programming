
using System;
using System.Collections.Generic;
using System.Linq;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes
{
    public class GameBoard<_Type> where  _Type : IAnimal
    {
        public GameBoard(IEnumerable<IAnimal> animals)
        {
            Animals = animals.ToList();
        }

        public List<IAnimal> Animals { get; set; }

        
        public string[] MoveAnimals()
        {
            int i = 0;
            string[] b = new string[(Animals.Count)*3];
            foreach (IAnimal p in Animals)
            {
                b[i] = (p.Move(Enums.Environment.Air));
                b[i+1] = (p.Move(Enums.Environment.Land));
                b[i+2] = (p.Move(Enums.Environment.Watery));
                i = i + 3;
            }
            return b;
        }
        
    }
}
