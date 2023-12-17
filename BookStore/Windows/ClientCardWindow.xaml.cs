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
using System.Windows.Shapes;
using BookStore.Infrastructure;
using BookStore;
using BookStore.Infrastructure.ViewModels;
using BookStore.Pages;
using BookStore.Infrastructure.Mappers;
using BookStore.Infrastructure.Database;
using BookStore.Windows;

namespace BookStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientCardWindow.xaml
    /// </summary>



    public partial class ClientCardWindow : Window
    {
        private ClientViewModel _selectedItem = null;
        private ClientRepository _repository;
        public ClientCardWindow()
        {
            InitializeComponent();
        }

        public ClientCardWindow(ClientViewModel selectedItem)
        {
            InitializeComponent();
            if (selectedItem != null)
            {
                _selectedItem = selectedItem;
                FullName.Text = selectedItem.fio;
                BirthDate.Text = selectedItem.dataRozd;
                NumberBooks.Text = selectedItem.numberBooks.ToString();
                PlaceInTop.Text = selectedItem.placeInTop.ToString();
                Gender.Text = selectedItem.gender;
            }
            else
            {
                _selectedItem = selectedItem;
                FullName.Text = null;
                BirthDate.Text = null;
                NumberBooks.Text = null;
                PlaceInTop.Text = null;
                Gender.Text = null;
            }
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                _repository = new ClientRepository();
                if (BirthDate.Text.Count() == 10)
                {
                    if (_selectedItem != null)
                    {
                        var entity = new ClientViewModel
                        {
                            id = _selectedItem.id,
                            fio = FullName.Text,
                            dataRozd = BirthDate.Text,
                            numberBooks = Convert.ToInt32(NumberBooks.Text),
                            placeInTop = Convert.ToInt32(PlaceInTop.Text),
                            gender = Gender.Text,
                        };
                        if (_repository != null)
                        {
                            _repository.Update(entity);
                            Window.GetWindow(this).Close();
                        }
                        else
                        {
                            MessageBox.Show("Пусто");
                        }
                    }
                    else
                    {
                        var entity = new ClientViewModel
                        {
                            fio = FullName.Text,
                            dataRozd = BirthDate.Text,
                            numberBooks = Convert.ToInt32(NumberBooks.Text),
                            placeInTop = Convert.ToInt32(PlaceInTop.Text),
                            gender = Gender.Text,
                        };
                        if (_repository != null)
                        {
                            _repository.Add(entity);
                            Window.GetWindow(this).Close();
                        }
                        else
                        {
                            MessageBox.Show("Пусто");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Поле 'День рождения' должно содержать 10 символов");
                }
                
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }   
}
