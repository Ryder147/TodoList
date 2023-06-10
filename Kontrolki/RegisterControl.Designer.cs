namespace TodoLista.Kontrolki
{
   partial class RegisterControl
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
            this.btnCofnij = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblPowtorzHaslo = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.lblNameValidation = new System.Windows.Forms.Label();
            this.lblRepeatPasswordValidation = new System.Windows.Forms.Label();
            this.lblLoginValidation = new System.Windows.Forms.Label();
            this.lblPasswordValidation = new System.Windows.Forms.Label();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCofnij
            // 
            this.btnCofnij.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCofnij.FlatAppearance.BorderSize = 0;
            this.btnCofnij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofnij.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCofnij.Location = new System.Drawing.Point(20, 21);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(98, 68);
            this.btnCofnij.TabIndex = 1;
            this.btnCofnij.Text = "🢨";
            this.btnCofnij.UseVisualStyleBackColor = false;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(179, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 63);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Rejestracja";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(85, 139);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(88, 31);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaslo.Location = new System.Drawing.Point(85, 226);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(92, 31);
            this.lblHaslo.TabIndex = 4;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblPowtorzHaslo
            // 
            this.lblPowtorzHaslo.AutoSize = true;
            this.lblPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowtorzHaslo.Location = new System.Drawing.Point(1, 313);
            this.lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            this.lblPowtorzHaslo.Size = new System.Drawing.Size(193, 31);
            this.lblPowtorzHaslo.TabIndex = 4;
            this.lblPowtorzHaslo.Text = "Powtórz hasło:";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImie.Location = new System.Drawing.Point(99, 56);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(73, 31);
            this.lblImie.TabIndex = 4;
            this.lblImie.Text = "Imię:";
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.BackColor = System.Drawing.Color.LightGreen;
            this.btnZarejestruj.FlatAppearance.BorderSize = 0;
            this.btnZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZarejestruj.Location = new System.Drawing.Point(147, 538);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(246, 86);
            this.btnZarejestruj.TabIndex = 5;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = false;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(200, 136);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(251, 38);
            this.tbLogin.TabIndex = 6;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHaslo.Location = new System.Drawing.Point(200, 223);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(251, 38);
            this.tbHaslo.TabIndex = 7;
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(200, 306);
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.PasswordChar = '*';
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(251, 38);
            this.tbPowtorzHaslo.TabIndex = 7;
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImie.Location = new System.Drawing.Point(200, 56);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(251, 38);
            this.tbImie.TabIndex = 7;
            // 
            // lblNameValidation
            // 
            this.lblNameValidation.AutoEllipsis = true;
            this.lblNameValidation.AutoSize = true;
            this.lblNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblNameValidation.Location = new System.Drawing.Point(195, 96);
            this.lblNameValidation.Name = "lblNameValidation";
            this.lblNameValidation.Size = new System.Drawing.Size(193, 25);
            this.lblNameValidation.TabIndex = 8;
            this.lblNameValidation.Text = "Labelka na walidacje";
            this.lblNameValidation.Visible = false;
            // 
            // lblRepeatPasswordValidation
            // 
            this.lblRepeatPasswordValidation.AutoEllipsis = true;
            this.lblRepeatPasswordValidation.AutoSize = true;
            this.lblRepeatPasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblRepeatPasswordValidation.Location = new System.Drawing.Point(195, 347);
            this.lblRepeatPasswordValidation.Name = "lblRepeatPasswordValidation";
            this.lblRepeatPasswordValidation.Size = new System.Drawing.Size(193, 25);
            this.lblRepeatPasswordValidation.TabIndex = 9;
            this.lblRepeatPasswordValidation.Text = "Labelka na walidacje";
            this.lblRepeatPasswordValidation.Visible = false;
            // 
            // lblLoginValidation
            // 
            this.lblLoginValidation.AutoEllipsis = true;
            this.lblLoginValidation.AutoSize = true;
            this.lblLoginValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginValidation.ForeColor = System.Drawing.Color.Red;
            this.lblLoginValidation.Location = new System.Drawing.Point(195, 177);
            this.lblLoginValidation.Name = "lblLoginValidation";
            this.lblLoginValidation.Size = new System.Drawing.Size(193, 25);
            this.lblLoginValidation.TabIndex = 9;
            this.lblLoginValidation.Text = "Labelka na walidacje";
            this.lblLoginValidation.Visible = false;
            // 
            // lblPasswordValidation
            // 
            this.lblPasswordValidation.AutoEllipsis = true;
            this.lblPasswordValidation.AutoSize = true;
            this.lblPasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidation.Location = new System.Drawing.Point(195, 264);
            this.lblPasswordValidation.Name = "lblPasswordValidation";
            this.lblPasswordValidation.Size = new System.Drawing.Size(193, 25);
            this.lblPasswordValidation.TabIndex = 9;
            this.lblPasswordValidation.Text = "Labelka na walidacje";
            this.lblPasswordValidation.Visible = false;
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.tbPowtorzHaslo);
            this.groupBoxUserData.Controls.Add(this.lblPasswordValidation);
            this.groupBoxUserData.Controls.Add(this.lblLogin);
            this.groupBoxUserData.Controls.Add(this.lblLoginValidation);
            this.groupBoxUserData.Controls.Add(this.lblHaslo);
            this.groupBoxUserData.Controls.Add(this.lblRepeatPasswordValidation);
            this.groupBoxUserData.Controls.Add(this.lblPowtorzHaslo);
            this.groupBoxUserData.Controls.Add(this.lblNameValidation);
            this.groupBoxUserData.Controls.Add(this.lblImie);
            this.groupBoxUserData.Controls.Add(this.tbImie);
            this.groupBoxUserData.Controls.Add(this.tbLogin);
            this.groupBoxUserData.Controls.Add(this.tbHaslo);
            this.groupBoxUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserData.Location = new System.Drawing.Point(20, 107);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Size = new System.Drawing.Size(458, 412);
            this.groupBoxUserData.TabIndex = 10;
            this.groupBoxUserData.TabStop = false;
            this.groupBoxUserData.Text = "Dane nowego użytkownika";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCofnij);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(600, 680);
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnCofnij;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label lblLogin;
      private System.Windows.Forms.Label lblHaslo;
      private System.Windows.Forms.Label lblPowtorzHaslo;
      private System.Windows.Forms.Label lblImie;
      private System.Windows.Forms.Button btnZarejestruj;
      private System.Windows.Forms.TextBox tbLogin;
      private System.Windows.Forms.TextBox tbHaslo;
      private System.Windows.Forms.TextBox tbPowtorzHaslo;
      private System.Windows.Forms.TextBox tbImie;
      private System.Windows.Forms.Label lblNameValidation;
      private System.Windows.Forms.Label lblRepeatPasswordValidation;
      private System.Windows.Forms.Label lblLoginValidation;
      private System.Windows.Forms.Label lblPasswordValidation;
      private System.Windows.Forms.GroupBox groupBoxUserData;
   }
}
