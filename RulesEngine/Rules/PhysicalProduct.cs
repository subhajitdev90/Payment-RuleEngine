using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class PhysicalProduct : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "physical")
            {
                return "Create a packing slip for shipping";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
