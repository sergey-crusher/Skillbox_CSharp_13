using Lesson_13.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Lesson_13
{
    /// <summary>
    /// Логика взаимодействия для pAddClient.xaml
    /// </summary>
    public partial class pAddClient : Page
    {
        private List<string> FullName = new List<string>()
        {
            "Куликова Анна Александровна",
            "Тихонова Полина Ильинична",
            "Демин Андрей Данилович",
            "Гаврилова Дарья Ярославовна",
            "Никулина Виктория Степановна",
            "Николаева Елена Артемьевна",
            "Семенов Семён Андреевич",
            "Карпова Стефания Ивановна",
            "Попов Артур Борисович",
            "Князева Олеся Егоровна",
            "Панин Лука Степанович",
            "Рожков Михаил Демидович",
            "Фролов Михаил Иванович",
            "Седова Ясмина Мироновна",
            "Давыдов Дмитрий Сергеевич",
            "Власов Олег Иванович",
            "Ларионов Максим Георгиевич",
            "Васильева Анастасия Ярославовна",
            "Широкова Агата Георгиевна",
            "Рыжов Илья Тимофеевич",
        };
        public pAddClient()
        {
            InitializeComponent();
        }

        private void ButtonGeneration(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            TextBoxFullName.Text = FullName[random.Next(0, FullName.Count - 1)];
            TextBoxINN.Text = random.NextInt64(100_000_000_000, 999_999_999_999).ToString();
            TextBoxPhone.Text = "7" + random.NextInt64(1_000_000_000, 9_999_999_999).ToString();
        }

        private void ButtonCreate(object sender, RoutedEventArgs e)
        {
            string FullName = TextBoxFullName.Text;
            string INN = TextBoxINN.Text;
            string Phone = TextBoxPhone.Text;

            if (String.IsNullOrEmpty(FullName) || String.IsNullOrEmpty(INN) || String.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                MainWindow.clients.Add(FullName, INN, Phone);
                MainWindow.CurrentClientINN = INN;
            }
        }
    }
}
