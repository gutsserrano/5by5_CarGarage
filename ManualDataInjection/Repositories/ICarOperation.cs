using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICarOperation
    {
        bool Insert(CarOperation carOperation);
        List<CarOperation> GetAll();
        string GetCarPlate(int operationId);
        int GetOperationId(string carPlate);
    }
}
