using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public StopWatch()
        {
            _startTime = DateTime.Now;
            _endTime = DateTime.Now;
        }

        public void Stop()
        {
            _endTime = DateTime.Now;
        }

        public void Start()
        {
            if (_endTime < _startTime)
            {
                throw new InvalidOperationException("Can't start twice.");
            }
            _startTime = DateTime.Now;
        }

        public TimeSpan Duration()
        {
            var timeSpan = _endTime - _startTime;
            return timeSpan;
        }
    }
}
