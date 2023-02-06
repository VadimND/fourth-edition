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

namespace SwordDamageWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random = new Random();
        //SwordDamage swordDamage = new SwordDamage();
        SwordDamageNext swordDamage;

        public MainWindow()
        {
            InitializeComponent();
            swordDamage = new SwordDamageNext(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
            DisplayDamage();
            //swordDamage.SetMagic(false);
            //swordDamage.SetFlaming(false);
            //RollDice();
        }
        public void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);  
            DisplayDamage();
        }
        /*public void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage.SetMagic(Magic.IsChecked.Value);
            swordDamage.SetFlaming(Flaming.IsChecked.Value);            
            DisplayDamage();
        }
        */
        void DisplayDamage()         
        {
            damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = true;
            DisplayDamage();
        }
        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = false;
            DisplayDamage();
        }
        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = true;
            DisplayDamage();
        }
        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = false;
            DisplayDamage();
        }
    }
}
