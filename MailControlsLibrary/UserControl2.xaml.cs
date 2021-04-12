using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailControlsLibrary
{
    /// <summary>
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public event RoutedEventHandler MouseClick;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MouseClick != null)
            {
                MouseClick(sender, e);
            }
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            if (MouseClick != null)
            {
                MouseClick(sender, e);
            }
        }
    }
}
