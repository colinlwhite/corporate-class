using System;
using System.Collections.Generic;

namespace corporate_class
{
public class Program
{
    public static void Main(string[] args)
    {
        Company KairosHoldings = new Company("Kairos Holdings", new DateTime());
        
        var TeamMember1 = new Employees("Nassim Taleb", "Chief Risk Officer", new DateTime());
        var TeamMember2 = new Employees("Gary Vaynerchuk", "Chief Marketing Officer", new DateTime());
        var TeamMember3 = new Employees("Kanye West", "Chief Creative Officer", new DateTime());
        var TeamMember4 = new Employees("Ray Dalio", "Chief Investment Officer", new DateTime());
        var TeamMember5 = new Employees("Robert F. Smith", "Chief Technology Officer", new DateTime());
        var TeamMember6 = new Employees("Charles T. Munger", "Director Emeritus", new DateTime());

        KairosHoldings.AddATeamMember(TeamMember1);
        KairosHoldings.AddATeamMember(TeamMember2);
        KairosHoldings.AddATeamMember(TeamMember3);
        KairosHoldings.AddATeamMember(TeamMember4);
        KairosHoldings.AddATeamMember(TeamMember5);
        KairosHoldings.AddATeamMember(TeamMember6);

        KairosHoldings.ListEmployees();
    }
}
}
