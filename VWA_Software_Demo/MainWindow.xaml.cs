using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using VWA_Software_Demo.Core;
using VWA_Software_Demo.Database;

namespace VWA_Software_Demo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEinreichen_Click(object sender, RoutedEventArgs e)
        {
            StundenzahlWarnung stundenzahlWarnung = new StundenzahlWarnung();

            int stundenzahl = (App.Current as App).Stundenzahl;
            int id = (App.Current as App).ID;

            List<Wahlpflichtfach> list = new List<Wahlpflichtfach>();
            list = (App.Current as App).WpfList;
            int listCount = list.Count;


            if (stundenzahl < 8)
            {
                MessageBox.Show(string.Format("Du hast zu wenige Stunden gewählt!\nDir fehlen noch {0} Stunden!",
                                Convert.ToString(8 - stundenzahl)), "Warnung", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            // No WPFs will be added !!
            else
            {
                //var context = new CsvContext();
                //var csvFileDescreption = new CsvFileDescription
                //{
                //    FirstLineHasColumnNames = true,
                //    SeparatorChar = ','
                //};

                //Mouse.OverrideCursor = Cursors.Wait;

                //var schüler = from WPF in context.Read<Wahlpflichtfächer>("Database/Wahlpflichtfächer.csv", csvFileDescreption)
                //              where WPF.Schüler == id
                //              select WPF;


                //foreach (var addWpf in schüler)
                //{
                //    addWpf.Wahlpflichtfach_1 = null;
                //    addWpf.Wahlpflichtfach_2 = null;
                //    addWpf.Wahlpflichtfach_3 = null;
                //    addWpf.Wahlpflichtfach_4 = null;
                //    addWpf.Wahlpflichtfach_5 = null;

                //    switch (listCount)
                //    {
                //        case 1:
                //            addWpf.Wahlpflichtfach_1 = list[0].ToString();
                //            break;

                //        case 2:
                //            addWpf.Wahlpflichtfach_1 = list[0].ToString();
                //            addWpf.Wahlpflichtfach_2 = list[1].ToString();
                //            break;

                //        case 3:
                //            addWpf.Wahlpflichtfach_1 = list[0].ToString();
                //            addWpf.Wahlpflichtfach_2 = list[1].ToString();
                //            addWpf.Wahlpflichtfach_3 = list[2].ToString();
                //            break;

                //        case 4:
                //            addWpf.Wahlpflichtfach_1 = list[0].ToString();
                //            addWpf.Wahlpflichtfach_2 = list[1].ToString();
                //            addWpf.Wahlpflichtfach_3 = list[2].ToString();
                //            addWpf.Wahlpflichtfach_4 = list[3].ToString();
                //            break;

                //        case 5:
                //            addWpf.Wahlpflichtfach_1 = list[0].ToString();
                //            addWpf.Wahlpflichtfach_2 = list[1].ToString();
                //            addWpf.Wahlpflichtfach_3 = list[2].ToString();
                //            addWpf.Wahlpflichtfach_4 = list[3].ToString();
                //            addWpf.Wahlpflichtfach_5 = list[4].ToString();
                //            break;

                //        default:
                //            MessageBox.Show("Du hast zu viele Wahlpflichtfächer gewählt!\nDie Datenbank unterstützt maximal 5 verschiedene!",
                //                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //            Mouse.OverrideCursor = Cursors.Arrow;
                //            return;
                //    }

                MessageBox.Show("Deine Wahlpflichtfächer wurden erfolgreich eingereicht!",
                                    "Erfolgreich eingereicht", MessageBoxButton.OK, MessageBoxImage.Information);
                Mouse.OverrideCursor = Cursors.Arrow;
                //}
            }
        }


        private void Drag(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
