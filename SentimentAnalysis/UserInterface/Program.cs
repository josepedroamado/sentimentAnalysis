using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SystemData data;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SystemDataStartUp();
            Application.Run(new MainWindow(data));

            void SystemDataStartUp()
            {
                IEntitySaver entitySaver = new EntityDatabaseSaver();
                ISentimentSaver sentimentSaver = new SentimentDatabaseSaver();
                IPublicationSaver publicationSaver = new PublicationDatabaseSaver();
                IRelationSaver relationSaver = new RelationDatabaseSaver();
                IAlarmSaver alarmSaver = new AlarmDatabaseSaver();
                IAuthorSaver authorSaver = new AuthorDatabaseSaver();
                data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);
            }
        }

    }
}
