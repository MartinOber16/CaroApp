using CaroApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CaroApp.Controllers
{
    public class Controlador
    {
        private List<InfoBanco> registrosBanco;
        private List<InfoSAP> registrosSAP;
        private List<InfoSalida> registrosSalida;
        private char delimiterChar;

        public Controlador(char c)
        {
            delimiterChar = c;
        }

        public bool cargarRegistrosBanco(StreamReader archivoBanco)
        {
            registrosBanco = new List<InfoBanco>();
            int registros = 0;
            try
            {
                while (!archivoBanco.EndOfStream)
                {
                    registros++;
                    string line = archivoBanco.ReadLine();
                    // Console.WriteLine(line);
                    string[] campos = line.Split(delimiterChar);
                    // Console.WriteLine(DateTime.Parse(campos[0]) + " - " + campos[1] + " - " + decimal.Parse(campos[2]) + " - " + campos[3]);
                    registrosBanco.Add(
                        new InfoBanco
                        {
                            Id = registros,
                            Fecha = DateTime.Parse(campos[0]),
                            Comprobante = campos[1],
                            Importe = decimal.Parse(campos[2]),
                            Descripcion = campos[3]
                        }
                    );
                }
                Console.WriteLine("Registros banco: " + registrosBanco.Count);
                return true;
            }
            catch (Exception ex)
            {
                string msj = "Error en archivo Banco: registro Nº " + registros + " - " + ex.Message;
                Console.WriteLine(msj);
                MessageBox.Show(msj);
                return false;
            }
            
        }

        public bool cargarRegistrosSAP(StreamReader archivoSAP)
        {
            registrosSAP = new List<InfoSAP>();
            int registros = 0;
            try
            {
                while (!archivoSAP.EndOfStream)
                {
                    registros++;
                    string line = archivoSAP.ReadLine();
                    // Console.WriteLine(line);
                    string[] campos = line.Split(delimiterChar);
                    // Console.WriteLine(DateTime.Parse(campos[0]) + " - " + campos[1] + " - " + decimal.Parse(campos[2]) + " - " + campos[3]);
                    registrosSAP.Add(
                        new InfoSAP
                        {
                            Id = registros,
                            Asignacion = campos[0],
                            Fecha = DateTime.Parse(campos[1]),
                            Importe = decimal.Parse(campos[2]),
                            Texto = campos[3]
                        }
                    );
                }
                Console.WriteLine("Registros SAP: " + registrosSAP.Count);
                return true;
            }
            catch (Exception ex)
            {
                string msj = "Error en archivo SAP: registro Nº" + registros + " - " + ex.Message;
                Console.WriteLine(msj);
                MessageBox.Show(msj);
                return false;
            }
        }

        public bool procesarArchivos(ref ProgressBar progressBar1, ref Label labelResult, int codigo, int extracto, int ingreso, int egreso, int division)
        {
            registrosSalida = new List<InfoSalida>();
            int registros=0;
            try
            {
                int incremento = 0;
                if (registrosBanco.Count > 0)
                {
                    progressBar1.Value = 0;
                    labelResult.Text = progressBar1.Value.ToString() + " %";
                    incremento = 100 / registrosBanco.Count;
                }
                else
                    progressBar1.Value = 100;

                foreach(InfoBanco rbanco in registrosBanco)
                {
                    if (!registrosSAP.Exists(s => s.Fecha == rbanco.Fecha && s.Importe == rbanco.Importe && s.Asignacion == rbanco.Comprobante))
                    {
                        int cc = 40;
                        if (rbanco.Importe < 0)
                            cc = 50;

                        registros++;
                        registrosSalida.Add(
                            new InfoSalida
                            {
                                Id = registros,
                                Codigo = codigo,
                                ClaveContable = cc,
                                Cuenta = extracto,
                                Importe = Math.Abs(rbanco.Importe),
                                Division = division,
                                Texto = rbanco.Descripcion,
                                Fecha = rbanco.Fecha
                            }
                        );

                        cc = 50;
                        int cta = ingreso;
                        if (rbanco.Importe < 0)
                        {
                            cc = 40;
                            cta = egreso;
                        }

                        registros++;
                        registrosSalida.Add(
                            new InfoSalida
                            {
                                Id = registros,
                                Codigo = codigo,
                                ClaveContable = cc,
                                Cuenta = cta,
                                Importe = Math.Abs(rbanco.Importe),
                                Division = division,
                                Texto = rbanco.Descripcion,
                                Fecha = rbanco.Fecha
                            }
                        );
                    }

                    progressBar1.Value += incremento;
                    labelResult.Text = progressBar1.Value.ToString() + " %";

                }

                if (progressBar1.Value < 100 || progressBar1.Value > 100)
                {
                    progressBar1.Value = 100;
                    labelResult.Text = progressBar1.Value.ToString() + " %";
                }
                    
                Console.WriteLine("Registros archivo de salida: " + registrosSalida.Count);
                return true;
            }
            catch (Exception ex)
            {
                string msj = "Error: registro Nº " + registros + " - " + ex.Message;
                Console.WriteLine(msj);
                MessageBox.Show(msj);
                return false;
            }
        }

        public bool generaArchivoSalida(string fileName, string cabecera)
        {
            fileName += "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            using (StreamWriter file = new StreamWriter(@".\"+fileName))
            {
                file.WriteLine(cabecera);
                Console.WriteLine(cabecera);
                foreach (InfoSalida salida in registrosSalida)
                {
                    string line = salida.Codigo + "\t" + salida.ClaveContable + "\t" + salida.Cuenta + "\t" + salida.Importe + "\t" + salida.Division.ToString().PadLeft(3,'0') + "\t" + "" + "\t" + "" + "\t" + salida.Texto + "\t" + salida.Fecha.ToString("ddMMyyyy");
                    file.WriteLine(line);
                    Console.WriteLine(line);
                }
            }

            return true;
        }

    }
}
