namespace TodoLista.Kontrolki
{
   partial class LoginControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnZalozKonto = new System.Windows.Forms.Button();
         this.btnZaloguj = new System.Windows.Forms.Button();
         this.tbHaslo = new System.Windows.Forms.TextBox();
         this.tbLogin = new System.Windows.Forms.TextBox();
         this.lblHaslo = new System.Windows.Forms.Label();
         this.lblLogin = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.lblWalidacjaLogowania = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnZalozKonto
         // 
         this.btnZalozKonto.BackColor = System.Drawing.Color.LightCyan;
         this.btnZalozKonto.FlatAppearance.BorderSize = 0;
         this.btnZalozKonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnZalozKonto.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnZalozKonto.Location = new System.Drawing.Point(141, 477);
         this.btnZalozKonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnZalozKonto.Name = "btnZalozKonto";
         this.btnZalozKonto.Size = new System.Drawing.Size(228, 78);
         this.btnZalozKonto.TabIndex = 7;
         this.btnZalozKonto.Text = "Załóż konto";
         this.btnZalozKonto.UseVisualStyleBackColor = false;
         this.btnZalozKonto.Click += new System.EventHandler(this.btnZalozKonto_Click);
         // 
         // btnZaloguj
         // 
         this.btnZaloguj.BackColor = System.Drawing.Color.LightCyan;
         this.btnZaloguj.FlatAppearance.BorderSize = 0;
         this.btnZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnZaloguj.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnZaloguj.Location = new System.Drawing.Point(141, 355);
         this.btnZaloguj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.btnZaloguj.Name = "btnZaloguj";
         this.btnZaloguj.Size = new System.Drawing.Size(228, 79);
         this.btnZaloguj.TabIndex = 8;
         this.btnZaloguj.Text = "Zaloguj";
         this.btnZaloguj.UseVisualStyleBackColor = false;
         this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
         // 
         // tbHaslo
         // 
         this.tbHaslo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbHaslo.Location = new System.Drawing.Point(181, 246);
         this.tbHaslo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.tbHaslo.Name = "tbHaslo";
         this.tbHaslo.PasswordChar = '*';
         this.tbHaslo.Size = new System.Drawing.Size(200, 37);
         this.tbHaslo.TabIndex = 5;
         // 
         // tbLogin
         // 
         this.tbLogin.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbLogin.Location = new System.Drawing.Point(181, 187);
         this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.tbLogin.Name = "tbLogin";
         this.tbLogin.Size = new System.Drawing.Size(200, 37);
         this.tbLogin.TabIndex = 6;
         // 
         // lblHaslo
         // 
         this.lblHaslo.AutoSize = true;
         this.lblHaslo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblHaslo.Location = new System.Drawing.Point(94, 249);
         this.lblHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblHaslo.Name = "lblHaslo";
         this.lblHaslo.Size = new System.Drawing.Size(79, 33);
         this.lblHaslo.TabIndex = 3;
         this.lblHaslo.Text = "Hasło:";
         // 
         // lblLogin
         // 
         this.lblLogin.AutoSize = true;
         this.lblLogin.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLogin.Location = new System.Drawing.Point(94, 187);
         this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblLogin.Name = "lblLogin";
         this.lblLogin.Size = new System.Drawing.Size(79, 33);
         this.lblLogin.TabIndex = 4;
         this.lblLogin.Text = "Login:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(110, 31);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(271, 65);
         this.label3.TabIndex = 9;
         this.label3.Text = "Lista zadań";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(31, 96);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(441, 20);
         this.label4.TabIndex = 10;
         this.label4.Text = "________________________________________________";
         // 
         // lblWalidacjaLogowania
         // 
         this.lblWalidacjaLogowania.AutoSize = true;
         this.lblWalidacjaLogowania.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblWalidacjaLogowania.ForeColor = System.Drawing.Color.Red;
         this.lblWalidacjaLogowania.Location = new System.Drawing.Point(137, 297);
         this.lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
         this.lblWalidacjaLogowania.Size = new System.Drawing.Size(229, 24);
         this.lblWalidacjaLogowania.TabIndex = 11;
         this.lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
         this.lblWalidacjaLogowania.Visible = false;
         // 
         // LoginControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSeaGreen;
         this.Controls.Add(this.lblWalidacjaLogowania);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.btnZalozKonto);
         this.Controls.Add(this.btnZaloguj);
         this.Controls.Add(this.tbHaslo);
         this.Controls.Add(this.tbLogin);
         this.Controls.Add(this.lblHaslo);
         this.Controls.Add(this.lblLogin);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "LoginControl";
         this.Size = new System.Drawing.Size(500, 640);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnZalozKonto;
      private System.Windows.Forms.Button btnZaloguj;
      private System.Windows.Forms.TextBox tbHaslo;
      private System.Windows.Forms.TextBox tbLogin;
      private System.Windows.Forms.Label lblHaslo;
      private System.Windows.Forms.Label lblLogin;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lblWalidacjaLogowania;
   }
}
