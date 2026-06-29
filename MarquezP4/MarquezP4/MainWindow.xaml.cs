using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
//willow marquez
//wmarquez4@cnm.edu
//MarquezP4

using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;
using System.Collections.Generic;
using System.Windows;

namespace MarquezP4
{
   

    //interface definition 
    interface InventoryCommand
    {
        void Do();
        void Undo();
    }

    // Obj 8.1 data class representing item in inventory
    public class InventoryItem
    {
        public string Name { get; set; }
        //single parameter constructor
        public InventoryItem(string name)
        {
            Name = name;
        }

        //overriden ToString
        public override string ToString()
        {
            return Name;
        }
    }

    //Obj 8.2 concrete interface implementation 
    public class AddOneCommand : InventoryCommand
    {
        public InventoryItem Item { get; set; }
        public List<InventoryItem> TargetList { get; set; }

        //two parameter constructor
        public AddOneCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item;
            TargetList = targetList;
        }

        public void Do()
        {
            TargetList.Add(Item);
        }
        public void Undo()
        {
            TargetList.Remove(Item);
        }
    }

    // interface inplementation add random 1-5 number of items
    public class AddMultipleCommand : InventoryCommand
    {
        private int number;
        private static readonly Random random = new Random();

        public InventoryItem Item { get; set; }
        public List<InventoryItem> TargetList { get; set; }

        //two parameter constructor
        public AddMultipleCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item;
            TargetList = targetList;
        }

        public void Do()
        {
            number = random.Next(1, 5);

            for (int i = 0; i < number; i++)
            {
                TargetList.Add(Item);
            }
        }

        public void Undo()
        {
            for (int i = 0; i < number; i++)
            {
                TargetList.Remove(Item);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    //interaction logic
    public partial class MainWindow : Window
    {
        private List<InventoryItem> inventoryItems = new List<InventoryItem>();
        private List<InventoryCommand> commands = new List<InventoryCommand>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //helper function to refresh
        private void UpdateInventoryUI()
        {
            lstInventory.ItemsSource = null;
            lstInventory.ItemsSource = inventoryItems;
        }

        //event handler
        private void btnAddOne_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text)) return;

            //create new inventory item using text from text box
            InventoryItem newItem = new InventoryItem(txtItemName.Text.Trim());
            AddOneCommand command = new AddOneCommand(newItem, inventoryItems);
           
            //add command
            command.Do();
            commands.Add(command);
            UpdateInventoryUI();
            txtItemName.Clear(); 
        }

        private void btnAddMultiple_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text)) return;
            //create new inventory item using text form text
            InventoryItem newItem = new InventoryItem(txtItemName.Text.Trim());
            AddMultipleCommand command = new AddMultipleCommand(newItem, inventoryItems);

            //command add multiple
            command.Do();
            commands.Add(command);
            UpdateInventoryUI();
            txtItemName.Clear();
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            //check if there are commands to undo
            if (commands.Count >0)
            {
                int lastIndex= commands.Count-1;
                InventoryCommand lastCommand = commands[lastIndex];
                lastCommand.Undo();
                commands.RemoveAt(lastIndex);
                UpdateInventoryUI();
            }
        }
    }
}