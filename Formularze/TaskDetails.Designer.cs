namespace TodoLista.Formularze
{
   partial class TaskDetails
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblNumberText = new System.Windows.Forms.Label();
         this.lblTitle = new System.Windows.Forms.Label();
         this.lblDescription = new System.Windows.Forms.Label();
         this.cbIsReady = new System.Windows.Forms.CheckBox();
         this.lblNumber = new System.Windows.Forms.Label();
         this.tbName = new System.Windows.Forms.TextBox();
         this.tbDescription = new System.Windows.Forms.TextBox();
         this.btnSave = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblNumberText
         // 
         this.lblNumberText.AutoSize = true;
         this.lblNumberText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNumberText.Location = new System.Drawing.Point(12, 21);
         this.lblNumberText.Name = "lblNumberText";
         this.lblNumberText.Size = new System.Drawing.Size(52, 18);
         this.lblNumberText.TabIndex = 0;
         this.lblNumberText.Text = "Numer:";
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.Location = new System.Drawing.Point(12, 55);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(54, 18);
         this.lblTitle.TabIndex = 1;
         this.lblTitle.Text = "Nazwa:";
         // 
         // lblDescription
         // 
         this.lblDescription.AutoSize = true;
         this.lblDescription.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDescription.Location = new System.Drawing.Point(28, 92);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.Size = new System.Drawing.Size(38, 18);
         this.lblDescription.TabIndex = 2;
         this.lblDescription.Text = "Opis:";
         // 
         // cbIsReady
         // 
         this.cbIsReady.AutoSize = true;
         this.cbIsReady.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbIsReady.Location = new System.Drawing.Point(329, 53);
         this.cbIsReady.Name = "cbIsReady";
         this.cbIsReady.Size = new System.Drawing.Size(123, 22);
         this.cbIsReady.TabIndex = 4;
         this.cbIsReady.Text = "Czy zakończone?";
         this.cbIsReady.UseVisualStyleBackColor = true;
         // 
         // lblNumber
         // 
         this.lblNumber.AutoSize = true;
         this.lblNumber.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNumber.Location = new System.Drawing.Point(70, 21);
         this.lblNumber.Name = "lblNumber";
         this.lblNumber.Size = new System.Drawing.Size(32, 18);
         this.lblNumber.TabIndex = 0;
         this.lblNumber.Text = "123";
         // 
         // tbName
         // 
         this.tbName.Location = new System.Drawing.Point(73, 54);
         this.tbName.Name = "tbName";
         this.tbName.Size = new System.Drawing.Size(250, 20);
         this.tbName.TabIndex = 5;
         // 
         // tbDescription
         // 
         this.tbDescription.Location = new System.Drawing.Point(73, 92);
         this.tbDescription.Multiline = true;
         this.tbDescription.Name = "tbDescription";
         this.tbDescription.Size = new System.Drawing.Size(379, 70);
         this.tbDescription.TabIndex = 5;
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.LightGreen;
         this.btnSave.FlatAppearance.BorderSize = 0;
         this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.Location = new System.Drawing.Point(458, 55);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 107);
         this.btnSave.TabIndex = 6;
         this.btnSave.Text = "💾";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // TaskDetails
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSeaGreen;
         this.ClientSize = new System.Drawing.Size(548, 176);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.tbDescription);
         this.Controls.Add(this.tbName);
         this.Controls.Add(this.cbIsReady);
         this.Controls.Add(this.lblDescription);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.lblNumber);
         this.Controls.Add(this.lblNumberText);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "TaskDetails";
         this.Text = "Zadanie";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblNumberText;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.CheckBox cbIsReady;
      private System.Windows.Forms.Label lblNumber;
      private System.Windows.Forms.TextBox tbName;
      private System.Windows.Forms.TextBox tbDescription;
      private System.Windows.Forms.Button btnSave;
   }
}