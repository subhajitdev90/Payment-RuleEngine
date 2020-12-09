using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class SendEmail : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "email")
            {
                return "Send Email about subscription";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
