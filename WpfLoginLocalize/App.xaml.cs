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
            InitializeComponent();
            LangChanged += App_LangChanged;

            listLangs.Clear();
            listLangs.Add(new CultureInfo("en"));
            listLangs.Add(new CultureInfo("uk"));
            listLangs.Add(new CultureInfo("ru"));

            Lang=WpfLoginLocalize.Properties.Settings.Default.defaultlanguage
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

                ResourceDictionary dict = new ResourceDictionary();

                switch (value.Name)
                {
                    case "uk":
                        break;
                    case "ru":
                        break;
                    default:
                        break;
                }

                ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                              where d.Source != null && d.Source.OriginalString.StartsWith("")
                                              select d).First();

                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries.Add(dict);
                }

                LangChanged(Application.Current, new EventArgs());
            }
        }

        private void App_LangChanged(object sender, EventArgs e)
        {

        }
    }
}
