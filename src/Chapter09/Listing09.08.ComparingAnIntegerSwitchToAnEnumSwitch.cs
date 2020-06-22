namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_08
{
    using Listing09_10;

    public class Program
    {
        public void SwitchInt()
        {
            int connectionState;
            // ...
            // initialize connectionState for example
            connectionState = 2;

            switch(connectionState)
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

        }

        public void SwitchEnum()
        {
            ConnectionState connectionState;
            // ...

            // initialize connectionState for example
            connectionState = ConnectionState.Connecting;

            switch(connectionState)
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
        }
    }
}
