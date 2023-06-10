using System;
using System.Windows.Forms;
using TodoLista.Klasy;

namespace TodoLista.Kontrolki
{
   public partial class RegisterControl : UserControl
   {
      
      private MainForm _mainForm;

      public RegisterControl(MainForm mainForm)
      {
         InitializeComponent();

        
         _mainForm = mainForm;

        
         Dock = DockStyle.Fill;
      }

      
      private void btnCofnij_Click(object sender, EventArgs e)
      {
        
         _mainForm.PokazLoginControl();
      }

      
      private void btnZarejestruj_Click(object sender, EventArgs e)
      {
         if (Waliduj())
         {
            User newUser = new User(Guid.NewGuid(), tbImie.Text, tbLogin.Text, tbHaslo.Text);
            _mainForm.UserManager.AddUser(newUser);
            
            _mainForm.PokazTasksControl(newUser);
         }
      }

      
      private bool Waliduj()
      {
        
         lblLoginValidation.Visible = false;
         lblNameValidation.Visible = false;
         lblPasswordValidation.Visible = false;
         lblRepeatPasswordValidation.Visible = false;

         
         bool czyWszystkoPoprawne = true;

         
         if (string.IsNullOrWhiteSpace(tbImie.Text))
         {
            lblNameValidation.Text = "Imię jest wymagane";
            lblNameValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         
         if (string.IsNullOrWhiteSpace(tbLogin.Text))
         {
            lblLoginValidation.Text = "Login jest wymagany";
            lblLoginValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }
         
         else if (!_mainForm.UserManager.CzyLoginWolny(tbLogin.Text))
         {
            lblLoginValidation.Text = "Podany login jest już zajęty";
            lblLoginValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         
         if (string.IsNullOrWhiteSpace(tbHaslo.Text))
         {
            lblPasswordValidation.Text = "Hasło jest wymagane";
            lblPasswordValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

        
         if (string.IsNullOrWhiteSpace(tbPowtorzHaslo.Text))
         {
            lblRepeatPasswordValidation.Text = "Powtórzenie hasła jest wymagane";
            lblRepeatPasswordValidation.Visible = true;
            czyWszystkoPoprawne = false;
         }

         
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
