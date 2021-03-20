using System;
using System.Collections;
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

namespace PersonalityQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    static class MyVariables
    {
        public static string result;
        public static string description;
    }
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //defining variables for each of the personality types
        int babka = 0;
        int bran = 0;
        int lG = 0;
        int cocoa = 0;
               
        //question #1
        private void question1ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = question1ListBox.SelectedIndex;
            if (choice == 0) { bran++; }
            if (choice == 1) { cocoa++; }
            if (choice == 2) { babka++; }
            if (choice == 3) { lG++; }
        }
        
        //question #2
        private void question2ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = question2ListBox.SelectedIndex;
            if (choice == 0) { lG++; }
            if (choice == 1) { babka++; }
            if (choice == 2) { bran++; }
            if (choice == 3) { cocoa++; }
        }
        
        //question #3
        private void question3ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = question3ListBox.SelectedIndex;
            if (choice == 0) { cocoa++; }
            if (choice == 1) { babka++; }
            if (choice == 2) { lG++; }
            if (choice == 3) { bran++; }
        }
       
        //question #4
        private void question4ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = question4ListBox.SelectedIndex;
            if (choice == 0) { cocoa++; }
            if (choice == 1) { bran++; }
            if (choice == 2) { lG++; }
            if (choice == 3) { babka++; }
        }
        
        //question #5
        private void question5ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = question5ListBox.SelectedIndex;
            if (choice == 0) { cocoa++; }
            if (choice == 1) { lG++; }
            if (choice == 2) { babka++; }
            if (choice == 3) { bran++; }
        }

        //figuring out which personality type is dominant
        //note: i don't have a good method for handling tied scores :(
        public void calculateResults()
        {
            if (babka >= bran && babka >= lG && babka >= cocoa) { MyVariables.result = "Babka"; }
            else if (bran >= lG && bran >= cocoa) { MyVariables.result = "Bran"; }
            else if (lG >= cocoa) { MyVariables.result = "Lady Grey"; }
            else { MyVariables.result = "Cocoa"; }

            //personality type descriptions
            var types = new Dictionary<string, string>()
            {
                {"Babka", "You're a kind-hearted soul with a rosy lens on the world (and the couch.) You're affectionate with your loved ones, and tasty morsels are often your love language. Your main goal in life is more couch time." },
                {"Bran", "You're a go-getter who isn't afraid to be the center of attention. Your favorite holiday is probably Halloween because you live doing tricks for treats (not in a weird way). You love to talk about, well, pretty much anything." },
                {"Lady Grey", "You're smart and scrappy and love to voice your opinion. Speaking of which, these opinions might be strong and come at inconvenient times of day for those around you. Only those you trust most ever see you in your happy place: snoozing belly-up style." },
                {"Cocoa", "You're curious by nature and love to learn about the world around you. Good weather brings out your playful side, but most days, you're probably avoiding most forms of social contact. Snack foods are your one true love." }
            };

            //asign the description based on the result
            MyVariables.description = types[MyVariables.result];

        }

        private void resultsButton_Click(object sender, RoutedEventArgs e)
        {
            //make the second window appear after clicking the button
            ResultsWindow objResultsWindow = new ResultsWindow();
            objResultsWindow.Show();

        }
    }
}
