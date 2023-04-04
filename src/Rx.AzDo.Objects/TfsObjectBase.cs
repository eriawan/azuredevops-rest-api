using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.AzDo.BaseObject
{
    /// <summary>
    /// Base class definition of TFS object.
    /// </summary>
    /// <remarks>
    /// <para>Represents base class of TFS object with required properties.</para>
    /// </remarks>
    public class TfsObjectBase
    {
        public TfsAuthor CreatedBy { get; set; } = new();
        public DateTime CreatedOn { get; set; }
        public TfsAuthor? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
