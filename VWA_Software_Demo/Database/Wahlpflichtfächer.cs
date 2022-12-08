using System;
using LINQtoCSV;

namespace VWA_Software_Demo.Database
{
    [Serializable]
    public class Wahlpflichtfächer
    {
        [CsvColumn(Name = "PK_WahlpflichtfachID", FieldIndex = 1)]
        public int PK_WahlpflichtfachID { get; set; }


        [CsvColumn(Name = "Schüler", FieldIndex = 2)]
        public int Schüler { get; set; }


        [CsvColumn(Name = "Wahlpflichtfach_1", FieldIndex = 3)]
        public string Wahlpflichtfach_1 { get; set; }


        [CsvColumn(Name = "Wahlpflichtfach_2", FieldIndex = 4)]
        public string Wahlpflichtfach_2 { get; set; }


        [CsvColumn(Name = "Wahlpflichtfach_3", FieldIndex = 5)]
        public string Wahlpflichtfach_3 { get; set; }


        [CsvColumn(Name = "Wahlpflichtfach_4", FieldIndex = 6)]
        public string Wahlpflichtfach_4 { get; set; }


        [CsvColumn(Name = "Wahlpflichtfach_5", FieldIndex = 7)]
        public string Wahlpflichtfach_5 { get; set; }
    }
}