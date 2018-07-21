using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalIRDemo
{
    public abstract class ASubject
    {
        public abstract void Attach(IObserver observer);
        public abstract void Detach(IObserver observer);
        public abstract void NotifyObserver();
    }
}