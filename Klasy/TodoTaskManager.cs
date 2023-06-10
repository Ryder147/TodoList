using System;
using System.Collections.Generic;

namespace TodoLista.Klasy
{
 
   public class TodoTaskManager
   {
      
      private List<TodoTask> _wszystkieZadania;

      
      public TodoTaskManager()
      {
         
         _wszystkieZadania = new List<TodoTask>();
      }

      
      public TodoTask ZnajdzZadanie(int id)
      {
         
         foreach (TodoTask task in _wszystkieZadania)
         {
            
            if (task.Id == id)
            {
               return task;
            }
         }
        
         return null;
      }

      
      public void DodajZadanie(TodoTask task)
      {
         _wszystkieZadania.Add(task);
         AktualizujZadaniaUzytkownika(task.UserId);
      }

      
      public void UsunZadanie(int taskId)
      {
         TodoTask task = ZnajdzZadanie(taskId);
         _wszystkieZadania.Remove(task);
         AktualizujZadaniaUzytkownika(task.UserId);
      }

      
      public List<TodoTask> PobierzZadania(Guid idZalogowanego)
      {
         
         List<TodoTask> zadaniaZalogowanego = new List<TodoTask>();
         foreach (TodoTask zadanie in _wszystkieZadania)
         {
            if (zadanie.UserId == idZalogowanego)
            {
               zadaniaZalogowanego.Add(zadanie);
            }
         }
         return zadaniaZalogowanego;
      }

      
      public int ObliczNastepneId()
      {
         
         int max = 0;
         
         foreach (TodoTask task in _wszystkieZadania)
         {
            
            if (task.Id > max)
            {
               
               max = task.Id;
            }
         }
    
         return max + 1;
      }

      public void ZaladujZadaniaUzytkownika(Guid userId)
      {
         _wszystkieZadania = FileHelper.ZaładujZadania(userId);
      }

      public void AktualizujZadaniaUzytkownika(Guid userId)
      {
         FileHelper.ZapiszZadania(_wszystkieZadania, userId);
      }
   }
}
