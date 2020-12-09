using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine
{
    public abstract class AbstractHandler : IRule
    {
        private IRule _nextruleHandler;

        public IRule SetNext(IRule handler)
        {
            this._nextruleHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextruleHandler != null)
            {
                return this._nextruleHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
