namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_13
{
    using System;
    using System.Threading.Tasks;

    class Pomodoro
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
                    await Task.Delay(1000);
                    if(token.IsCancellationRequested)
                        break;
                    DisplaySecondTicker();
                }
                if(token.IsCancellationRequested)
                    break;
            }
        }

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
    }
}
