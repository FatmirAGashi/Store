using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.ManualMapper.Abstractions
{
    public interface IReverseMapper<TSource, TDestination> : IMapper<TSource, TDestination>
    {
        TSource Map(TDestination source);
        void Map(TDestination source, TSource destination);
        IEnumerable<TSource> Map(IEnumerable<TDestination> source);
    }
}
