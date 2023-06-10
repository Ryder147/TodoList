using System;
using System.Windows.Forms;
using TodoLista.Klasy;

namespace TodoLista.Kontrolki
{
   public partial class LoginControl : UserControl
   {
      // zmienna na główny formularz
      private MainForm _mainForm;

      public LoginControl(MainForm mainForm)
      {
         InitializeComponent();

         // przypisujemy przekazany obiket głównego formularza do zmiennej klasy
         _mainForm = mainForm;

         // ustawiamy DockStyle po to, żeby okno zajeło całą dostępną przestnień
         // formularza głównego
         Dock = DockStyle.Fill;
      }

      // metoda wywoływana po kliknięciu przycisku Zaloguj
      private void btnZaloguj_Click(object sender, EventArgs e)
      {
         // sprawdzamy czy login lub hasło nie są czasem puste
         if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbHaslo.Text))
         {
            // jeżeli tak to pokazujemy labelkę na walidacje
            lblWalidacjaLogowania.Visible = true;
            // i ustawiamy tekst
            lblWalidacjaLogowania.Text = "Login i hasło jest wymagane";
            return;
         }

         // jeżeli login i hasło podane to sprawdzamy czy taki użytkownik
         // istnieje za pomoca metody do wyszukiwania użytkowników
         // wiemy, że jak zwróci null to nie ma takiego użytkownika
         User uzytkownik = _mainForm.UserManager.WyszukajUzytkownika(tbLogin.Text, tbHaslo.Text);
         if (uzytkownik == null)
         {
            // jak null to pokazujemy błąd
            lblWalidacjaLogowania.Visible = true;
            lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
         }
         // jeżeli taki użytkownik istnieje
         else
         {
            // wywołujemy metodę z formularza głównego
            // która otwiera okno logowania
            _mainForm.PokazTasksControl(uzytkownik);
         }

      }

      // metoda wywoływana po kliknięciu przycisku Zarejestruj
      private void btnZalozKonto_Click(object sender, EventArgs e)
      {
         // wywołujemy metodę z formularza głównego
         // która otwiera okno logowania
         _mainForm.PokazRegisterControl();
      }
   }
}
