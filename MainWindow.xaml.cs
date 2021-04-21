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
using System.IO;

namespace hacksu_grocery_list_lesson
{
    // references system.windows.forms
    // added namespace system.io
    public partial class MainWindow : Window
    {
        public string groceryselFilePath = Directory.GetCurrentDirectory() + "../../../grocery_selection_list.txt";
        public MainWindow()
        {
            InitializeComponent();
            string[] existingGrocerySelectionList = File.ReadAllLines(groceryselFilePath);
            for (int i = 0; i < existingGrocerySelectionList.Length; i++)
            {
                grocerySelList.Items.Add(existingGrocerySelectionList[i]);
            }
        }

        private void grocerySelNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                grocerySelLocationBox.Focus();
            }
        }

        private void grocerySelLocationBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string grocerySelItem = grocerySelNameBox.Text + " - " + grocerySelLocationBox.Text;
                grocerySelList.Items.Add(grocerySelItem);
                grocerySelNameBox.Text = "";
                grocerySelLocationBox.Text = "";
                grocerySelNameBox.Focus();
            }
        }

        private void grocerySelList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Convert.ToBoolean(addSelBtn.IsChecked))
            {
                groceryList.Items.Add(grocerySelList.SelectedItem);
            }
            else if (Convert.ToBoolean(removeSelBtn.IsChecked))
            {
                grocerySelList.Items.Remove(grocerySelList.SelectedItem);
            }
            grocerySelList.UnselectAll();
            groceryList.UnselectAll();
        }

        private void groceryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            groceryList.Items.Remove(groceryList.SelectedItem);
            groceryList.UnselectAll();
        }

        private void clearSelList_Click(object sender, RoutedEventArgs e)
        {
            grocerySelList.Items.Clear();
        }

        private void clearList_Click(object sender, RoutedEventArgs e)
        {
            groceryList.Items.Clear();
        }

        private void saveList_Click(object sender, RoutedEventArgs e)
        {
            List<string> grocery_items_list = new List<string>();
            foreach (string str in groceryList.Items)
            {
                grocery_items_list.Add(str);
            }
            string[] groceryItems = new string[grocery_items_list.Count];
            for (int i = 0; i < grocery_items_list.Count; i++)
            {
                groceryItems[i] = grocery_items_list[i];
            }
            System.Windows.Forms.SaveFileDialog saveFileDiag = new System.Windows.Forms.SaveFileDialog();
            saveFileDiag.Filter = "Text File|*.txt";
            saveFileDiag.Title = "Save Grocery List";
            saveFileDiag.ShowDialog();

            if (saveFileDiag.FileName != "")
            {
                File.WriteAllLines(saveFileDiag.FileName, groceryItems);
            }

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            List<string> grocery_items_list = new List<string>();
            foreach (string str in grocerySelList.Items)
            {
                grocery_items_list.Add(str);
            }
            string[] groceryItems = new string[grocery_items_list.Count];
            for (int i = 0; i < grocery_items_list.Count; i++)
            {
                groceryItems[i] = grocery_items_list[i];
            }
            File.WriteAllLines(groceryselFilePath, groceryItems);
        }
    }
}
