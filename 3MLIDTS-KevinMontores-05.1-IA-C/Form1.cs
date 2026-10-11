
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3MLIDTS_KevinMontores_05._1_IA_C
{ 
    public partial class Form1 : Form
    {
        private readonly Color colorNormal = Color.White;
        private readonly Color colorError = Color.MistyRose;

        private readonly string rutaArchivo = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
            "Practica04",
            "FormularioCSharp.txt"
        );

        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            tbNombre.MaxLength = 60;
            tbApellido.MaxLength = 60;
            tbEdad.MaxLength = 3;
            tbEstatura.MaxLength = 5;
            tbTelefono.MaxLength = 10;

            tbNombre.TextChanged += RestablecerColor;
            tbApellido.TextChanged += RestablecerColor;
            tbEdad.TextChanged += RestablecerColor;
            tbEstatura.TextChanged += RestablecerColor;
            tbTelefono.TextChanged += RestablecerColor;

            AcceptButton = btnGuardar;
            ActiveControl = tbNombre;
        }

        // VALIDACIONES

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(
                valor.Trim(),
                @"^\p{L}+(?:[ '-]\p{L}+)*$"
            );
        }

        private bool EsEdadValida(string valor)
        {
            int edad;

            return Regex.IsMatch(valor.Trim(), @"^[0-9]+$")
                && int.TryParse(valor, out edad)
                && edad >= 1
                && edad <= 120;
        }

        private bool EsEstaturaValida(string valor)
        {
            decimal estatura;
            string texto = valor.Trim().Replace(',', '.');

            return Regex.IsMatch(
                texto, @"^[0-9]+(\.[0-9]+)?$")
                && decimal.TryParse(
                    texto,
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out estatura
                )
                && estatura >= 0.30m
                && estatura <= 2.80m;
        }

        private bool EsTelefonoValido(string valor)
        {
            return Regex.IsMatch(
                valor.Trim(), @"^[0-9]{10}$"
            );
        }

        private void RestablecerColor(object sender, EventArgs e)
        {
            TextBox campo = sender as TextBox;

            if (campo != null)
                campo.BackColor = colorNormal;
        }

        private bool ValidarCampo(
            TextBox campo,
            bool condicion,
            string mensaje,
            StringBuilder errores)
        {
            campo.BackColor =
                condicion ? colorNormal : colorError;

            if (!condicion)
                errores.AppendLine("• " + mensaje);

            return condicion;
        }

        private bool ValidarFormulario()
        {
            StringBuilder errores = new StringBuilder();
            bool valido = true;

            if (!ValidarCampo(
                tbNombre,
                EsTextoValido(tbNombre.Text),
                "Escriba un nombre válido.",
                errores))
                valido = false;

            if (!ValidarCampo(
                tbApellido,
                EsTextoValido(tbApellido.Text),
                "Escriba apellidos válidos.",
                errores))
                valido = false;

            if (!ValidarCampo(
                tbEdad,
                EsEdadValida(tbEdad.Text),
                "La edad debe estar entre 1 y 120 años.",
                errores))
                valido = false;

            if (!ValidarCampo(
                tbEstatura,
                EsEstaturaValida(tbEstatura.Text),
                "La estatura debe estar entre 0.30 y 2.80 m.",
                errores))
                valido = false;

            if (!ValidarCampo(
                tbTelefono,
                EsTelefonoValido(tbTelefono.Text),
                "El teléfono debe contener 10 dígitos.",
                errores))
                valido = false;

            if (!rbMasculino.Checked &&
                !rbFemenino.Checked &&
                !rbOtro.Checked)
            {
                valido = false;
                errores.AppendLine("• Seleccione un género.");
            }

            if (!valido)
            {
                MessageBox.Show(
                    "Corrija los siguientes datos:\n\n"
                    + errores,
                    "Validación del formulario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            return valido;
        }

        // GÉNERO

        private string ObtenerGenero()
        {
            if (rbMasculino.Checked)
                return "Masculino";

            if (rbFemenino.Checked)
                return "Femenino";

            if (rbOtro.Checked)
                return "Otro";

            return "";
        }

        // GENERAR REGISTRO

        private string GenerarRegistro()
        {
            StringBuilder registro = new StringBuilder();

            registro.AppendLine(
                "==================================");

            registro.AppendLine("REGISTRO DE USUARIO");

            registro.AppendLine(
                "Fecha: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            registro.AppendLine(
                "==================================");

            registro.AppendLine(
                "Nombre: " + tbNombre.Text.Trim());

            registro.AppendLine(
                "Apellidos: " + tbApellido.Text.Trim());

            registro.AppendLine(
                "Edad: " + tbEdad.Text.Trim() + " años");

            registro.AppendLine(
                "Estatura: " +
                tbEstatura.Text.Trim().Replace(',', '.') + " m");

            registro.AppendLine(
                "Teléfono: " + tbTelefono.Text.Trim());

            registro.AppendLine(
                "Género: " + ObtenerGenero());

            registro.AppendLine(
                "==================================");

            return registro.ToString();
        }

        // GUARDAR

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            string registro = GenerarRegistro();

            DialogResult respuesta = MessageBox.Show(
                registro + "\n¿Desea guardar este registro?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                string carpeta = Path.GetDirectoryName(rutaArchivo);

                Directory.CreateDirectory(carpeta);

                using (StreamWriter escritor =
                    new StreamWriter(
                        rutaArchivo,
                        true,
                        new UTF8Encoding(false)))
                {
                    escritor.WriteLine(registro);
                }

                MessageBox.Show(
                    "Registro guardado correctamente.\n\n"
                    + "Ubicación:\n" + rutaArchivo,
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarFormulario();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "No tiene permisos para guardar el archivo.",
                    "Error de permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el registro:\n"
                    + ex.Message,
                    "Error de archivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // LIMPIAR

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();

            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbOtro.Checked = false;

            tbNombre.BackColor = colorNormal;
            tbApellido.BackColor = colorNormal;
            tbEdad.BackColor = colorNormal;
            tbEstatura.BackColor = colorNormal;
            tbTelefono.BackColor = colorNormal;

            tbNombre.Focus();
        }
    }
}
