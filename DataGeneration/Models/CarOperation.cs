using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarOperation
    {
        public int Id { get; set; }
        public string CarPlate { get; set; }
        public int OperationId { get; set; }
        public bool IsFinished { get; set; }
    }
}
