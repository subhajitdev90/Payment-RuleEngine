using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class Video : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "video")
            {
                return "Add a 'First Aid' video to the packing sleep";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
