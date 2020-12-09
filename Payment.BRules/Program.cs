using RulesEngine;
using RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Payment.BRules
{
    public class Program
    {
        static void Main(string[] args)
        {
            RuleHandler();
        }

        /// <summary>
        /// Pass the request to handler according to Payment Type
        /// </summary>
        private static void RuleHandler()
        {
            AbstractHandler abstractHandler = null;
            var email = new SendEmail();
            var compayment = new CommissionPayment();

            var ctx = new Context() { PaymentType = ReadInputRequest() };
            var handler = ctx.PaymentType;

            switch (handler)
            {
                case "PhysicalProduct":
                    abstractHandler = new PhysicalProduct();
                    abstractHandler.SetNext(compayment);
                    break;
                case "ProductBook":
                    abstractHandler = new ProdcutBook();
                    abstractHandler.SetNext(compayment);
                    break;
                case "Membership":
                    abstractHandler = new Membership();
                    abstractHandler.SetNext(email);
                    break;
                case "UpgradeMembership":
                    abstractHandler = new UpgradeMembership();
                    abstractHandler.SetNext(email);
                    break;
                case "Video":
                    abstractHandler = new Video();
                    break;
                default:
                    break;
            }

            RuleEngOrchestrator.ClientCode(abstractHandler);
            Console.WriteLine();
        }

        /// <summary>
        /// Identify Payment Type
        /// </summary>
        /// <returns></returns>
        public static string ReadInputRequest()
        {
            string paymentType = "";
            XmlDocument model = new XmlDocument();
            string directory = @"Input\PaymentInfo.xml";
            model.Load(directory);
            foreach (XmlNode node in model.DocumentElement.ChildNodes)
            {
                if (node.Name == "PaymentType")
                {
                    paymentType = node.InnerText;
                }
            }
            return paymentType;
        }
    }
}
