using System;
using System.Windows.Forms;
using TodoLista.Klasy;
using TodoLista.Formularze;

namespace TodoLista.Kontrolki
{
   public partial class TasksControl : UserControl
   {
     
      private MainForm _mainForm;
      private User _zalogowany;
      private TodoTaskManager _todoTaskManager;

      public TasksControl(MainForm mainForm, User user)
      {
         InitializeComponent();
         
         _mainForm = mainForm;
        
         Dock = DockStyle.Fill;
         
         _zalogowany = user;
        
         lblZalogowanyWartosc.Text = _zalogowany.Imie;


         _todoTaskManager = new TodoTaskManager();

         
         _todoTaskManager.ZaladujZadaniaUzytkownika(_zalogowany.Id);

         foreach (TodoTask zadanie in _todoTaskManager.PobierzZadania(_zalogowany.Id))
         {
            DodajZadanieDoListy(zadanie);
         }
      }

      
      private void DodajZadanieDoListy(TodoTask task)
      {
         
         ListViewItem item = new ListViewItem(task.Id.ToString());
       
         item.SubItems.Add(task.Title);
       
         string ready = task.IsFinished ? "✓" : "✕";
         item.SubItems.Add(ready);
      
         lvZadania.Items.Add(item);
      }

    
      private void btnWyloguj_Click(object sender, EventArgs e)
      {
       
         _mainForm.PokazLoginControl();
      }

      
      private void btnAdd_Click(object sender, EventArgs e)
      {
        
         int id = _todoTaskManager.ObliczNastepneId();
        
         TodoTask newTask = new TodoTask(id, _zalogowany.Id, "", "");
       
         TaskDetails detailsForm = new TaskDetails(newTask);
        
         detailsForm.ShowDialog();

        
         if (detailsForm.CzyZapisano)
         {
          
            _todoTaskManager.DodajZadanie(newTask);
            
            DodajZadanieDoListy(newTask);
         }
      }

     
      private void btnEdit_Click(object sender, EventArgs e)
      {
        
         if (lvZadania.SelectedItems.Count == 0)
         {
           
            MessageBox.Show("Najpierw zaznacz zadanie.", "Informacja", MessageBoxButtons.OK);
         }
         else 
         {
            
            string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
            
            TodoTask task = _todoTaskManager.ZnajdzZadanie(int.Parse(taskId));
          
            TaskDetails detailsForm = new TaskDetails(task);
            detailsForm.ShowDialog();

            if (detailsForm.CzyZapisano)
            {
               
               _todoTaskManager.AktualizujZadaniaUzytkownika(_zalogowany.Id);
               lvZadania.SelectedItems[0].SubItems[1].Text = task.Title;
               lvZadania.SelectedItems[0].SubItems[2].Text = task.IsFinished ? "✓" : "✕";
            }
         }
      }

    
      private void btnDelete_Click(object sender, EventArgs e)
      {
         
         if (lvZadania.SelectedItems.Count == 0)
         {
        
            MessageBox.Show("Nie wybrano zadania do skasowania.", "Informacja", MessageBoxButtons.OK);
         }
         else
         {
           
            string zaznaczoneZadanie = lvZadania.SelectedItems[0].SubItems[0].Text;
            
            _todoTaskManager.UsunZadanie(int.Parse(zaznaczoneZadanie));
           
            lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
         }
      }
   }
}
