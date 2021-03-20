using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonalityQuiz
{
    /// <summary>
    /// Interaction logic for ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        string displayResult = MainWindow.result;
        string displayDescription = MainWindow.description;
        public ResultsWindow()
        {
            InitializeComponent();

            resultBlock.Text = displayResult;
            descriptionBlock.Text = displayDescription;
        }
    }
}
