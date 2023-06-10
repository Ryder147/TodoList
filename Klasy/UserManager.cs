using System.Collections.Generic;

namespace TodoLista.Klasy
{
  
   public class UserManager
   {
      
      private List<User> _users;

      
      public UserManager()
      {
         
         _users = FileHelper.ZaladujUzytkownikow();
      }

     
      public User WyszukajUzytkownika(string login, string haslo)
      {
         
         foreach (User user in _users)
         {
            
            if (user.Login == login && user.Haslo == haslo)
            {
              
               return user;
            }
         }
        
         return null;
      }

     
      public bool CzyLoginWolny(string login)
      {
        
         foreach (User user in _users)
         {
           
            if (user.Login == login)
            {
              
               return false;
            }
         }
         

         return true;
      }

      
      public void AddUser(User user)
      {
         FileHelper.ZapiszUzytkownika(user);
         _users = FileHelper.ZaladujUzytkownikow();
      }

   }
}
