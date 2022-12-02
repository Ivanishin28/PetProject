using PetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Filtering
{
    internal class ComposedSpecification<T> : ISpecification<T>
    {
        public List<ISpecification<T>> Specifications { get; set; } 
            = new List<ISpecification<T>>();
        public ComposedSpecification<T> AddSpecification(ISpecification<T> specification)
        {
            Specifications.Add(specification);
            return this;
        }
        public ComposedSpecification<T> AddSpecificationRange
            (IEnumerable<ISpecification<T>> specifications)
        {
            foreach(var specification in specifications)
            {
                if(specification != null)
                {
                    Specifications.Add(specification);
                }
            }
            return this;
        }
        public bool IsSatisfied(T word)
        {
            foreach (var specification in Specifications)
            {
                if (!specification.IsSatisfied(word))
                {
                    return false;
                }
            }
            return true;
        }
    }
}