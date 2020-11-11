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

namespace WPF
{
    /// <summary>
    /// Interaction logic for WriteWindow.xaml
    /// </summary>
    public partial class WriteWindow : Window
    {

        public WriteWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NABAEntities4 db = new NABAEntities4();
            Person obj = new Person();
            obj.Id = Convert.ToInt32(db.People.Count());
            obj.Firstname = FirstName.Text;
            obj.Lastname = LastName.Text;

            db.People.Add(obj);
            db.SaveChanges();
            this.Close();

        }
    }
}
