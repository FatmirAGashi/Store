using Store.Core.ManualMapper.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.ManualMapper.Mappers
{
    public abstract class MapperBase<TSource, TDestination> : IMapper<TSource, TDestination>
         where TDestination : new()
         where TSource : class
    {
        public virtual TDestination Map(TSource source)
        {
            if (source == null)
            {
                return default;
            }

            var result = new TDestination();

            Map(source, result);

            return result;
        }

        public abstract void Map(TSource source, TDestination destination);

        public virtual IEnumerable<TDestination> Map(IEnumerable<TSource> source)
        {
            if (source == null)
            {
                yield break;
            }

            foreach (var item in source)
            {
                if (item == null)
                {
                    continue;
                }

                yield return Map(item);
            }
        }
    }
}
