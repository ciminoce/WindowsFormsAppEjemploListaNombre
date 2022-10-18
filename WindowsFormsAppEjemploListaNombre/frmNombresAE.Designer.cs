
namespace WindowsFormsAppEjemploListaNombre
{
    partial class frmNombreAE
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.mostrarListaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.letraTextBox = new System.Windows.Forms.TextBox();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.comienzanVocalButton = new System.Windows.Forms.Button();
            this.nombresInvertidosButton = new System.Windows.Forms.Button();
            this.ordenarCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(146, 25);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(202, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(45, 79);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 63);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(130, 79);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(79, 63);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // mostrarListaButton
            // 
            this.mostrarListaButton.Location = new System.Drawing.Point(226, 79);
            this.mostrarListaButton.Name = "mostrarListaButton";
            this.mostrarListaButton.Size = new System.Drawing.Size(122, 63);
            this.mostrarListaButton.TabIndex = 3;
            this.mostrarListaButton.Text = "Mostrar Lista";
            this.mostrarListaButton.UseVisualStyleBackColor = true;
            this.mostrarListaButton.Click += new System.EventHandler(this.mostrarListaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cant. nombres ingresados:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(510, 25);
            this.cantidadTextBox.MaxLength = 12;
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.ReadOnly = true;
            this.cantidadTextBox.Size = new System.Drawing.Size(33, 20);
            this.cantidadTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese letra inicial:";
            // 
            // letraTextBox
            // 
            this.letraTextBox.Location = new System.Drawing.Point(130, 179);
            this.letraTextBox.MaxLength = 1;
            this.letraTextBox.Name = "letraTextBox";
            this.letraTextBox.Size = new System.Drawing.Size(30, 20);
            this.letraTextBox.TabIndex = 4;
            // 
            // filtrarButton
            // 
            this.filtrarButton.Enabled = false;
            this.filtrarButton.Location = new System.Drawing.Point(178, 178);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 5;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // comienzanVocalButton
            // 
            this.comienzanVocalButton.Location = new System.Drawing.Point(354, 79);
            this.comienzanVocalButton.Name = "comienzanVocalButton";
            this.comienzanVocalButton.Size = new System.Drawing.Size(122, 63);
            this.comienzanVocalButton.TabIndex = 3;
            this.comienzanVocalButton.Text = "Comienzan con Vocal";
            this.comienzanVocalButton.UseVisualStyleBackColor = true;
            this.comienzanVocalButton.Click += new System.EventHandler(this.comienzanVocalButton_Click);
            // 
            // nombresInvertidosButton
            // 
            this.nombresInvertidosButton.Location = new System.Drawing.Point(354, 157);
            this.nombresInvertidosButton.Name = "nombresInvertidosButton";
            this.nombresInvertidosButton.Size = new System.Drawing.Size(122, 63);
            this.nombresInvertidosButton.TabIndex = 3;
            this.nombresInvertidosButton.Text = "Lista Nombres Invertidos";
            this.nombresInvertidosButton.UseVisualStyleBackColor = true;
            this.nombresInvertidosButton.Click += new System.EventHandler(this.nombresInvertidosButton_Click);
            // 
            // ordenarCheckBox
            // 
            this.ordenarCheckBox.AutoSize = true;
            this.ordenarCheckBox.Location = new System.Drawing.Point(29, 216);
            this.ordenarCheckBox.Name = "ordenarCheckBox";
            this.ordenarCheckBox.Size = new System.Drawing.Size(85, 17);
            this.ordenarCheckBox.TabIndex = 6;
            this.ordenarCheckBox.Text = "Ordenar Alfa";
            this.ordenarCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmNombreAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 245);
            this.Controls.Add(this.ordenarCheckBox);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.nombresInvertidosButton);
            this.Controls.Add(this.comienzanVocalButton);
            this.Controls.Add(this.mostrarListaButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.letraTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmNombreAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button mostrarListaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox letraTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button comienzanVocalButton;
        private System.Windows.Forms.Button nombresInvertidosButton;
        private System.Windows.Forms.CheckBox ordenarCheckBox;
    }
}

