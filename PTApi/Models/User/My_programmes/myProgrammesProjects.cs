namespace PTApi.Models
{
    public class myProgrammesProjects
    {
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public bool CanEdit { get; set; }
        public bool Following { get; set; }
        
    }
}
