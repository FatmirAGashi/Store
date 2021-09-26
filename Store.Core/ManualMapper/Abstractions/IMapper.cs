using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.ManualMapper.Abstractions
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
        void Map(TSource source, TDestination destination);
        IEnumerable<TDestination> Map(IEnumerable<TSource> source);
    }
}
