using System;

namespace TodoLista.Klasy
{
   public class TodoTask
   {
      public int Id;

      public Guid UserId;

      public string Title;

      public string Description;

      public bool IsFinished;

      public TodoTask(int number, Guid userId, string title, string desc)
      {
         Id = number;
         UserId = userId;
         Title = title;
         Description = desc;
         IsFinished = false;
      }
   }
}
