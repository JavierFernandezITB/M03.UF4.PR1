


namespace WorkspaceForHomework
{
    public class Voluntario
    {
        public string Name { get; set; }
        public int Job { get; set; }
        public int XP { get; set; }
        

        public Voluntario(int _job) 
        {
            this.Job = _job;
        }
    }
}
