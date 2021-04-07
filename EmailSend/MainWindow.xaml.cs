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
using System.Net.Mail;
using System.Net;

namespace EmailSend
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string adress = MailAdr.Text;
                string topic = MailTopic.Text;
                MailContent.SelectAll();
                string body = MailContent.Text;
                SendMail.Send(topic,body,adress);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string adress = MailAdr.Text;
                string topic = MailTopic.Text;
                MailContent.SelectAll();
                string body = MailContent.Text;
                SendMail.Send(topic, body, adress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
