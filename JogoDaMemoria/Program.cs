﻿using System;
using System.Windows.Forms;

namespace Jogo_da_Memoria
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JogoDaMemoria());
        }
    }
}