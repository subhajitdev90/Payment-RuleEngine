using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine
{
    public class RuleEngOrchestrator
    {
        /// <summary>
        /// Orchestrating the input request and pass the object type to Rule classes
        /// </summary>
        /// <param name="handler"></param>
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var paymentResult in new List<string> { "physical", "book", "new", "email", "upgrade", "video", "commission" })
            { 
                var result = handler.Handle(paymentResult);

                if (result != null)
                {
                    Console.Write($"{result} \n");
                }
            }
        }

    }
}
