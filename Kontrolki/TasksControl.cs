using System;
using System.Windows.Forms;
using TodoLista.Klasy;
using TodoLista.Formularze;

namespace TodoLista.Kontrolki
{
   public partial class TasksControl : UserControl
   {
      // zmienna na główny formularz
      private MainForm _mainForm;
      private User _zalogowany;
      private TodoTaskManager _todoTaskManager;

      public TasksControl(MainForm mainForm, User user)
      {
         InitializeComponent();
         // przypisujemy przekazany obiket głównego formularza do zmiennej klasy
         _mainForm = mainForm;
         // ustawiamy DockStyle po to, żeby okno zajeło całą dostępną przestnień
         // formularza głównego
         Dock = DockStyle.Fill;
         // przypisujemy przekazanego użytkownika do zmiennej
         _zalogowany = user;
         // wyświetlamy imię użytkownika na labelce
         lblZalogowanyWartosc.Text = _zalogowany.Imie;


         _todoTaskManager = new TodoTaskManager();

         // ładujemy zadania użytkownika z pliku
         _todoTaskManager.ZaladujZadaniaUzytkownika(_zalogowany.Id);

         foreach (TodoTask zadanie in _todoTaskManager.PobierzZadania(_zalogowany.Id))
         {
            DodajZadanieDoListy(zadanie);
         }
      }

      // metoda wyświetlająca zadanie w kontrolce ListView
      private void DodajZadanieDoListy(TodoTask task)
      {
         // kontrolka ListView wyświetla elementy typu ListViewItem
         // pierwsząkolumne podajemy tworząc obiekt
         ListViewItem item = new ListViewItem(task.Id.ToString());
         // kolejne dodajemy jako dodatkowe elementy
         item.SubItems.Add(task.Title);
         // wyznaczamy znak do wyświetlenia
         // jeżeli zadanie skończone to pokazujemy ticzek,
         // jak nie to krzyżyk
         string ready = task.IsFinished ? "✓" : "✕";
         item.SubItems.Add(ready);
         // dodajemy element do listy zadań
         lvZadania.Items.Add(item);
      }

      // metoda wywoływana po kliknięciu przycisku Wyloguj
      private void btnWyloguj_Click(object sender, EventArgs e)
      {
         // wywołujemy metodę z formularza głównego
         // która otwiera okno logowania
         _mainForm.PokazLoginControl();
      }

      // metoda wywoływana po kliknięciu przycisku Dodaj
      private void btnAdd_Click(object sender, EventArgs e)
      {
         // wyznaczamy id dla nowego zadania
         int id = _todoTaskManager.ObliczNastepneId();
         // tworzymy zadanie z nowym id i id użytkownika
         // na razie z pustym tytułem i opisem
         TodoTask newTask = new TodoTask(id, _zalogowany.Id, "", "");
         // tworzymy formularz ze szczegółami zadania
         TaskDetails detailsForm = new TaskDetails(newTask);
         // i go wyświetlamy jako okno dialogowe
         detailsForm.ShowDialog();

         // po zamknięciu sprawdzamy czy zadanie zostało zapisane
         if (detailsForm.CzyZapisano)
         {
            // jeżeli tak to dodajemy zadanie do listy
            _todoTaskManager.DodajZadanie(newTask);
            // i wyświetlamy je
            DodajZadanieDoListy(newTask);
         }
      }

      // metoda wywoływana po kliknięciu przycisku Edytuj
      private void btnEdit_Click(object sender, EventArgs e)
      {
         // sprawdzamy czy zadanie zaznaczone
         if (lvZadania.SelectedItems.Count == 0)
         {
            // jeżeli nie to wyświetlamy komunikat
            MessageBox.Show("Najpierw zaznacz zadanie.", "Informacja", MessageBoxButtons.OK);
         }
         else // jeżeli tak
         {
            // pobieramy id zaznaczonego zadanai - tak samo jak przy usuwaniu
            string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
            // szukamy zadania po id
            TodoTask task = _todoTaskManager.ZnajdzZadanie(int.Parse(taskId));
            // wyświetlamy formularz przekazując zadanie
            TaskDetails detailsForm = new TaskDetails(task);
            detailsForm.ShowDialog();

            // jeżeli zadanie zostało zmodyfikowane
            if (detailsForm.CzyZapisano)
            {
               // to aktualizujemy tytuł i informację czy zadanie zakończone na liście
               _todoTaskManager.AktualizujZadaniaUzytkownika(_zalogowany.Id);
               lvZadania.SelectedItems[0].SubItems[1].Text = task.Title;
               lvZadania.SelectedItems[0].SubItems[2].Text = task.IsFinished ? "✓" : "✕";
            }
         }
      }

      // metoda wywoływana po kliknięciu przycisku Usuń
      private void btnDelete_Click(object sender, EventArgs e)
      {
         // sprawdzamy czy jest zaznaczone jakieś zadanie na liście
         if (lvZadania.SelectedItems.Count == 0)
         {
            // jeżeli nie to wyświetlamy messagebox z komunikatem
            MessageBox.Show("Nie wybrano zadania do skasowania.", "Informacja", MessageBoxButtons.OK);
         }
         else
         {
            // pobieramy z pierwszego zaznaczonego zadania
            // (można zaznaczyć tylko jedno bo tak skonfigurowaliśmy listę)
            // pierwszą kolumnę (czyli Id)
            string zaznaczoneZadanie = lvZadania.SelectedItems[0].SubItems[0].Text;
            // przekazujemy menadzerowi zadanie do usunięcia
            _todoTaskManager.UsunZadanie(int.Parse(zaznaczoneZadanie));
            // usuwamy zadanie także z listy
            lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
         }
      }
   }
}
