using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storge...");
        }
    }

    public class CallWebServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service provided by third-party video encoding services to tell them you have a video ready for encoding.");
        }
    }

    public class SendEmail : IActivity
    {
        void IActivity.Execute()
        {
            Console.WriteLine("Sending email to owner of video noifying them that video has started processing.");
        }
    }

    public class ChangeVideoStatus : IActivity
    {
        private string status;

        public ChangeVideoStatus(string status)
        {
            this.status = status;
        }

        public void Execute()
        {
            Console.WriteLine("Changing status of video record in database to \"" + status + "\".");
        }
    }
}
