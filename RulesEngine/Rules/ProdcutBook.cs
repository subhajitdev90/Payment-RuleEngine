using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class ProdcutBook : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "book")
            {
                return "Create duplicate packing slip for the royalty department";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
