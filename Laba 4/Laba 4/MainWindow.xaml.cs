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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Laba_4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((login.Text.Length == 0 || password.Password.Length == 0) | (login.Text.Length == 0 && password.Password.Length == 0))
            {
                MessageBox.Show(
                   "Введите правильный логин или пароль",
                   "Сообщение",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error);
                return;
            }
            else
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ru.wikipedia.org/w/index.php?title=Заглавная_страница&_welcomesurveytoken=unn6kl7t6at3r8f1ill3pg59fo0i0lj3&source=welcomesurvey-originalcontext");
                try
                {
                    driver.FindElement(By.XPath("/html/body/div[5]/div[1]/nav/div/ul/li[5]/a")).Click();
                    driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div[4]/div[1]/div[3]/form/div/div[1]/div/input")).SendKeys(login.Text);
                    driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div[4]/div[1]/div[3]/form/div/div[2]/div/input")).SendKeys(password.Password);
                    driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div[4]/div[1]/div[3]/form/div/div[4]/div/button")).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("/html/body/div[5]/div[1]/nav/div/ul/li[10]/a"));
                }
                catch
                {
                    driver.Dispose();

                    MessageBox.Show(
                  "Неправильный логин или пароль",
                  "Сообщение",
                  MessageBoxButton.OK,
                  MessageBoxImage.Error);
                    return;
                }
            }
        }
    }
}
