namespace SideMenuDesign.State;

public class ThemeState
{
    public ThemeState()
    {
        ContentBackgroundColour = "bg-gray-100";
        ContentTitleTextColour = "text-gray-700";
        ContentSectionBackColour = "bg-white";
        ContentSectionRounded = true;
        ContentSectionShadow = true;
        ContentSectionTitleColour = "text-gray-800";
        ContentSectionParagraphColour = "text-gray-800";
        ContentSectionLabelColour = "text-gray-800";

        SideBarTitleManageMiColour = "text-gray-100";
        SideBarTitleOtherColour = "text-indigo-500";
        SideBarBackgroundColour = "bg-gray-900";
        SideBarSelectedBackgroundColour = "bg-gray-950";
        SideBarTextTitleColour = "text-white";
        SideBarButtonColour = "bg-gray-900";
        SideBarButtonHoverColour = "hover:bg-gray-800";
        SideBarButtonIconColour = "text-indigo-500";
        SideBarButtonTextColour = "text-gray-100";

        BurgerBackColour = "bg-white";
        BurgerHoverBackColour = "hover:bg-gray-100";
        BurgerIconColour = "text-gray-500";

        TopBarBackColour = "bg-white";
        TopBarIconColour = "text-gray-400";
        TopBarIconHoverColour = "hover:text-gray-600";
        TopBarTextColour = "text-gray-400";
        TopBarTextHoverColour = "hover:text-gray-600";
        TopBarDividerColour = "bg-gray-200";
        TopBarShadow = true;

        ButtonTextColour = "text-white";
        ButtonColour = "bg-indigo-600";
        ButtonHoverColour = "bg-indigo-500";
        CheckBoxColour = "text-indigo-600";
    }

    public string ContentBackgroundColour { get; private set; } = default!;
    public string ContentTitleTextColour { get; private set; } = default!;
    public string ContentSectionBackColour { get; private set; } = default!;
    public bool ContentSectionRounded { get; private set; } = default!;
    public bool ContentSectionShadow { get; private set; } = default!;
    public string ContentSectionTitleColour { get; private set; } = default!;
    public string ContentSectionParagraphColour { get; private set; } = default!;
    public string ContentSectionLabelColour { get; private set; } = default!;

    public string ButtonTextColour { get; private set; } = default!;
    public string ButtonColour { get; private set; } = default!;
    public string ButtonHoverColour { get; private set; } = default!;
    public string CheckBoxColour { get; private set; } = default!;
    public string SideBarTitleManageMiColour { get; private set; } = default!;
    public string SideBarTitleOtherColour { get; private set; } = default!;
    public string SideBarBackgroundColour { get; private set; } = default!;
    public string SideBarSelectedBackgroundColour { get; private set; } = default!;
    public string SideBarTextTitleColour { get; private set; } = default!;
    public string SideBarButtonColour { get; private set; } = default!;
    public string SideBarButtonHoverColour { get; private set; } = default!;
    public string SideBarButtonIconColour { get; private set; } = default!;
    public string SideBarButtonTextColour { get; private set; } = default!;

    public string BurgerBackColour { get; private set; } = default!;
    public string BurgerHoverBackColour { get; private set; } = default!;
    public string BurgerIconColour { get; private set; } = default!;

    public string TopBarBackColour { get; private set; } = default!;
    public string TopBarIconColour { get; private set; } = default!;
    public string TopBarIconHoverColour { get; private set; } = default!;
    public string TopBarTextColour { get; private set; } = default!;
    public string TopBarTextHoverColour { get; private set; } = default!;
    public string TopBarDividerColour { get; private set; } = default!;
    public bool TopBarShadow { get; private set; } = default!;

    public event Action? OnStateChange;

    public void SetContentBackgroundColour(string value)
    {
        ContentBackgroundColour = value;
        NotifyStateChanged();
    }
    public void SetContentTitleTextColour(string value)
    {
        ContentTitleTextColour = value;
        NotifyStateChanged();
    }

    public void SetContentSectionBackColour(string value)
    {
        ContentSectionBackColour = value;
        NotifyStateChanged();
    }

    public void SetContentSectionRounded(bool value)
    {
        ContentSectionRounded = value;
        NotifyStateChanged();
    }
    public void SetContentSectionShadow(bool value)
    {
        ContentSectionShadow = value;
        NotifyStateChanged();
    }
    
    public void SetContentSectionTitleColour(string value)
    {
        ContentSectionTitleColour = value;
        NotifyStateChanged();
    }

    public void SetContentSectionParagraphColour(string value)
    {
        ContentSectionParagraphColour = value;
        NotifyStateChanged();
    }

    public void SetContentSectionLabelColour(string value)
    {
        ContentSectionLabelColour = value;
        NotifyStateChanged();
    }

    public void SetButtonTextColour(string value)
    {
        ButtonTextColour = value;
        NotifyStateChanged();
    }
    public void SetButtonColour(string value)
    {
        ButtonColour = value;
        NotifyStateChanged();
    }
    public void SetButtonHoverColour(string value)
    {
        ButtonHoverColour = value;
        NotifyStateChanged();
    }
    public void SetCheckBoxColour(string value)
    {
        CheckBoxColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarTitleManageMiColour(string value)
    {
        SideBarTitleManageMiColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarTitleOtherColour(string value)
    {
        SideBarTitleOtherColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarBackgroundColour(string value)
    {
        SideBarBackgroundColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarSelectedBackgroundColour(string value)
    {
        SideBarSelectedBackgroundColour = value;
        NotifyStateChanged();
    }    
    public void SetSideBarTextTitleColour(string value)
    {
        SideBarTextTitleColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarButtonColour(string value)
    {
        SideBarButtonColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarButtonHoverColour(string value)
    {
        SideBarButtonHoverColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarButtonIconColour(string value)
    {
        SideBarButtonIconColour = value;
        NotifyStateChanged();
    }
    public void SetSideBarButtonTextColour(string value)
    {
        SideBarButtonTextColour = value;
        NotifyStateChanged();
    }

    public void SetBurgerBackColour(string value)
    {
        BurgerBackColour = value;
        NotifyStateChanged();
    }
    public void SetBurgerHoverBackColour(string value)
    {
        BurgerHoverBackColour = value;
        NotifyStateChanged();
    }
    public void SetBurgerIconColour(string value)
    {
        BurgerIconColour = value;
        NotifyStateChanged();
    }

    public void SetTopBarBackColour(string value)
    {
        TopBarBackColour = value;
        NotifyStateChanged();
    }
    public void SetTopBarIconColour(string value)
    {
        TopBarIconColour = value;
        NotifyStateChanged();
    }
    public void SetTopBarIconHoverColour(string value)
    {
        TopBarIconHoverColour = value;
        NotifyStateChanged();
    }
    public void SetTopBarTextColour(string value)
    {
        TopBarTextColour = value;
        NotifyStateChanged();
    }
    public void SetTopBarTextHoverColour(string value)
    {
        TopBarTextHoverColour = value;
        NotifyStateChanged();
    }
    public void SetTopBarDividerColour(string value)
    {
        TopBarDividerColour = value;
        NotifyStateChanged();
    }
    public void SetTopBarShadow(bool value)
    {
        TopBarShadow = value;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnStateChange?.Invoke();
}

