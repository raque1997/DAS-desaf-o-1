namespace GestorBibliotecaVol.View
{
    partial class FormEliminarLibros
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
            nudAnnio = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelarRegistroLibro = new Button();
            btnEliminar = new Button();
            txtAutorLibro = new TextBox();
            txtTituloLibro = new TextBox();
            lblRegistroLibros = new Label();
            btnBuscar = new Button();
            txtISBN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudAnnio).BeginInit();
            SuspendLayout();
            // 
            // nudAnnio
            // 
            nudAnnio.Enabled = false;
            nudAnnio.Location = new Point(116, 134);
            nudAnnio.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudAnnio.Name = "nudAnnio";
            nudAnnio.Size = new Size(267, 23);
            nudAnnio.TabIndex = 35;
            nudAnnio.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 49);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 31;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 136);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 30;
            label3.Text = "Año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 107);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 29;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 78);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 28;
            label1.Text = "Título";
            // 
            // btnCancelarRegistroLibro
            // 
            btnCancelarRegistroLibro.Location = new Point(227, 162);
            btnCancelarRegistroLibro.Name = "btnCancelarRegistroLibro";
            btnCancelarRegistroLibro.Size = new Size(75, 23);
            btnCancelarRegistroLibro.TabIndex = 37;
            btnCancelarRegistroLibro.Text = "Cancelar";
            btnCancelarRegistroLibro.UseVisualStyleBackColor = true;
            btnCancelarRegistroLibro.Click += btnCancelarRegistroLibro_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(142, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Enabled = false;
            txtAutorLibro.Location = new Point(116, 104);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(267, 23);
            txtAutorLibro.TabIndex = 34;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Enabled = false;
            txtTituloLibro.Location = new Point(116, 75);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(267, 23);
            txtTituloLibro.TabIndex = 33;
            // 
            // lblRegistroLibros
            // 
            lblRegistroLibros.AutoSize = true;
            lblRegistroLibros.Location = new Point(61, 21);
            lblRegistroLibros.Name = "lblRegistroLibros";
            lblRegistroLibros.Size = new Size(121, 15);
            lblRegistroLibros.TabIndex = 27;
            lblRegistroLibros.Text = "Información del libro:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(308, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 51;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(116, 46);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(186, 23);
            txtISBN.TabIndex = 50;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // FormEliminarLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 206);
            ControlBox = false;
            Controls.Add(btnBuscar);
            Controls.Add(txtISBN);
            Controls.Add(nudAnnio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelarRegistroLibro);
            Controls.Add(btnEliminar);
            Controls.Add(txtAutorLibro);
            Controls.Add(txtTituloLibro);
            Controls.Add(lblRegistroLibros);
            Name = "FormEliminarLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Libros";
            ((System.ComponentModel.ISupportInitialize)nudAnnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudAnnio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelarRegistroLibro;
        private Button btnEliminar;
        private TextBox txtAutorLibro;
        private TextBox txtTituloLibro;
        private Label lblRegistroLibros;
        private Button btnBuscar;
        private TextBox txtISBN;
    }
}