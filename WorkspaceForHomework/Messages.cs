namespace WorkspaceForHomework
{
    internal class Messages
    {
        public const string GameTitleMessage = "Save the ocean!";
        public const string ChoiceMessage = "Que deseas hacer?\n1. Jugar!\n2. Salir";
        public const string JobChoiceMessage = "Perfecto! Con que rol quieres jugar?\n1. Tècnic (45 XP)\n2. Veterinari (80 XP)";
        public const string NameSelectionMessage = "Muy bien. Cual es tu nombre?";
        public const string NewJobAlertMessage = "Hola, {0}! El 112 ha recibido una llamada de avido sobre un ejemplar que necesita rescate.\nEstos son los datos sobre el caso:";
        public const string JobAlertInfoMessage = "Aquí tienes la ficha del animal:";
        public const string ActionChoiceMessage = "El {0} tiene un grado de afectación del {1}%. Deseas curarla aquí (1) o trasladarla al centro de cuidados (2)?";
        public const string TreatmentAppliedMessage = "El tratamiento aplicado ha reducido el grado de afectación hasta un {0}% ";
        public const string NotEnoughMessage = "No ha sido suficientemente eficiente y se requiere trasladar al animal al centro. Se te ha reducido la experiencia. (-{0}XP)";
        public const string EnoughMessage = "El animal se ha conseguido recuperar y puede volver a su hábitat. Tu experiencia ha aumentado. (+{0}XP)";
        public const string HastaLaProximaMessage = "Hasta la proximaaa!!!";


        public const string LayoutRescue = "+-----------------------------------------------------------------------+\r\n|\t\t\t\tRESCAT\t\t\t\t\t|\r\n+-----------------------------------------------------------------------+\r\n| # Rescat\t| Data rescat\t| Superfamília\t| GA\t| Localització\t|\r\n+-----------------------------------------------------------------------+\n| RES{0}\t| 13-02-2024\t| {1}\t\t| {2}\t| Cadaquès\t|\n+-----------------------------------------------------------------------+";
        public const string LayoutPaper = "+-------------------------------------------------------+\r\n|\t\t\tFITXA\t\t\t\t|\r\n+-------------------------------------------------------+\r\n| # Nom\t| Superfamília\t| Espècie\t| Pes aproximat\t|\r\n+-------------------------------------------------------+\n| {0}\t| {1}\t\t| {2}\t| {3}kg\t\t|\n+-------------------------------------------------------+\r\n";
    }
}
