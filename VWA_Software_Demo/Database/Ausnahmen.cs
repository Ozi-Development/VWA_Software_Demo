using System;
using LINQtoCSV;

namespace VWA_Software_Demo.Database
{
    [Serializable]
    public class Ausnahmen
    {
        [CsvColumn(Name = "PK_AusnahmeID", FieldIndex = 1)]
        public int PK_AusnahmeID { get; set; }


        [CsvColumn(Name = "Schüler", FieldIndex = 2)]
        public int Schüler { get; set; }


        [CsvColumn(Name = "Gymnasium", FieldIndex = 3)]
        public bool Gymnasium { get; set; }


        [CsvColumn(Name = "Französisch_Pflichtfach", FieldIndex = 4)]
        public bool Französisch_Pflichtfach { get; set; }


        [CsvColumn(Name = "Italienisch_Pflichtfach", FieldIndex = 5)]
        public bool Italienisch_Pflichtfach { get; set; }


        [CsvColumn(Name = "Latein_Pflichtfach", FieldIndex = 6)]
        public bool Latein_Pflichtfach { get; set; }


        [CsvColumn(Name = "BE_Pflichtfach", FieldIndex = 7)]
        public bool BE_Pflichtfach { get; set; }


        [CsvColumn(Name = "Religion_Pflichtfach", FieldIndex = 8)]
        public bool Religion_Pflichtfach { get; set; }
    }
}