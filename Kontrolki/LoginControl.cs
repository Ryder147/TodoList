using System;
using System.Windows.Forms;
using TodoLista.Klasy;

namespace TodoLista.Kontrolki
{
   public partial class LoginControl : UserControl
   {
      
      private MainForm _mainForm;

      public LoginControl(MainForm mainForm)
      {
         InitializeComponent();

       
         _mainForm = mainForm;

        
         Dock = DockStyle.Fill;
      }

     
      private void btnZaloguj_Click(object sender, EventArgs e)
      {
        
         if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbHaslo.Text))
         {
            
            lblWalidacjaLogowania.Visible = true;
            
            lblWalidacjaLogowania.Text = "Login i hasło jest wymagane";
            return;
         }

         
         User uzytkownik = _mainForm.UserManager.WyszukajUzytkownika(tbLogin.Text, tbHaslo.Text);
         if (uzytkownik == null)
         {
            
            lblWalidacjaLogowania.Visible = true;
            lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
         }
         
         else
         {
           
            _mainForm.PokazTasksControl(uzytkownik);
         }

      }

      
      private void btnZalozKonto_Click(object sender, EventArgs e)
      {
        
         _mainForm.PokazRegisterControl();
      }
   }
}
