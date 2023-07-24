namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_29;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_30;
public class Program
{
    public static void SwitchInt()
    {
        #region INCLUDE
        int connectionState;
        #region EXCLUDE
        // initialize connectionState for example
        connectionState = 2;
        #endregion EXCLUDE
        switch (connectionState)
        {
            case 0:
                // ...
                break;
            case 1:
                // ...
                break;
            case 2:
                // ...
                break;
            case 3:
                // ...
                break;
        }
        #region EXCLUDE
    }

    public static void SwitchEnum()
    {
        #endregion EXCLUDE
        ConnectionState connectionState;
        #region EXCLUDE
        // initialize connectionState for example
        connectionState = ConnectionState.Connecting;
        #endregion EXCLUDE
        switch (connectionState)
        {
            case ConnectionState.Connected:
                // ...
                break;
            case ConnectionState.Connecting:
                // ...
                break;
            case ConnectionState.Disconnected:
                // ...
                break;
            case ConnectionState.Disconnecting:
                // ...
                break;
        }
        #endregion INCLUDE
    }
}
