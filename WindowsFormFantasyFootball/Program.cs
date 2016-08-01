namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Data;
    using System.Reflection;
    using System.Globalization;
    using Mapper;
    using System.Collections;

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
                var mapper = new FootballMapper();
                var footballersDataTable = mapper.MapFootballers(footballers);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(footballersDataTable));
            }
        }
    }

    //Helper methods
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        { 
            Type dgvType = dgv.GetType();  
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);  
            pi.SetValue(dgv, setting, null);  
        }  
    } 
}