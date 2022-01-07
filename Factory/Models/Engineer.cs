using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
      get { return FirstName + " " + LastName; }
    }
    public string Title { get; set; }

    public string Status { get; set; }
    public string[] StatusOptions = new[] { "Idle", "Active" };
    public virtual ICollection<MachineEngineer> JoinEntities { get; }
  }
}