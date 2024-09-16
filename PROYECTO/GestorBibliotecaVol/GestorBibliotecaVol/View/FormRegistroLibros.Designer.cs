namespace GestorBibliotecaVol
{
    partial class FormRegistroLibros
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelarRegistroLibro = new Button();
            btnGuardarLibro = new Button();
            txtAutorLibro = new TextBox();
            txtTituloLibro = new TextBox();
            lblRegistroLibros = new Label();
            label4 = new Label();
            txtISBN = new TextBox();
            nudAnnio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAnnio).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 136);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 19;
            label3.Text = "Año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 107);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 18;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 78);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 17;
            label1.Text = "Título";
            // 
            // btnCancelarRegistroLibro
            // 
            btnCancelarRegistroLibro.Location = new Point(227, 162);
            btnCancelarRegistroLibro.Name = "btnCancelarRegistroLibro";
            btnCancelarRegistroLibro.Size = new Size(75, 23);
            btnCancelarRegistroLibro.TabIndex = 26;
            btnCancelarRegistroLibro.Text = "Cancelar";
            btnCancelarRegistroLibro.UseVisualStyleBackColor = true;
            btnCancelarRegistroLibro.Click += btnCancelarRegistroLibro_Click;
            // 
            // btnGuardarLibro
            // 
            btnGuardarLibro.Location = new Point(142, 162);
            btnGuardarLibro.Name = "btnGuardarLibro";
            btnGuardarLibro.Size = new Size(75, 23);
            btnGuardarLibro.TabIndex = 25;
            btnGuardarLibro.Text = "Guardar";
            btnGuardarLibro.UseVisualStyleBackColor = true;
            btnGuardarLibro.Click += btnGuardarLibro_Click;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(116, 104);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(267, 23);
            txtAutorLibro.TabIndex = 23;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(116, 75);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(267, 23);
            txtTituloLibro.TabIndex = 22;
            // 
            // lblRegistroLibros
            // 
            lblRegistroLibros.AutoSize = true;
            lblRegistroLibros.Location = new Point(61, 21);
            lblRegistroLibros.Name = "lblRegistroLibros";
            lblRegistroLibros.Size = new Size(121, 15);
            lblRegistroLibros.TabIndex = 10;
            lblRegistroLibros.Text = "Información del libro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 49);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 20;
            label4.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(116, 46);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(267, 23);
            txtISBN.TabIndex = 21;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // nudAnnio
            // 
            nudAnnio.Location = new Point(116, 134);
            nudAnnio.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudAnnio.Name = "nudAnnio";
            nudAnnio.Size = new Size(267, 23);
            nudAnnio.TabIndex = 24;
            nudAnnio.TextAlign = HorizontalAlignment.Right;
            // 
            // FormRegistroLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 206);
            ControlBox = false;
            Controls.Add(nudAnnio);
            Controls.Add(txtISBN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelarRegistroLibro);
            Controls.Add(btnGuardarLibro);
            Controls.Add(txtAutorLibro);
            Controls.Add(txtTituloLibro);
            Controls.Add(lblRegistroLibros);
            Name = "FormRegistroLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Libros";
            ((System.ComponentModel.ISupportInitialize)nudAnnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelarRegistroLibro;
        private Button btnGuardarLibro;
        private TextBox txtAutorLibro;
        private TextBox txtTituloLibro;
        private Label lblRegistroLibros;
        private Label label4;
        private TextBox txtISBN;
        private NumericUpDown nudAnnio;
    }
}