using System.Collections.Generic;

namespace Derivco.Test.Model
{
    public interface IHierarchicalItem
    {
        int Id { get; set; }
        int ParentId { get; set; }

        IList<IHierarchicalItem> Children { get; }
    }
}