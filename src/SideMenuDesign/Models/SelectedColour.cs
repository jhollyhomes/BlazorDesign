using SideMenuDesign.Enums;

namespace SideMenuDesign.Models;

public class SelectedColour
{
    public SelectedColour(string colour, string shade)
    {
        Colour = colour;
        Shade = shade;
    }
    public SelectedColour(string colour)
    {
        Colour = colour;
    }
    public string Colour { get; set; } = default!;
    public string Shade { get; set; } = default!;

    public string CreateColourCss(CssTypes cssType)
    {
        if (Colour == "white")
        {
            return cssType switch
            {
                CssTypes.Text => "text-white",
                CssTypes.Background => "bg-white",
                CssTypes.HoverBackground => "hover:bg-white",
                CssTypes.HoverText => "hover:text-white",
                _ => string.Empty
            };
        }

        if (Colour == "black")
        {
            return cssType switch
            {
                CssTypes.Text => "text-black",
                CssTypes.Background => "bg-black",
                CssTypes.HoverBackground => "hover:bg-black",
                CssTypes.HoverText => "hover:text-black",
                _ => string.Empty
            };
        }

        return cssType switch
        {
            CssTypes.Text => string.Concat("text-", Colour, "-", Shade),
            CssTypes.Background => string.Concat("bg-", Colour, "-", Shade),
            CssTypes.HoverBackground => string.Concat("hover:bg-", Colour, "-", Shade),
            CssTypes.HoverText => string.Concat("hover:text-", Colour, "-", Shade),
            _ => string.Empty
        };
    }
}

