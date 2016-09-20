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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DemoDataGrid.xaml
    /// </summary>
    public partial class DemoDataGrid : Window
    {
        public DemoDataGrid()
        {
            InitializeComponent();
            InitialDataForCol3();
        }


        public void InitialDataForCol3()
        {
            List<User> users = new List<User>()
            {
                new User() { ID = 1, Name="Zhang san", Birthday = new DateTime(1980,1,25)},
                new User() { ID = 2, Name="Li Si", Birthday = new DateTime(1986,11,10)},
                new User() { ID = 3, Name="Wang Mazi", Birthday = new DateTime(1983,8,6)},
                new User() { ID = 4, Name="Ma Liu", Birthday = new DateTime(1990,7,1)}
            };

            this.dataGrid.ItemsSource = users;
        }

        public void InitialDataForCol4()
        {
            List<User2> users = new List<User2>()
            {
                new User2() { ID = 1, Name="Zhang san", Birthday = new DateTime(1980,1,25),Phone="13809875432"},
                new User2() { ID = 2, Name="Li Si", Birthday = new DateTime(1986,11,10),Phone="12309875432"},
                new User2() { ID = 3, Name="Wang Mazi", Birthday = new DateTime(1983,8,6),Phone="12309875432"},
                new User2() { ID = 4, Name="Ma Liu", Birthday = new DateTime(1990,7,1),Phone="12309875432"}
            };

            this.dataGrid.ItemsSource = users;
        }

        public void InitialDataForCol10K()
        {

            const int COUNT = 100000;
            List<User> users = new List<User>();

            for(int i = 1; i<= COUNT; i++)
            {
                User u = new User();
                u.ID = i;
                u.Name = "Zhang San";
                u.Birthday = DateTime.Now;

                users.Add(u);
            }

            this.dataGrid.ItemsSource = users;
        }


        private void btnCol3_Click(object sender, RoutedEventArgs e)
        {
            InitialDataForCol10K();
        }

        private void butCol4_Click(object sender, RoutedEventArgs e)
        {
            InitialDataForCol4();
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class User2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set;}
    }
}
