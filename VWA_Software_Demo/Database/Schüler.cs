using System;
using LINQtoCSV;

namespace VWA_Software_Demo.Database
{
    [Serializable]
    public class Schüler
    {
        [CsvColumn(Name = "PK_SchülerID", FieldIndex = 1)]
        public int PK_SchülerID { get; set; }


        [CsvColumn(Name = "Vorname", FieldIndex = 2)]
        public string Vorname { get; set; }


        [CsvColumn(Name = "Nachname", FieldIndex = 3)]
        public string Nachname { get; set; }


        [CsvColumn(Name = "Klasse", FieldIndex = 4)]
        public string Klasse { get; set; }


        [CsvColumn(Name = "Passwort", FieldIndex = 5)]
        public string Passwort { get; set; }
    }
}