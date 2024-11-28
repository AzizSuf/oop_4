using StressTest;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;



namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            materialsListBox.ItemsSource = Enum.GetValues(typeof(Material));
            cressSectionsListBox.ItemsSource = Enum.GetValues(typeof(CrossSection));
            testResultsListBox.ItemsSource = Enum.GetValues(typeof(TestResult));
        }

        private void materialsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (materialsListBox.SelectedItem == null)
            {
                return;
            }

            Material selectedMaterial = (Material)materialsListBox.SelectedItem;

            StringBuilder selectionStringBuilder = new StringBuilder();
            switch (selectedMaterial)
            {
                case Material.StainlessSteel:
                    selectionStringBuilder.Append("Stainless Steel");
                    break;
                case Material.Aluminium:
                    selectionStringBuilder.Append("Aluminium");
                    break;
                case Material.ReinforcedConcrete:
                    selectionStringBuilder.Append("Reinforced Concrete");
                    break;
                case Material.Composite:
                    selectionStringBuilder.Append("Composite");
                    break;
                case Material.Titanium:
                    selectionStringBuilder.Append("Titanium");
                    break;
            }
            selectedMaterialLabel.Content = selectionStringBuilder.ToString();
        }

        private void cressSectionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cressSectionsListBox.SelectedItem == null)
            {
                return;
            }

            CrossSection selectedCressSection = (CrossSection)cressSectionsListBox.SelectedItem;

            StringBuilder selectionStringBuilder = new StringBuilder();
            switch (selectedCressSection)
            {
                case CrossSection.IBeam:
                    selectionStringBuilder.Append("I-Beam");
                    break;
                case CrossSection.Box:
                    selectionStringBuilder.Append("Box");
                    break;
                case CrossSection.ZShaped:
                    selectionStringBuilder.Append("Z-Shaped");
                    break;
                case CrossSection.CShaped:
                    selectionStringBuilder.Append("C-Shaped");
                    break;
            }

            selectedCrossSectionLabel.Content = selectionStringBuilder.ToString();
        }

        private void testResultsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (testResultsListBox.SelectedItem == null)
            {
                return;
            }

            TestResult selectedTestResult = (TestResult)testResultsListBox.SelectedItem;

            StringBuilder selectionStringBuilder = new StringBuilder();
            switch (selectedTestResult)
            {
                case TestResult.Pass:
                    selectionStringBuilder.Append("Pass");
                    break;
                case TestResult.Fail:
                    selectionStringBuilder.Append("Fail");
                    break;
            }
            selectedTestResultLabel.Content = selectionStringBuilder.ToString();
        }

        private void runTestsButon_Click(object sender, RoutedEventArgs e)
        {
            logTextBlock.Document.Blocks.Clear();

            TestCaseResult[] testCaseResults = new TestCaseResult[10];

            for (int i = 0; i < testCaseResults.Length; i++)
            {
                testCaseResults[i] = TestManager.GenerateResult();
            }

            foreach (var item in testCaseResults)
            {
                logTextBlock.AppendText($"[{item.Result}]  {item.ReasonForFailure}\r"); 
            }

        }
    }
}
