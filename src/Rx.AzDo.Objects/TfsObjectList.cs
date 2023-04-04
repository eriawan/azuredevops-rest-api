using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.AzDo.BaseObject
{
    /// <summary>
    /// Collection/list wrapper of common TFS list.
    /// </summary>
    /// <typeparam name="T">a TfsObjectBase derived class that describe the TFS object</typeparam>
    public class TfsObjectList<T> where T : TfsObjectBase
    {
        public int Count { get; set; }
        public List<T>? Value { get; set; }
    }
}
