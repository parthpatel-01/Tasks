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

namespace Tasks.View.UserControls
{
    /// <summary>
    /// Interaction logic for AddNewTask.xaml
    /// </summary>
    public partial class AddNewTask : UserControl
    {
        public AddNewTask()
        {
            InitializeComponent();
        }

        private void NewTaskBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(NewTaskBox.Text != "")
            {
                NewTaskBlk.Visibility = Visibility.Hidden;
            } else if (NewTaskBox.Text == "")
            {
                NewTaskBlk.Visibility = Visibility.Visible;
            }
        }

        private void AddTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            NewTaskBox.Text = string.Empty;
        }
    }
}
