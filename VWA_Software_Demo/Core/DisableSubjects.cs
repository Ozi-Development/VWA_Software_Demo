using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VWA_Software.Core;
using VWA_Software.MVVM.View;

namespace VWA_Software.Core
{
    /// <summary>
    /// May not work because i cannot controll controlls outside of SelectionView.xaml.cs
    /// </summary>

    internal class DisableSubjects
    {
        SelectionView selectionView = new SelectionView();

        public void DisableDG(bool enabled)
        {
            selectionView.chkDG.IsEnabled = enabled;
        }

        public void DisableMusik(bool enabled)
        {
            selectionView.chkMusik.IsEnabled = enabled;
        }

        public void DisableBE(bool enabled)
        {
            selectionView.chkBE.IsEnabled = enabled;
        }


        public void DisableItalienisch_A(bool enabled)
        {
            selectionView.chkItalienisch_A.IsEnabled = enabled;
        }

        public void DisableFranzösisch_A(bool enabled)
        {
            selectionView.chkFranzösisch_A.IsEnabled = enabled;
        }

        public void DisableItalienisch_B(bool enabled)
        {
            throw new NotImplementedException();
        }

        public void DisableFranzösisch_B(bool enabled)
        {
            throw new NotImplementedException();
        }

        public void DisableLatein_B(bool enabled)
        {
            throw new NotImplementedException();
        }
    }
}
