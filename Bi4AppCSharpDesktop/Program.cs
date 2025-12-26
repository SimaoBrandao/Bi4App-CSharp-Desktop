using System;
using System.Windows.Forms;

namespace Bi4AppCSharpDesktop
{
    // Bi4App - Projeto de Demonstração (Desktop em C#)
    // Autor: Simão Brandão
    // Email: sibrandao2008@gmail.com 
    // Telemovel: +244 948 49 38 28 
    // Github: https://github.com/SimaoBrandao/Bi4App-CSharp-Desktop.git
    // Nuget:  https://www.nuget.org/packages/Bi4App
    // Data: 09/01/2025 
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
