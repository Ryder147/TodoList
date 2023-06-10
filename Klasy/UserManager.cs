using System.Collections.Generic;

namespace TodoLista.Klasy
{
   // klasa zarządcy użytkowników w aplikacji
   public class UserManager
   {
      // lista użytkowników aplikacji
      // prywatna po to, aby tylko z tej klasy można było ją modyfikować
      private List<User> _users;

      // konstruktor
      public UserManager()
      {
         // stworzenie pustej listy
         _users = FileHelper.ZaladujUzytkownikow();
      }

      // metoda WyszukajUzytkownika zwraca użytkownika
      // o podanym loginie i haśle jeżeli istnieje taki na liście
      // jeżeli nie istnieje to zwraca nulla
      // wykorzystamy ją do logowania
      public User WyszukajUzytkownika(string login, string haslo)
      {
         // iterujemy po wszystkich użytkownikach
         foreach (User user in _users)
         {
            // jezeli użytkownik z listy ma takei samo hasło i login
            if (user.Login == login && user.Haslo == haslo)
            {
               // to go zwracamy
               return user;
            }
         }
         // jak nie ma żadnego pasującego użytkownika
         // to zwracamy null
         return null;
      }

      // metoda do sprawdzania czy podany login jest wolny
      // w aplikacji nie możemy mieć dwóch użytkowników
      // z tym samym loginem, więc zanim zapiszemy nowego użytkownika
      //  to musimy sprawdzić czy już taki nie istnieje
      public bool CzyLoginWolny(string login)
      {
         // iterujemy po liście użytkowników
         foreach (User user in _users)
         {
            // jeżeli użytkownik z listy ma podany login
            if (user.Login == login)
            {
               // to zwracamy fałsz
               return false;
            }
         }
         // jak nie ma takiego użytkownika to zwracamy informację
         // że login jest wolny

         return true;
      }

      // ponieważ lista użytkowników jest prywatna
      // dodajemy publiczną metodę do dodania nowego użytkownika
      public void AddUser(User user)
      {
         FileHelper.ZapiszUzytkownika(user);
         _users = FileHelper.ZaladujUzytkownikow();
      }

   }
}
