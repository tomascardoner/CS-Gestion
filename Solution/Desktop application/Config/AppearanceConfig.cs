using System;
using System.Drawing;

public class AppearanceConfig
{
    public bool EnableVisualStyles;
    public int MinimumSplashScreenDisplaySeconds;
    public byte MdiFormMargin;
    public bool ShowLastLoggedInUser;
    public bool UseCustomDialogForErrorMessage;
    public string ListsFontName;
    public Single ListsFontSize;
    public bool ListsFontBold;

    private Font _ListsFont;

    internal Font ListsFont
    {
        get
        {
            if (_ListsFont == null)
            {
                if (ListsFontName.Length > 0 && ListsFontSize > 0)
                {
                    try
                    {
                        _ListsFont = new Font(ListsFontName, ListsFontSize, (FontStyle)(ListsFontBold ? FontStyle.Bold : FontStyle.Regular));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            return _ListsFont;
        }
        set
        {
            _ListsFont = value;
            if (_ListsFont == null)
            {
                ListsFontName = "";
                ListsFontSize = 0;
                ListsFontBold = false;
            }
            else
            {
                ListsFontName = _ListsFont.Name;
                ListsFontSize = _ListsFont.Size;
                ListsFontBold = _ListsFont.Bold;
            }
        }
    }
}