using System.Windows.Forms;
using TodoLista.Klasy;
using TodoLista.Kontrolki;

namespace TodoLista
{
   public partial class MainForm : Form
   {
      public UserManager UserManager;

      public MainForm()
      {
         InitializeComponent();
         UserManager = new UserManager();

         
         PokazLoginControl();
      }

      
      public void PokazLoginControl() 
      {
         
         Controls.Clear();
         
         Controls.Add(new LoginControl(this));
      }

      
      public void PokazRegisterControl()
      {
         
         Controls.Clear();
         
         Controls.Add(new RegisterControl(this));
      }

      
      public void PokazTasksControl(User user)
      {
         
         Controls.Clear();
         
         Controls.Add(new TasksControl(this, user));
      }
   }
}
