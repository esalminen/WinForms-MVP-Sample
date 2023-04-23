using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_RJCode.Models
{
    public interface IParcelRepository
    {
        void Add(ParcelModel parcelModel);
        void Edit(ParcelModel parcelModel);
        void Delete(string id);
        IEnumerable<ParcelModel> GetAll();
        IEnumerable<ParcelModel> GetByValue(string value);

    }
}
