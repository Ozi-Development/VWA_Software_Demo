using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWA_Software.Core
{
    internal class SaveName
    {
		private string _vorname;
		private string _nachname;
		private string _passwort;


		public string Vorname
		{
			get { return _vorname; }
			set { _vorname = value; }
		}

		public string Nachname
		{
			get { return _nachname; }
			set { _nachname = value; }
		}

		public string Passwort
		{
			get { return _passwort; }
			set { _passwort = value; }
		}

	}
}
