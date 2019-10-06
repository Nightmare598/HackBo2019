namespace SafetyTech
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtoreal = new System.Windows.Forms.Label();
            this.bREINICIAL = new System.Windows.Forms.Button();
            this.bCOMPARAR = new System.Windows.Forms.Button();
            this.mtosistema = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto Caja Sistema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto Caja Real";
            // 
            // mtoreal
            // 
            this.mtoreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtoreal.Location = new System.Drawing.Point(538, 200);
            this.mtoreal.Name = "mtoreal";
            this.mtoreal.Size = new System.Drawing.Size(184, 77);
            this.mtoreal.TabIndex = 2;
            this.mtoreal.Text = "mtoreal";
            // 
            // bREINICIAL
            // 
            this.bREINICIAL.Location = new System.Drawing.Point(514, 337);
            this.bREINICIAL.Name = "bREINICIAL";
            this.bREINICIAL.Size = new System.Drawing.Size(187, 52);
            this.bREINICIAL.TabIndex = 4;
            this.bREINICIAL.Text = "REINICIAR CONTEO";
            this.bREINICIAL.UseVisualStyleBackColor = true;
            // 
            // bCOMPARAR
            // 
            this.bCOMPARAR.Location = new System.Drawing.Point(514, 279);
            this.bCOMPARAR.Name = "bCOMPARAR";
            this.bCOMPARAR.Size = new System.Drawing.Size(187, 52);
            this.bCOMPARAR.TabIndex = 5;
            this.bCOMPARAR.Text = "COMPARAR";
            this.bCOMPARAR.UseVisualStyleBackColor = true;
            this.bCOMPARAR.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mtosistema
            // 
            this.mtosistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtosistema.Location = new System.Drawing.Point(57, 233);
            this.mtosistema.Name = "mtosistema";
            this.mtosistema.Size = new System.Drawing.Size(292, 139);
            this.mtosistema.TabIndex = 6;
            this.mtosistema.Click += new System.EventHandler(this.Mtosistema_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione la caja a comparar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Caja 1",
            "Caja 2",
            "Caja 3",
            "Caja 4",
            "Caja 5"});
            this.comboBox1.Location = new System.Drawing.Point(373, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtosistema);
            this.Controls.Add(this.bCOMPARAR);
            this.Controls.Add(this.bREINICIAL);
            this.Controls.Add(this.mtoreal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mtoreal;
        private System.Windows.Forms.Button bREINICIAL;
        private System.Windows.Forms.Button bCOMPARAR;
        private System.Windows.Forms.Label mtosistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}