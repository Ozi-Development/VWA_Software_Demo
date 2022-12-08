using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using VWA_Software_Demo.Core;
using VWA_Software_Demo.Database;
using System.IO;
using System.Runtime.InteropServices;

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
            int stundenzahl = (App.Current as App).Stundenzahl;

            if (stundenzahl < 8)
            {
                MessageBox.Show(string.Format("Du hast zu wenige Stunden gewählt!\nDir fehlen noch {0} Stunden!",
                                Convert.ToString(8 - stundenzahl)), "Warnung", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                List<Wahlpflichtfach> list = (App.Current as App).WpfList;
                int id = (App.Current as App).ID;
                int listCount = list.Count;

                string fileDirection = @"Database/Wahlpflichtfächer.csv";
                var context = new CsvContext();
                var csvFileDescreption = new CsvFileDescription
                {
                    FirstLineHasColumnNames = true,
                    SeparatorChar = ',',
                };


                switch (listCount)
                {
                    case 1:
                        var wpf1 = new List<Wahlpflichtfächer>
                        {
                            new Wahlpflichtfächer
                            {
                                PK_WahlpflichtfachID = id,
                                Schüler = id,
                                Wahlpflichtfach_1 = list[0].ToString(),
                                Wahlpflichtfach_2 = null,
                                Wahlpflichtfach_3 = null,
                                Wahlpflichtfach_4 = null,
                                Wahlpflichtfach_5 = null
                            }
                        };
                        context.Write(wpf1, fileDirection, csvFileDescreption);
                        break;

                    case 2:
                        var wpf2 = new List<Wahlpflichtfächer>
                        {
                            new Wahlpflichtfächer
                            {
                                PK_WahlpflichtfachID = id,
                                Schüler = id,
                                Wahlpflichtfach_1 = list[0].ToString(),
                                Wahlpflichtfach_2 = list[1].ToString(),
                                Wahlpflichtfach_3 = null,
                                Wahlpflichtfach_4 = null,
                                Wahlpflichtfach_5 = null
                            }
                        };
                        context.Write(wpf2, fileDirection, csvFileDescreption);
                        break;

                    case 3:
                        var wpf3 = new List<Wahlpflichtfächer>
                        {
                            new Wahlpflichtfächer
                            {
                                PK_WahlpflichtfachID = id,
                                Schüler = id,
                                Wahlpflichtfach_1 = list[0].ToString(),
                                Wahlpflichtfach_2 = list[1].ToString(),
                                Wahlpflichtfach_3 = list[2].ToString(),
                                Wahlpflichtfach_4 = null,
                                Wahlpflichtfach_5 = null
                            }
                        };
                        context.Write(wpf3, fileDirection, csvFileDescreption);
                        break;

                    case 4:
                        var wpf4 = new List<Wahlpflichtfächer>
                        {
                            new Wahlpflichtfächer
                            {
                                PK_WahlpflichtfachID = id,
                                Schüler = id,
                                Wahlpflichtfach_1 = list[0].ToString(),
                                Wahlpflichtfach_2 = list[1].ToString(),
                                Wahlpflichtfach_3 = list[2].ToString(),
                                Wahlpflichtfach_4 = list[3].ToString(),
                                Wahlpflichtfach_5 = null
                            }
                        };
                        context.Write(wpf4, fileDirection, csvFileDescreption);
                        break;

                    case 5:
                        var wpf5 = new List<Wahlpflichtfächer>
                        {
                            new Wahlpflichtfächer
                            {
                                PK_WahlpflichtfachID = id,
                                Schüler = id,
                                Wahlpflichtfach_1 = list[0].ToString(),
                                Wahlpflichtfach_2 = list[1].ToString(),
                                Wahlpflichtfach_3 = list[2].ToString(),
                                Wahlpflichtfach_4 = list[3].ToString(),
                                Wahlpflichtfach_5 = list[4].ToString()
                            }
                        };
                        context.Write(wpf5, fileDirection, csvFileDescreption);
                        break;

                    default:
                        MessageBox.Show("Du hast zu viele Wahlpflichtfächer gewählt!\nDie Datenbank unterstützt maximal 5 verschiedene!",
                                        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        Mouse.OverrideCursor = Cursors.Arrow;
                        return;
                }
            }
            MessageBox.Show("Deine Wahlpflichtfächer wurden erfolgreich eingereicht!",
                            "Erfolgreich eingereicht", MessageBoxButton.OK, MessageBoxImage.Information);
            Mouse.OverrideCursor = Cursors.Arrow;
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
