using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class Membership : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "new")
            {
                return "Activate Membership";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
