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
using Microsoft.Win32;
using System.IO;

namespace WPFNepesseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Telepules> telepulesek;
        public MainWindow()
        {
            InitializeComponent();
            telepulesek = AdatokBetoltese("Adatok\\kozerdeku_lakossag_2022.csv");
            dgTelepulesek.ItemsSource = telepulesek;
            cbMegyek.ItemsSource = telepulesek.Select(obj => obj.Megye).Distinct().ToList();
        }

        private List<Telepules> AdatokBetoltese(string fajlNeve)
        {
            List<Telepules> ujLista = new List<Telepules>();

            string[] beolvasottSorok = File.ReadAllLines(fajlNeve);
            

            for (int index = 1; index < beolvasottSorok.Length; index++)
            {
                string[] mezok = beolvasottSorok[index].Split(";");
                Telepules ujTelepules = new Telepules(mezok[2], mezok[3], mezok[4], int.Parse(mezok[5].Replace(" ","")), int.Parse(mezok[6].Replace(" ", "")));
                ujLista.Add(ujTelepules);
            }
            
            /*
            foreach (string CSVsor in beolvasottSorok.Skip(1))
            {
                string[] mezok = CSVsor.Split(";");
                Telepules ujTelepules = new Telepules(mezok[2], mezok[3], mezok[4], int.Parse(mezok[5].Replace(" ", "")), int.Parse(mezok[6].Replace(" ", "")));
                ujLista.Add(ujTelepules);
            }
            */
            return ujLista;
        }

        private void cbMegyek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] beolvasottSorok = File.ReadAllLines("Adatok\\kozerdeku_lakossag_2022.csv");

            List<Telepules> szurtLista = new List<Telepules>();
            foreach (string sor in beolvasottSorok)
            {
                string[] mezok = sor.Split(";");
                if ()
                {

                }
            }
        }
    }
}
