using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Jonghyun Oh
 * Date: 2017-08-17
 * StudentID: 300921985 
 * Description: final Exam
 * Version: 1.0
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {

        public static PickHighestCardForm pickHighestCardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pickHighestCardForm = new PickHighestCardForm();
            //Application.Run(new PickHighestCardForm());
            Application.Run(new SplashForm());
        }
    }
}
