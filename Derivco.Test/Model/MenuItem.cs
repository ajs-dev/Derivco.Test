using System.Collections.Generic;

namespace Derivco.Test.Model
{
    public class MenuItem : IHierarchicalItem
    {
        public MenuItem()
        {
            Children = new List<IHierarchicalItem>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public IList<IHierarchicalItem> Children { get; private set; }

        public string Name { get; set; }
    }
}