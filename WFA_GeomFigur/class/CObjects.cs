using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GeomFigur
{
    //Interface für dynamisches Objekt
    public interface IDynamicFigure { }

    //Implementierung für dynamische Objekte
    public class CDynamicField<T> : IDynamicFigure
    {
        public string Name { get; set; }
        public Type Type
        {
            get { return typeof(T); }
        }
        public int Length { get; set; }
        public T Value { get; set; }
    }
}
