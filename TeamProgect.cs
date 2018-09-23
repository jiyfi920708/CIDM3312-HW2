using System;

namespace Buffteks.Models
{
    public class TeamProject
    {
        public int TeamID
    {
        get
        {
            if(this.TeamID == 3)
            {
                return 9;
            }
            else{
                return this.TeamID;
            }
        }
        
        set
        {

        }
    }
        public Team TheTeam

        public int ProjectID {get;set;}

        public Project TheProject {get;set;}
    }
}
