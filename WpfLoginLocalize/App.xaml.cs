using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLoginLocalize
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static List<CultureInfo> listLangs = new List<CultureInfo>();

        public static List<CultureInfo> Langs
        {
            get
            {
                return listLangs;
            }
        }

        public App()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture =
            //    new System.Globalization.CultureInfo("uk");
            listLangs.Clear();
            listLangs.Add(new CultureInfo("en"));
            listLangs.Add(new CultureInfo("uk"));
            listLangs.Add(new CultureInfo("ru"));
        }

        public static event EventHandler LangChanged;

        public static CultureInfo Lang
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture)
                {
                    return;
                }

                System.Threading.Thread.CurrentThread.CurrentUICulture = value;


            }
        }
    }
}
