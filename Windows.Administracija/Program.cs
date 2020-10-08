﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Administracija.Mobiteli;

namespace Windows.Administracija
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StartForm());

            LoginForm login = new LoginForm();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new StartForm());
            }
            

        }
    }
}
