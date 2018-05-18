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

namespace Neo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<ProteinDatabase> databases = new List<ProteinDatabase>();
            databases.Add(new ProteinDatabase() { Use = true, Contaminant = false, FileName = "Canonical Human Protein Reference Database.fasta" });
            databases.Add(new ProteinDatabase() { Use = true, Contaminant = false, FileName = "Epstein-Barr virus (strain B95-8) Protein Reference.fasta" });
            databases.Add(new ProteinDatabase() { Use = true, Contaminant = true, FileName = "Common Laboratory Contaminant Protein Reference Database.fasta" });
            dataGridProteinDatabases.ItemsSource = databases;
        }

        public class ProteinDatabase
        {
            public bool Use { get; set; }

            public bool Contaminant { get; set; }

            public string FileName { get; set; }
        }
    }
}
