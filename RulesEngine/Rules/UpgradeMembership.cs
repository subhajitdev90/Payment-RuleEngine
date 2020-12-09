using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class UpgradeMembership : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "upgrade")
            {
                return "Apply the upgrade\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
