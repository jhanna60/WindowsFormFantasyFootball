namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Data;

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IEnumerable<Footballer> footballers = null;
            try
            {
                var repo = new FootballersRepository();
                footballers = repo.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error retrieving footballer details:{0}Message: {1}",
                    Environment.NewLine,
                    e.Message));
            }

            if (footballers != null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(footballers));
            }
        }
    }
}