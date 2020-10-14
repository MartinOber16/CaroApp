using CaroApp.Controllers;
using System;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace CaroApp
{
    public partial class MenuPrincipal : Form
    {
        private StreamReader archivoBanco;
        private StreamReader archivoSAP;
        
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private string openFileDialog(ref StreamReader sr)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sr = new StreamReader(openFileDialog1.FileName);
                    //SetText(sr.ReadToEnd());
                    return openFileDialog1.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                    
                }
            }
            return string.Empty;
        }

        private void btnUploadFileBanco_Click(object sender, EventArgs e)
        {
            textBoxBancoFile.Text = openFileDialog(ref archivoBanco);

        }

        private void btnUploadFileSAP_Click(object sender, EventArgs e)
        {
            textBoxSAPFile.Text = openFileDialog(ref archivoSAP);
        }

        private bool validarFormulario()
        {
            bool validacion = false;
            if (archivoBanco == null)
            {
                MessageBox.Show("Debe seleccionar un archivo de banco.");
            }
            else
            {
                if (archivoSAP == null)
                {
                    MessageBox.Show("Debe seleccionar un archivo de SAP.");
                }
                else
                {
                    if(string.IsNullOrEmpty(textBoxExtracto.Text))
                    {
                        MessageBox.Show("Debe ingresar un numero de extracto.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBoxIngresos.Text))
                        {
                            MessageBox.Show("Debe ingresar un numero de ingresos.");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(textBoxEgresos.Text))
                            {
                                MessageBox.Show("Debe ingresar un numero de egresos.");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(textBoxDivision.Text))
                                {
                                    MessageBox.Show("Debe ingresar un numero de División.");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(textBoxHeader.Text))
                                    {
                                        MessageBox.Show("Debe ingresar una cabecera para el archivo de salida.");
                                    }
                                    else
                                    {
                                        validacion = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return validacion;
        }

        private void limpiarFormulario()
        {
            archivoBanco = null;
            archivoSAP = null;
            textBoxBancoFile.Text = string.Empty;
            textBoxSAPFile.Text = string.Empty;
            textBoxExtracto.Text = string.Empty;
            textBoxIngresos.Text = string.Empty;
            textBoxEgresos.Text = string.Empty;
            textBoxDivision.Text = string.Empty;
            textBoxHeader.Text = string.Empty;
            progressBar1.Value = 0;
            labelResult.Text = "0 %";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Controlador controlador = new Controlador(textBoxDelimitador.Text.ToCharArray()[0]);

                bool bancoCargado = controlador.cargarRegistrosBanco(archivoBanco);
                bool SAPCargado = controlador.cargarRegistrosSAP(archivoSAP);

                if(bancoCargado && SAPCargado)
                {
                    string msj = string.Empty;
                    if(controlador.procesarArchivos(ref progressBar1, ref labelResult, int.Parse(textBoxCodigo.Text), int.Parse(textBoxExtracto.Text), int.Parse(textBoxIngresos.Text), int.Parse(textBoxEgresos.Text), int.Parse(textBoxDivision.Text)))
                    {
                        if(controlador.generaArchivoSalida(textBoxNombreSalida.Text, textBoxHeader.Text))
                            msj = "Archivo de salida generado correctamente.";
                        else
                            msj = "Error: No se pudo generar el archivo de salida.";
                    }
                    else
                    {
                        msj = "Error: No se pudo procesar la información.";
                    }

                    MessageBox.Show(msj);
                    archivoBanco.Close();
                    archivoSAP.Close();
                    limpiarFormulario();
                }     
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
