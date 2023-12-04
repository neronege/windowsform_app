using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_exercise
{
    public static class SanalDatabase
    {
       public static List<todoList> todoLists = new List<todoList>();

      public static void ListEkle(todoList data)
        {
            todoLists.Add(data);
        }

        public static List<todoList> listele()
        {
            foreach (var item in todoLists)
            {
                item.ToString();
            }
            return todoLists;
        }
    }
}
