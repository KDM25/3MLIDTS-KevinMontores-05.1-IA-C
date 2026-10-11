
namespace _3MLIDTS_KevinMontores_05._1_IA_C

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelEncabezado;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblTelefono;

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.TextBox tbTelefono;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbOtro;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelEncabezado = new System.Windows.Forms.Panel();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();

            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // VENTANA PRINCIPAL

            this.ClientSize = new System.Drawing.Size(540, 610);
            this.Text = "Sistema de Registro de Usuarios";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = true;

            this.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);

            this.Font = new System.Drawing.Font("Arial", 10F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            // PANEL PRINCIPAL

            this.panelPrincipal.Location =
                new System.Drawing.Point(35, 30);

            this.panelPrincipal.Size =
                new System.Drawing.Size(470, 545);

            this.panelPrincipal.BackColor =
                System.Drawing.Color.White;

            this.Controls.Add(this.panelPrincipal);

            // ENCABEZADO

            this.panelEncabezado.Location =
                new System.Drawing.Point(0, 0);

            this.panelEncabezado.Size =
                new System.Drawing.Size(470, 95);

            this.panelEncabezado.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 138);

            this.panelPrincipal.Controls.Add(
                this.panelEncabezado);

            this.lblTitulo.Text = "REGISTRO DE USUARIOS";

            this.lblTitulo.Font = new System.Drawing.Font(
                "Arial", 17F,
                System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor = System.Drawing.Color.White;

            this.lblTitulo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTitulo.Location =
                new System.Drawing.Point(10, 18);

            this.lblTitulo.Size =
                new System.Drawing.Size(450, 35);

            this.panelEncabezado.Controls.Add(this.lblTitulo);

            this.lblSubtitulo.Text =
                "Sistema de captura de datos personales";

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(219, 234, 254);

            this.lblSubtitulo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitulo.Location =
                new System.Drawing.Point(10, 57);

            this.lblSubtitulo.Size =
                new System.Drawing.Size(450, 25);

            this.panelEncabezado.Controls.Add(this.lblSubtitulo);

            // NOMBRE

            this.lblNombre.Text = "Nombre(s):";
            this.lblNombre.Location =
                new System.Drawing.Point(35, 125);
            this.lblNombre.AutoSize = true;
            this.panelPrincipal.Controls.Add(this.lblNombre);

            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Location =
                new System.Drawing.Point(35, 150);
            this.tbNombre.Size =
                new System.Drawing.Size(400, 26);
            this.panelPrincipal.Controls.Add(this.tbNombre);

            // APELLIDOS

            this.lblApellido.Text = "Apellidos:";
            this.lblApellido.Location =
                new System.Drawing.Point(35, 190);
            this.lblApellido.AutoSize = true;
            this.panelPrincipal.Controls.Add(this.lblApellido);

            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Location =
                new System.Drawing.Point(35, 215);
            this.tbApellido.Size =
                new System.Drawing.Size(400, 26);
            this.panelPrincipal.Controls.Add(this.tbApellido);

            // EDAD

            this.lblEdad.Text = "Edad:";
            this.lblEdad.Location =
                new System.Drawing.Point(35, 255);
            this.lblEdad.AutoSize = true;
            this.panelPrincipal.Controls.Add(this.lblEdad);

            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Location =
                new System.Drawing.Point(35, 280);
            this.tbEdad.Size =
                new System.Drawing.Size(175, 26);
            this.panelPrincipal.Controls.Add(this.tbEdad);

            // ESTATURA

            this.lblEstatura.Text = "Estatura (m):";
            this.lblEstatura.Location =
                new System.Drawing.Point(260, 255);
            this.lblEstatura.AutoSize = true;
            this.panelPrincipal.Controls.Add(this.lblEstatura);

            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Location =
                new System.Drawing.Point(260, 280);
            this.tbEstatura.Size =
                new System.Drawing.Size(175, 26);
            this.panelPrincipal.Controls.Add(this.tbEstatura);

            // TELÉFONO

            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Location =
                new System.Drawing.Point(35, 320);
            this.lblTelefono.AutoSize = true;
            this.panelPrincipal.Controls.Add(this.lblTelefono);

            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Location =
                new System.Drawing.Point(35, 345);
            this.tbTelefono.Size =
                new System.Drawing.Size(400, 26);
            this.panelPrincipal.Controls.Add(this.tbTelefono);

            // GÉNERO

            this.groupBox1.Text = "Seleccione su género";
            this.groupBox1.Location =
                new System.Drawing.Point(35, 390);
            this.groupBox1.Size =
                new System.Drawing.Size(400, 70);

            this.panelPrincipal.Controls.Add(this.groupBox1);

            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.Location =
                new System.Drawing.Point(15, 30);
            this.rbMasculino.AutoSize = true;
            this.groupBox1.Controls.Add(this.rbMasculino);

            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.Location =
                new System.Drawing.Point(145, 30);
            this.rbFemenino.AutoSize = true;
            this.groupBox1.Controls.Add(this.rbFemenino);

            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Text = "Otro";
            this.rbOtro.Location =
                new System.Drawing.Point(280, 30);
            this.rbOtro.AutoSize = true;
            this.groupBox1.Controls.Add(this.rbOtro);

            // GUARDAR

            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Location =
                new System.Drawing.Point(35, 480);
            this.btnGuardar.Size =
                new System.Drawing.Size(190, 43);

            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnGuardar.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.FlatAppearance.BorderSize = 0;

            this.btnGuardar.Font = new System.Drawing.Font(
                "Arial", 10F,
                System.Drawing.FontStyle.Bold);

            this.btnGuardar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnGuardar.Click +=
                new System.EventHandler(this.btnGuardar_Click);

            this.panelPrincipal.Controls.Add(this.btnGuardar);

            // LIMPIAR

            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Location =
                new System.Drawing.Point(245, 480);
            this.btnLimpiar.Size =
                new System.Drawing.Size(190, 43);

            this.btnLimpiar.BackColor =
                System.Drawing.Color.FromArgb(100, 116, 139);

            this.btnLimpiar.ForeColor =
                System.Drawing.Color.White;

            this.btnLimpiar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLimpiar.FlatAppearance.BorderSize = 0;

            this.btnLimpiar.Font = new System.Drawing.Font(
                "Arial", 10F,
                System.Drawing.FontStyle.Bold);

            this.btnLimpiar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnLimpiar.Click +=
                new System.EventHandler(this.btnLimpiar_Click);

            this.panelPrincipal.Controls.Add(this.btnLimpiar);

            // FINALIZAR

            this.ResumeLayout(false);
        }
    }
}
