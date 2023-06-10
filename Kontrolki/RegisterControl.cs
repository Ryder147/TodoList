using System;
using System.Windows.Forms;
using TodoLista.Klasy;

namespace TodoLista.Kontrolki
{
   public partial class RegisterControl : UserControl
   {
      // zmienna na główny formularz
      private MainForm _mainForm;

      public RegisterControl(MainForm mainForm)
      {
         InitializeComponent();

         // przypisujemy przekazany obiket głównego formularza do zmiennej klasy
         _mainForm = mainForm;

         // ustawiamy DockStyle po to, żeby okno zajeło całą dostępną przestnień
         // formularza głównego
         Dock = DockStyle.Fill;
      }

      // metoda wywoływana po kliknięciu przycisku Powrót
      private void btnCofnij_Click(object sender, EventArgs e)
      {
         // wywołujemy metodę z formularza głównego
         // która otwiera okno logowania
         _mainForm.PokazLoginControl();
      }

      // metoda wywoływana po kliknięciu przycisku Zarejestruj
      private void btnZarejestruj_Click(object sender, EventArgs e)
      {
         if (Waliduj())
         {
            User newUser = new User(Guid.NewGuid(), tbImie.Text, tbLogin.Text, tbHaslo.Text);
            _mainForm.UserManager.AddUser(newUser);
            // wywołujemy metodę z formularza głównego
            // która otwiera okno z zadaniami
            _mainForm.PokazTasksControl(newUser);
         }
      }

      // dodatkowa opcja
      private bool Waliduj()
      {
         // na początku ukrywamy wszystkie kontrolki walidacyjne
         lblLoginValidation.Visible = false;
         lblNameValidation.Visible = false;
         lblPasswordValidation.Visible = false;
         lblRepeatPasswordValidation.Visible = false;

         // zmienna pomocnicza określająca czy wszystko jest poprawnie uzupełnione
         bool czyWszystkoPoprawne = true;

         // sprawdzamy imię
         if (string.IsNullOrWhiteSpace(tbImie.Text))
         {
            lblNameValidation.Text = "Imię jest wymagane";
            lblNameValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         // sprawdzamy login
         if (string.IsNullOrWhiteSpace(tbLogin.Text))
         {
            lblLoginValidation.Text = "Login jest wymagany";
            lblLoginValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }
         // oraz czy login wolny
         else if (!_mainForm.UserManager.CzyLoginWolny(tbLogin.Text))
         {
            lblLoginValidation.Text = "Podany login jest już zajęty";
            lblLoginValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         // czy hasło podane
         if (string.IsNullOrWhiteSpace(tbHaslo.Text))
         {
            lblPasswordValidation.Text = "Hasło jest wymagane";
            lblPasswordValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         // czy powtórzone hasło podane
         if (string.IsNullOrWhiteSpace(tbPowtorzHaslo.Text))
         {
            lblRepeatPasswordValidation.Text = "Powtórzenie hasła jest wymagane";
            lblRepeatPasswordValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         // czy podane hasła są takie same, jeżeli zostały wpisane
         if (!string.IsNullOrWhiteSpace(tbHaslo.Text) && !string.IsNullOrWhiteSpace(tbPowtorzHaslo.Text))
         {
            if (tbHaslo.Text != tbPowtorzHaslo.Text)
            {
               lblRepeatPasswordValidation.Text = "Podane hasła są różne";
               lblRepeatPasswordValidation.Visible = true;
               czyWszystkoPoprawne = false;
            }
         }

         return czyWszystkoPoprawne;
      }

   }
}
