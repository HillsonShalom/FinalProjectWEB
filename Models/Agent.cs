using FinalProjectWEB.Services.BaseModels;

namespace FinalProjectWEB.Models
{
    
    public class Agent : EntityInSpace
    {
        public AgentStatus Status { get; set; } = AgentStatus.Dormant;
    }
}
