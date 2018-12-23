using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace uniqueemail
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emailaddresses = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            int numberofdistinct = NumUniqueEmails(emailaddresses);
            Console.WriteLine("Number of disctint email addresses: " + numberofdistinct);
        }

        public static int NumUniqueEmails(string[] emails)
        {
            List<string> emailAddresses = new List<string>();
            foreach (string email in emails)
            {
//                Console.WriteLine("Original: " + email);
                string resolvedEmail = "";
                string[] emailComponents = email.Split('@');
                foreach (char c in emailComponents[0])
                {
                    if (c == '.')
                    {
                        continue;
                    }

                    if (c == '+')
                    {
                        break;
                    }

                    resolvedEmail += c;
                }

                resolvedEmail = resolvedEmail + "@" + emailComponents[1];
//               Console.WriteLine("final: " + resolvedEmail);
                if (!emailAddresses.Contains(resolvedEmail))
                {
                    emailAddresses.Add(resolvedEmail);
                }
            }
            return emailAddresses.Count;
        }

    }
}
