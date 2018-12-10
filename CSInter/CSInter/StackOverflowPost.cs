using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    class StackOverflowPost
    {
        private int _upVotes;
        private int _downVotes;
        public int Votes
        {
            get
            {
                return _upVotes - _downVotes;
            }
        }

        public StackOverflowPost()
        {
            _upVotes = _downVotes = 0;
        }

        public void UpVote()
        {
            _upVotes++;
        }

        public void DownVote()
        {
            _downVotes++;
        }


    }
}
