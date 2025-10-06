using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225512_VoKhoaNguyen_RealWorld16_Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
