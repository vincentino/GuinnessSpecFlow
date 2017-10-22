using System;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    public class TGPLabel
    {
        public static bool CurrencySign
        {
            get
            {
                var signLabel = "Proposed Direct Debit Amount (£)";
                if (signLabel.Contains("(£)"))
                {
                    return true;
                }
                return false;   
            }           
        }

        public static bool HasAssignedToCustomerAdvisor
        {
            get
            {
                var assignedTo = "Assigned to CAT";
                return assignedTo.Contains(assignedTo);
            }           
        }

        public static bool HasMessageForCustomer
        {
            get
            {
                var messageAdvice = "Advise The Customer That We Don't Have Properties " +
                    "in Their Area of Choice. If a Residential Application " +
                    "Then Signpost to Their Local Authority.Link to Local Authority Website:" +
                    "https://www.gov.uk/find-local-council";

                if (messageAdvice != null)
                {
                    messageAdvice.Contains(messageAdvice);
                    return true;
                }
                return string.IsNullOrEmpty(messageAdvice);
            }
        }

        public static bool ExpectedImminentRiskMessage
        {
            get
            {
                var message = "If The Customer is at Imminent Risk, " +
                    "Please Advise Them to Contact The Police.";
                if (message != null)
                    message.Contains(message);
                return true;
               
            }
        }

        public static bool PageTitle
        {
            get
            {
                var title = "New My Property and Neighbourhood";
                if (title != null)
                {
                   title.Equals(title,StringComparison.CurrentCultureIgnoreCase);
                    return true;
                }
                return string.IsNullOrEmpty(title);
            }

        }

        public static bool ExpectedMessage
        {
            get
            {
                var message = "Advise the customer that a landlord request form and consent form needs to be sent in";
                if (message != null)
                {
                    message.Contains(message);
                    return true;
                }
                return string.IsNullOrEmpty(message);
            }
        }

        public static bool BusinessEmail
        {
            get
            {
                var message = "businesssupportservices@guinness.org.uk";
                if (message != null)
                {
                    message.Contains(message);
                    return true;
                }
                return string.IsNullOrEmpty(message);
            }
        }

    }
}

