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

namespace DemocC03_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Profs { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Profs = new List<string>() {
        "Luc Forcier",
        "Marco Guay",
        "Noémie Rochette",
        "Ridha Louati",
        "Gilles Portelance",
        "Xavier Samuel Huppé"
        };
            panneau.DataContext = this;
        }


        private void BtnSupprimerProf_Click(object sender, RoutedEventArgs e)
        {
            string nomProf = listeProfs.SelectedItem as string;
            if (nomProf != null) // non-requis
                Profs.Remove(nomProf);
        }

        private void BtnAjouterNouveauProf_Click(object sender, RoutedEventArgs e)
        {
            Profs.Add(tbNom.Text);
        }

    }
}
