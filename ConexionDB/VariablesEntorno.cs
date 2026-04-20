using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConexionDB
{
    public class VariablesEntorno
    {
        /// <summary>
        /// Carga las variables del archivo .env y las establece en un diccionario.
        /// </summary>
        public static Dictionary<string, string> CargarVariables(string filePath = ".env")
        {
            string RaizProyecto = AppDomain.CurrentDomain.BaseDirectory;  // Nos aseguramos que apunte a bin/debug o bin/release
            string PathCompleto = Path.Combine(RaizProyecto, filePath);

            Dictionary<string, string> variables = new Dictionary<string, string>();
            try
            {
                if (!File.Exists(PathCompleto))
                    throw new FileNotFoundException($"Archivo {PathCompleto} no encontrado");

                foreach (string linea in File.ReadAllLines(PathCompleto))
                {
                    // Ignorar líneas vacias y comentarios
                    if (string.IsNullOrWhiteSpace(linea) || linea.TrimStart().StartsWith("#"))
                        continue;

                    // Parsear CLAVE=VALOR
                    string[] parts = linea.Split(new[] { '=' }, 2);

                    if (parts.Length != 2)
                        // Mal formato
                        continue;

                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    // Remover comillas si existen
                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }

                    variables[key] = value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cargando .env: {ex.Message}");
                throw ex;
            }

            return variables;
        }
    }
}
