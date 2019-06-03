using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public interface IWorkFlow
    {
        void AddActivity(IActivity activity);
        IList<IActivity> GetActivities();
    }

    public class WorkFlow : IWorkFlow
    {
        private IList<IActivity> _activities;

        public WorkFlow() { 
            _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IList<IActivity> GetActivities()
        {
            return _activities;
        }
        
    }

    public interface IActivity
    {
        void Execute();
    }

    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded.");
        }
    }
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email sent.");
        }
    }
    public class ChangeStatusVideoProcessing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changed the status of the video to Processing.");
        }
    }

    public class WorkFlowEngine
    {
        private IWorkFlow _workFlow;

        public WorkFlowEngine(IWorkFlow workFlow)
        {
            _workFlow = workFlow;
        }

        public void Run()
        {
            foreach (var activity in _workFlow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
