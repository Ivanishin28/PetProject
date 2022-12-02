using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Filtering
{
    internal class OrderWordDtoQuery
    {
        public OrderingType OrderingType { get; set; }
        public bool IsDescending { get; set; }
        public OrderWordDtoQuery(OrderingType type, bool isDescending)
        {
            OrderingType = type;
            IsDescending = isDescending;
        }
    }
}