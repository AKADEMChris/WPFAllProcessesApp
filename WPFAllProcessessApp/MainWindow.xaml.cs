using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFAllProcessessApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProcessManager processess { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            processess = new ProcessManager();
            ShowAll();
        }
        private Process[] GetAllProcesses()
        {
            return processess.GetAll();
        }
        private void ShowAll()
        {
            Process[] p = GetAllProcesses();
            foreach (var item in p)
            {
                ShowListView.Items.Add(item);
            }
        }
        private void ClearAll()
        {
            ShowListView.Items.Clear();
        }
        private void RefreshAll_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
            ShowAll();
        }
        private void SelectedItemInfo()
        {
            var selected = (Process)ShowListView.SelectedItem;
            try
            {
                MessageBox.Show($"ID - {selected.Id} \n" +
                    $"Name - {selected.ProcessName}  \n" +
                    $"Priority - {selected.BasePriority} \n" +
                    $"Responding - {selected.Responding} \n" +
                    $"Memory - {selected.VirtualMemorySize64}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetSelectedItem(object sender, MouseButtonEventArgs e)
        {
            SelectedItemInfo();
        }
    }
}
