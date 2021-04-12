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
using AdressLibrary;

namespace EmailSend
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MailAdr> Adress = new List<MailAdr>();
        List<SMTP_server> Smtp = new List<SMTP_server>();
        
        public MainWindow()
        {
           
            InitializeComponent();
            
            Adress.Add(new MailAdr("Danila","danya.argastsev.02@mail.ru"));
            foreach (var mail in Adress) CbSenders_Copy.Items.Add(mail.GetAdress());
            AddBut_Copy1.MouseClick += AddBut_MouseClick;
            NextTab.MouseClick += NextTab_MouseClick;
            SetSmtp();
        }

        private void NextTab_MouseClick(object sender, RoutedEventArgs e)
        {
            if (tbMailControl.SelectedIndex == 0)
                tbMailControl.SelectedIndex = tbMailControl.Items.Count - 1;
            else tbMailControl.SelectedIndex--;
           
        }

        private void AddBut_MouseClick(object sender, RoutedEventArgs e)
        {
            SetComboName();
        }

        private void Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string adress = (string)CbSenders_Copy.SelectedItem;
                string topic = MailTopic1.Text;
                if (topic == "")
                {
                    throw new Exception();
                }
                MailContent.SelectAll();
                string body = MailContent.Text;
                if (body == "")
                {
                    throw new Exception();
                }
                SendMail.Send(topic, body, adress, (string)CbSenders_Copy.SelectedItem,(string)CbSmtp.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetComboName()
        {

            СbRepcient_Copy.Items.Add(FromAdress.GetAdress());


        }

        private void SetSmtp()
        {
            Smtp.Add(new SMTP_server("smtp.mail.ru"));
            Smtp.Add(new SMTP_server("smtp.gmail.com"));
            foreach (var _smtp in Smtp) CbSmtp.Items.Add(_smtp.DataBase());
        }
       
    }
}
