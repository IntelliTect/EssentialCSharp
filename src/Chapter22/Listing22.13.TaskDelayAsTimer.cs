namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_13;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Pomodoro
{
    // ...

    private static async Task TickAsync(
        System.Threading.CancellationToken token)
    {
        for(int minute = 0; minute < 25; minute++)
        {
            DisplayMinuteTicker(minute);
            for(int second = 0; second < 60; second++)
            {
                await Task.Delay(1000, token);
                if(token.IsCancellationRequested)
                    break;
                DisplaySecondTicker();
            }
            if(token.IsCancellationRequested)
                break;
        }
    }
    #region EXCLUDE
    private static void DisplaySecondTicker()
    {
        // ...
        throw new NotImplementedException();
    }

    private static void DisplayMinuteTicker(int minute)
    {
        // ...
        throw new NotImplementedException();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
