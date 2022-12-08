using System;
using System.Windows;

namespace VWA_Software_Demo.Core
{
    internal class StundenzahlWarnung
    {
        private int _stundenzahl;
        private bool _stundenzahlBool;

        public bool StundenzahlBool
        {
            get { return _stundenzahlBool; }
            set { _stundenzahlBool = value; }
        }

        public int Stundenzahl
        {
            get { return _stundenzahl; }
            set
            {
                _stundenzahl = value;
                (App.Current as App).Stundenzahl = _stundenzahl;
            }
        }

        public void CheckStundenzahl()
        {
            if (_stundenzahl > 8)
            {
                if (MessageBox.Show(string.Format("Du hast zu viele Wahlpflichtfächer ausgewählt!\nDu hast aktuell {0} Stunden zu viel ausgewählt.\nBist du sicher, dass du fortfahren möchtest?",
                    Convert.ToString(_stundenzahl - 8)), "Warnung", MessageBoxButton.YesNo, MessageBoxImage.Hand) == MessageBoxResult.No)
                {
                    _stundenzahlBool = true;
                }
                else
                {
                    _stundenzahlBool = false;
                }
            }
        }
    }
}
