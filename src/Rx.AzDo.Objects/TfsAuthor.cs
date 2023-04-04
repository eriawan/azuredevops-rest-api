using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.AzDo.BaseObject
{
    /// <summary>
    /// Represents author of creation and modification.
    /// </summary>
    public class TfsAuthor
    {
        public String DisplayName { get; set; } = "";
        public Guid Id { get; set; }
        public String UniqueName { get; set; } = "";
    }
}
