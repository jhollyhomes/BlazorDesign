namespace SideMenuDesign.Models;

public class MenuItem
{
    public MenuItem(string name, string url, string svgName)
    {
        Name = name;
        Url = url;
        SvgName = svgName;
    }

    public string Name { get; set; } = default!;
    public string Url { get; set; } = default!;
    public string SvgName { get; set; } = default!;

    public List<MenuItem> ChildMenuItems { get; set; } = default!;
}
