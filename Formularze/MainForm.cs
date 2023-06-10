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

         // przy uruchomieniu aplikacji pokazujemy panel logowania
         PokazLoginControl();
      }

      // metoda wyświetlająca okno logowania
      public void PokazLoginControl() 
      {
         // czyścimy wszystkie kontrolki
         Controls.Clear();
         // tworzymy nowy obiekt okna logowania
         // do konstruktora przekazując główny formularz przez słowo this
         // dlatego, że aktualnie jesteśmy wewnątrz klasy formularza
         // a this odnosi się do obiektu w którym się znajdujemy
         // nowo utworzony obiekt okna dodajemy do kontrolek formularza
         Controls.Add(new LoginControl(this));
      }

      // metoda wyświetlająca okno rejestracji
      public void PokazRegisterControl()
      {
         // czyścimy wszystkie kontrolki
         Controls.Clear();
         // tworzymy nowy obiekt okna rejestracji
         // do konstruktora przekazując główny formularz przez słowo this
         // dlatego, że aktualnie jesteśmy wewnątrz klasy formularza
         // a this odnosi się do obiektu w którym się znajdujemy
         // nowo utworzony obiekt okna dodajemy do kontrolek formularza
         Controls.Add(new RegisterControl(this));
      }

      // metoda wyświetlająca okno zadań
      public void PokazTasksControl(User user)
      {
         // czyścimy wszystkie kontrolki
         Controls.Clear();
         // tworzymy nowy obiekt okna zadań
         // do konstruktora przekazując główny formularz przez słowo this
         // dlatego, że aktualnie jesteśmy wewnątrz klasy formularza
         // a this odnosi się do obiektu w którym się znajdujemy
         // nowo utworzony obiekt okna dodajemy do kontrolek formularza
         Controls.Add(new TasksControl(this, user));
      }
   }
}
