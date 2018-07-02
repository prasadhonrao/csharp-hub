using System;

namespace Learn.CSharp.Language
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hour { get; set; }
        public WorkType WorkType { get; set; }

        public WorkPerformedEventArgs(int hour, WorkType workType)
        {
            this.Hour = hour;
            this.WorkType = workType;
        }
    }
}
