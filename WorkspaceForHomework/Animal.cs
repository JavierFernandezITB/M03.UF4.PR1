


using System.Runtime.CompilerServices;

namespace WorkspaceForHomework
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Specie { get; set; }
        public int Weight { get; set; }
        public int AffectionGrade { get; set; }

        public Animal(string _name = "Default", string _family = "Default", string _specie = "Default", int _peso = 15, int _affectionGrade = 45)
        {
            Name = _name;
            Family = _family;
            Specie = _specie;
            Weight = _peso;
            AffectionGrade = _affectionGrade;
        }

        public int CalculateAffectionGrade(int choice)
        {
            int newAffection = 0;
            switch (this.Family)
            {
                case "Tortuga marina":
                    newAffection = this.AffectionGrade - ((this.AffectionGrade - 2)*(2 * AffectionGrade + 3)) - 5;
                    break;
                case "Ave marina":
                    newAffection = this.AffectionGrade - ((int)Math.Pow(this.AffectionGrade, 2) + (choice == 1 ? 5 : 0));
                    break;
                case "Cetaci":
                    newAffection = this.AffectionGrade - ((int)Math.Log10(this.AffectionGrade) - (choice == 1 ? 25 : 0)); ;
                    break;

            }
            this.AffectionGrade = newAffection;
            return newAffection;
        }
    }
}
