using System;
using System.Windows.Forms;
using TodoLista.Klasy;

namespace TodoLista.Formularze
{
   public partial class TaskDetails : Form
   {
      public TodoTask TodoTask;

      public bool CzyZapisano;

      public TaskDetails(TodoTask zadanie)
      {
         InitializeComponent();
         TodoTask = zadanie;
         lblNumber.Text = zadanie.Id.ToString();
         tbName.Text = zadanie.Title;
         tbDescription.Text = zadanie.Description;
         cbIsReady.Checked = zadanie.IsFinished;
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         TodoTask.Description = tbDescription.Text;
         TodoTask.Title = tbName.Text;
         TodoTask.IsFinished = cbIsReady.Checked;
         CzyZapisano = true;
         Close();
      }
   }
}
