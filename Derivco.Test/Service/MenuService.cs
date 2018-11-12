using System;
using System.Collections.Generic;
using System.Linq;
using Derivco.Test.Model;

namespace Derivco.Test.Service
{
    public static class MenuService
    {
        /// <summary>
        /// This is a blunt and inelegant solution to encapsulate the building of the menu. I would of course refactor and genericise this.
        /// I believe as long as the data structure "MenuItem" itself supports creating a menu n levels deep
        /// then the process of building the menu is (arguably) not required.
        /// </summary>
        /// <returns>A Menu</returns>
        public static IList<MenuItem> Build()
        {
            var rootMenu =
                new List<MenuItem>
                {
                    new MenuItem
                    {
                        Id = 1,
                        Name = "Administration",
                        ParentId = MenuItem.Root,
                        Level = 0,
                        Children =
                        {
                            new MenuItem
                            {
                                Id = 2,
                                Name = "User Admin",
                                ParentId = 1,
                                Level = 1,
                                Children =
                                {
                                    new MenuItem
                                    {
                                        Id = 3,
                                        Name = "Create User",
                                        Level = 2,
                                        ParentId = 2
                                    },
                                    new MenuItem
                                    {
                                        Id = 4,
                                        Name = "Edit User",
                                        Level = 2,
                                        ParentId = 2
                                    }
                                }
                            },
                            new MenuItem
                            {
                                Id = 5,
                                Name = "Product Admin",
                                ParentId = 1,
                                Level = 1,
                                Children =
                                {
                                    new MenuItem
                                    {
                                        Id = 6,
                                        Name = "All Products",
                                        Level = 2,
                                        ParentId = 5,
                                        Children =
                                        {
                                            new MenuItem
                                            {
                                                Id = 7,
                                                Name =
                                                    "My Products",
                                                Level = 3,
                                                ParentId = 6
                                            }
                                        }
                                    },
                                    new MenuItem
                                    {
                                        Id = 8,
                                        Name = "Create Product",
                                        Level = 2,
                                        ParentId = 5
                                    }
                                }
                            },
                            new MenuItem
                            {
                                Id = 9,
                                Name = "Order Admin",
                                ParentId = 1,
                                Level = 1,
                                Children =
                                {
                                    new MenuItem
                                    {
                                        Id = 10,
                                        Name = "Order Reports",
                                        ParentId = 9,
                                        Level = 2,
                                        Children =
                                        {
                                            new MenuItem
                                            {
                                                Id = 11,
                                                Name =
                                                    "Audit Reports",
                                                ParentId = 10,
                                                Level = 3,
                                                Children =
                                                {
                                                    new MenuItem
                                                    {
                                                        Id
                                                            = 12,
                                                        Name
                                                            = "Updated Orders",
                                                        ParentId
                                                            = 11,
                                                        Level
                                                            = 3
                                                    },
                                                    new MenuItem
                                                    {
                                                        Id
                                                            = 13,
                                                        Name
                                                            = "Created Orders",
                                                        ParentId
                                                            = 11,
                                                        Level
                                                            = 3
                                                    }
                                                }
                                            },

                                        }
                                    },
                                    new MenuItem
                                    {
                                        Id = 14,
                                        Name = "Create Order",
                                        ParentId = 9,
                                        Level = 2
                                    }
                                }
                            }
                        }
                    },
                    new MenuItem
                    {
                        Id = 15,
                        Name = "Reports",
                        ParentId = MenuItem.Root,
                        Level = 0,
                        Children =
                        {
                            new MenuItem {Id = 16, Name = "Win Tech Report", Level = 1, ParentId = 15},
                            new MenuItem {Id = 17, Name = "Microsoft Report", Level = 1, ParentId = 15}
                        }
                    }
                };

            return rootMenu;
        }

        public static void Print(MenuItem item)
        {
            Console.WriteLine(item);
            Print(item.Children);
        }

        public static void Print(IList<MenuItem> items)
        {
            foreach (var item in items)
            {
                Print(item);
            }
        }
    }
}