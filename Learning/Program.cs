using Learning.Lessons.System.Text.Json.L1;
using Learning.Lessons.System.Text.Json.L2;
using Learning.Lessons.System.Text.Json.L3;
using System.Timers;
using Timer = System.Timers.Timer;

var timer = new Timer();
timer.Start();
timer.Elapsed += timerHandler;
timer.AutoReset = true;
timer.Enabled = true;
//Lesson 1
L1Main.Execute();

//Lesson 2
L2Main.Execute();

//Lesson 3
L3Main.Execute();
timer.Stop();
timer.Dispose();

void timerHandler(object? sender, ElapsedEventArgs e)
{
    Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
}