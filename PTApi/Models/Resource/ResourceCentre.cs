namespace PTApi.Models
{
    // [Table("ResourceCentres")]
    // public class ResourceCentre : BaseEntity
    // {
    //     [Key]
    //     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //     public string ResourceCentreId { get; set; }
    //     public string CompanyId { get; set; }
    //     [Required]
    //     public string AppUserRole {get;set;}
    //      [ForeignKey("CompanyId")]
    //     public Company Company { get; set; }
    //     public string ResourceId { get; set; }
    //     [ForeignKey("ResourceId")]
    //     public Resource Resource { get; set; }
    //     public string ProjectId { get; set; }
    //     [ForeignKey("ProjectId")]
    //     public Project Project { get; set; }
    //     public string IdentityId { get; set; }
    //     [ForeignKey("IdentityId")]
    //     public AppUser Identity { get; set; }
    //     public string AlternateCompanyId { get; set; }
    //     public string FirstName { get; set; }
    //     public string LastName { get; set; }
    //     public string DisplayName
    //     {
    //         get { return LastName + "," + " " + FirstName; }
    //     }

    //     public string AddedBy { get; set; }
    //     public ICollection<BusinessUnit> BusinessUnits { get; set; }
    //     public ICollection<Domain> Domains { get; set; }
    //     public ICollection<Portfolio> Portfolios { get; set; }
    //     public ICollection<Programme> Programmes { get; set; }
    //     public ICollection<Project> Projects { get; set; }
    //     public ICollection<BusinessUnitPermitted> BusinessUnitsPermitted { get; set; }
    //     public ICollection<DomainPermitted> DomainsPermitted { get; set; }
    //     public ICollection<PortfolioPermitted> PortfoliosPermitted { get; set; }
    //     public ICollection<ProgrammePermitted> ProgrammesPermitted { get; set; }
    //     public ICollection<ProjectPermitted> ProjectsPermitted { get; set; }
    //     public ICollection<Resource> Resources { get; set; }
    //     public ResourceCentre()
    //     {
    //         Resources = new Collection<Resource>();
    //         BusinessUnitsPermitted = new Collection<BusinessUnitPermitted>();
    //         DomainsPermitted = new Collection<DomainPermitted>();
    //         PortfoliosPermitted = new Collection<PortfolioPermitted>();
    //         ProgrammesPermitted = new Collection<ProgrammePermitted>();
    //         ProjectsPermitted = new Collection<ProjectPermitted>();

    //         BusinessUnits = new Collection<BusinessUnit>();
    //         Domains = new Collection<Domain>();
    //         Portfolios = new Collection<Portfolio>();
    //         Programmes = new Collection<Programme>();
    //         Projects = new Collection<Project>();
    //     }  // navigation property
    // }
}