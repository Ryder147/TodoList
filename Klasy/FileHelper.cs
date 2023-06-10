using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TodoLista.Klasy
{
   // do zrobienia jako dodatkowa opcja, bazowo realizowane przechowywanie danych w pamięci
   public static class FileHelper
   {
      // zmienna ze śceiżką do folderu gdzie będziemy zapisywać zadania i użytkownikaów
      private static string _basePath = $@"{AppDomain.CurrentDomain.BaseDirectory}/data/";

      public static List<TodoTask> ZaładujZadania(Guid userId)
      {
         List<TodoTask> todoTasks = new List<TodoTask>();
         // tworzymy ścieżkę do pliku
         string filePath = $@"{_basePath}{userId}.txt";

         // sprawdzamy czy taki plik istnieje
         if (File.Exists(filePath))
         {
            // jeżeli tak to czytamy go linia po lini
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               // pobieramy dane zadania
               string[] columns = line.Split('|');
               int id = int.Parse(columns[0]);
               string title = columns[1];
               bool isFinished = bool.Parse(columns[2]);
               string description = columns[3];
               // tworzymy zadania
               TodoTask task = new TodoTask(id, userId, title, description);
               task.IsFinished = isFinished;
               todoTasks.Add(task);
            }
            reader.Close();
         }
         return todoTasks;
      }

      public static void ZapiszZadania(List<TodoTask> tasks, Guid userId)
      {
         string filePath = $"{_basePath}{userId}.txt";
         // tworzy specjalny obiekt do sklejania tekstów
         StringBuilder builder = new StringBuilder();

         foreach (TodoTask task in tasks)
         {
            // zapisujemy każde zadanie jako osobną linie,
            // gdzie poszczególne dane oddzielone są znakiem |
            builder.AppendLine($"{task.Id}|{task.Title}|{task.IsFinished}|{task.Description}");
         }
         // zapisujem wszystko w pliku
         File.WriteAllText(filePath, builder.ToString());
      }

      public static void ZapiszUzytkownika(User user)
      {
         string filePath = $"{_basePath}users.txt";
         string line = $"{user.Id}|{user.Login}|{user.Imie}|{user.Haslo}{Environment.NewLine}";

         if (!Directory.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}/data"))
         {
            Directory.CreateDirectory($@"{AppDomain.CurrentDomain.BaseDirectory}/data");
         }
         File.AppendAllText(filePath, line);
      }

      public static List<User> ZaladujUzytkownikow()
      {
         List<User> appUsers = new List<User>();
         string filePath = $"{_basePath}users.txt";

         if (File.Exists(filePath))
         {
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               string[] columns = line.Split('|');

               Guid id = Guid.Parse(columns[0]);
               string login = columns[1];
               string name = columns[2];
               string password = columns[3];
               User user = new User(id, name, login, password);
               appUsers.Add(user);
            }
            reader.Close();
         }
         return appUsers;
      }
   }
}
