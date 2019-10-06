namespace SafetyTech
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.Ingresobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Usuario";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(348, 153);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(107, 22);
            this.Usertxt.TabIndex = 1;
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(348, 185);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(107, 22);
            this.Passtxt.TabIndex = 1;
            // 
            // Ingresobtn
            // 
            this.Ingresobtn.Location = new System.Drawing.Point(334, 229);
            this.Ingresobtn.Name = "Ingresobtn";
            this.Ingresobtn.Size = new System.Drawing.Size(133, 34);
            this.Ingresobtn.TabIndex = 2;
            this.Ingresobtn.Text = "Ingresar";
            this.Ingresobtn.UseVisualStyleBackColor = true;
            this.Ingresobtn.Click += new System.EventHandler(this.Ingresobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bienvenido, Gerente";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(569, 322);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(193, 52);
            this.Nextbtn.TabIndex = 4;
            this.Nextbtn.Text = "Siguiente";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ingresobtn);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.Button Ingresobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nextbtn;
    }
}

