using LINQtoCSV;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using VWA_Software_Demo.Database;

namespace VWA_Software_Demo
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.AppStarting;

            string vorname = tbVorname.Text;
            string nachname = tbNachname.Text;
            string passwort = pwbPasswordBox.Password;

            try
            {
                var context = new CsvContext();
                var csvFileDescreption = new CsvFileDescription
                {
                    FirstLineHasColumnNames = true,
                    IgnoreUnknownColumns = true,
                    SeparatorChar = ',',
                    UseFieldIndexForReadingData = false
                };

                var checkSchüler = from Schüler in context.Read<Schüler>(@"Schüler.csv", csvFileDescreption)
                                   where Schüler.Vorname == vorname &&
                                         Schüler.Nachname == nachname &&
                                         Schüler.Passwort == passwort
                                   select Schüler.PK_SchülerID;


                if (checkSchüler.Any())
                {
                    int id = checkSchüler.First();
                    (App.Current as App).ID = id;

                    var checkIfNull = from Wpf in context.Read<Wahlpflichtfächer>("Wahlpflichtfächer.csv", csvFileDescreption)
                                      where Wpf.Schüler == id
                                      select Wpf.Wahlpflichtfach_1;

                    if (checkIfNull.FirstOrDefault() != null)
                    {
                        if (MessageBox.Show("Du hast deine Wahlpflichtfächer bereits gewählt! Bist du sicher, dass du fortfahren möchtest? Die bereits gewählten Wahlpflichtfächer werden dann überschrieben!",
                                            "Warnung", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.No)
                        {
                            this.Close();
                        }
                    }

                    Mouse.OverrideCursor = Cursors.Arrow;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }

                else if (String.IsNullOrEmpty(vorname) || String.IsNullOrEmpty(nachname) || String.IsNullOrEmpty(passwort))
                {
                    MessageBox.Show("Bitte gib einen gültigen Namen\noder ein gültiges Passwort ein!", "Warnung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Mouse.OverrideCursor = Cursors.Arrow;
                }

                else
                {
                    MessageBox.Show("Falsches Passwort oder falscher Name!", "Warnung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du bist nicht mit dem Server verbunden!\nBitte melde diesen Fehler dem Administrator!\nFehler Code: " + ex.Message, "Server Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Mouse.OverrideCursor = Cursors.Arrow;
            }
        }


        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Drag(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}