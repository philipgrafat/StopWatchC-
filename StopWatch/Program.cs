using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopWatch.Model;
using StopWatch.Presenter;

/*
 * Philip Graf 2017
 * Design inspiration: https://chrome.google.com/webstore/detail/stopwatch/ohbfkkmpnlpgbbfdflaiikoohbidaikj
 */

namespace StopWatch
{
    static class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new StopWatchModel();
            var view = new MainForm();
            var presenter = new StopWatchPresenter(view, model);
            Application.Run(view);
        }
    }
}
