using System;

namespace TodoLista.Klasy
{
   // klasa przechowująca dane użytkownika
   public class User
   {
      // identyfikator dzięki, któremu będzimy mogli przypisywać
      // zadania do użytkownika
      // przypomnieć co to za tym danych

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
