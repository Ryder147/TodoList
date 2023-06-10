using System;

namespace TodoLista.Klasy
{
  
   public class User
   {
      

      public Guid Id;

      public string Imie;

      public string Login;

      public string Haslo;

      public User(Guid id, string imie, string login, string haslo)
      {
         Id = id;
         Imie = imie;
         Login = login;
         Haslo = haslo;
      }
   }
}
