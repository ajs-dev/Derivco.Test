using System;
using System.Collections.Generic;

namespace Derivco.Test.Model
{
    public class MenuItem
    {
        /// <summary>
        /// represents a root menu item/node
        /// </summary>
        public const int Root = -1;

        public MenuItem()
        {
            Children = new List<MenuItem>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public IList<MenuItem> Children { get; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{new string('\t', Level)}- {Name}";
        }
    }
}