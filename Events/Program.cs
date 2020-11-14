using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COUNT: " + Environment.ProcessorCount);

            //WorkPerformedHandler del1 = WorkPerformed1;
            //WorkPerformedHandler del2 = WorkPerformed2;

            //del1 += del2;

            //del1 += WorkPerformed1;
            //del1 = WorkPerformed2;
            //del1(10, WorkType.Golf);

            var worker = new Worker();

            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            //worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);

            worker.WorkPerformed += (s, e) => Console.WriteLine($"Hours: {e.Hours} {e.WorkType}");
            worker.WorkCompleted += (s,e) => Console.WriteLine("Work is Done.");

            worker.DoWork(4, WorkType.GoToMeetings);
        }

        //private static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is Done.");
        //}

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine($"Hours: {e.Hours} {e.WorkType}");
        //}

        //static void WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 Called");
        //}

        //static void WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 Called");
        //}
    }

    public enum WorkType
    {
        GoToMeetings, Golf, GenerateReports
    }
}
