using StorageLib.Models;
using System.Collections.ObjectModel;

namespace StorageLib.Services
{
    public class ItemService
    {
        private ItemService()
        {
            items = new List<Item>();
        }

        private static ItemService? instance;
        private static object instanceLock = new object();
        public static ItemService Current
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ItemService();
                    }
                }

                return instance;
            }
        }


        private List<Item>? items;
        public ReadOnlyCollection<Item>? Items
        {
            get
            {
                return items?.AsReadOnly();
            }
        }

        public int LastId
        {
            get
            {
                if (items?.Any() ?? false)
                {
                    return items?.Select(c =>c.Id)?.Max() ?? 0;
                }
                return 0;
            }
        }
        
        public Item? AddOrUpdate(Item item)
        {
            if(item == null)
            {
                return null;
            }

            var isAdd = false;

            if(item.Id == 0)
            {
                item.Id = LastId + 1;
                isAdd = true;
            }
            if(isAdd)
            {
                items.Add(item);
            }

            return item;
        }

        public bool returnId(int ID)
        {
            var itemToFind = items.Count(c => c.Id == ID);
            if (ID == itemToFind)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            if (items == null)
            {
                return;
            }
        var itemToDelete = items.FirstOrDefault(c => c.Id == id);

            if (itemToDelete != null)
            {
                items.Remove(itemToDelete);
            }
        }
    }
}
