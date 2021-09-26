using Store.Core.ManualMapper.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.ManualMapper.Mappers
{
    public abstract class ReverseMapperBase<TSource, TDestination> : MapperBase<TSource, TDestination>, IReverseMapper<TSource, TDestination>
         where TDestination : new()
         where TSource : class, new()
    {
        public virtual TSource Map(TDestination source)
        {
            if (source == null)
            {
                return default;
            }

            var result = new TSource();

            Map(source, result);

            return result;
        }

        public abstract void Map(TDestination source, TSource destination);

        public virtual IEnumerable<TSource> Map(IEnumerable<TDestination> source)
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
