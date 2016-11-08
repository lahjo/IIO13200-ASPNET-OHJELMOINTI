using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for theater
/// </summary>
public class theater
{
        // Huom public field ei keplaa WPF DataBinding:ssa, pitää olla Property
    public string Name { get; set; }
    public int ID { get; set; }
    public List<string> theaterList { get; set;}

    public theater(string name, int ID)
    {
        this.Name = name;
        this.ID = ID;
    }

    public override string ToString()
    {
        return string.Format(Name);
    }
}