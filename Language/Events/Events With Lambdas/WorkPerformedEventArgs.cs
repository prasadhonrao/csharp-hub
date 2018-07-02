using System;

namespace Learn.CSharp.Language
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }

        public WorkPerformedEventArgs(int hours, WorkType type)
        {
            this.Hours = hours;
            this.WorkType = type;
        }
    }
}
