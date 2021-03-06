﻿using AdapterPatern.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatern
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ListSaveAdapter List = new ListSaveAdapter();
            DictionarySaveAdapter List = new DictionarySaveAdapter();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(List));
        }
    }
}
