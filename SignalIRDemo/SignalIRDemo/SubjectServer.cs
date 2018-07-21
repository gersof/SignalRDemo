using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalIRDemo
{
    public class SubjectServer: ASubject
    {
        private delegate void StatusUpdate();
        private event StatusUpdate OnStatusUpdate = null;
        private static readonly Lazy<SubjectServer> _instance = new Lazy<SubjectServer>(() => new SubjectServer());

        public static SubjectServer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public override void Attach(IObserver observer)
        {
            OnStatusUpdate += new StatusUpdate(observer.Update);   
        }

        public override void Detach(IObserver observer)
        {
            OnStatusUpdate -= new StatusUpdate(observer.Update);  
        }

        public override void NotifyObserver()
        {
            OnStatusUpdate();
        }
    }
}
