namespace GestorBibliotecaVol
{
    partial class FormMenu
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
            btnRegistrar = new Button();
            btnConsultar = new Button();
            btnActualizar = new Button();
            btnEliminacion = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.Location = new Point(51, 30);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 70);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(210, 30);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(126, 70);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(51, 144);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(126, 70);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualización";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminacion
            // 
            btnEliminacion.Location = new Point(210, 144);
            btnEliminacion.Margin = new Padding(4, 5, 4, 5);
            btnEliminacion.Name = "btnEliminacion";
            btnEliminacion.Size = new Size(126, 70);
            btnEliminacion.TabIndex = 3;
            btnEliminacion.Text = "Eliminar";
            btnEliminacion.UseVisualStyleBackColor = true;
            btnEliminacion.Click += btnEliminacion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(136, 265);
            button1.Name = "button1";
            button1.Size = new Size(126, 63);
            button1.TabIndex = 4;
            button1.Text = "Graficos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.Los_libros_ocupan_un_lugar_muy_importante_en_la_vida_de_las_personas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 460);
            Controls.Add(button1);
            Controls.Add(btnEliminacion);
            Controls.Add(btnActualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrar;
        private Button btnConsultar;
        private Button btnActualizar;
        private Button btnEliminacion;
        private Button button1;
    }
}