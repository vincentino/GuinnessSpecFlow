using System;

namespace TGP.Automation.CRM.WebPages.CustomerCredentials
{
    public enum CustomerDetails
    {
        DateOfBirth,
        EmailAddress,
        CustomerName,

    }
    public static class CustomerInformation
    {
        public static string DateOfBirth { get; } = "04 Feb 1971";
        public static string EmailAddress { get; } = "noemail@CSC.com";
        public static string Amount { get; } = "100";
        private static string _message;
        private static string _relative;
        private static string _timeAtAddress;
        private static string _normineeName;

        public static string CustomerNameLabel { get; private set; } = "SIMON DAWSON";
        public static string EligibilityAdviced
        {
            get
            {
                return _message = "Please be Advised That as You Have an " +
                    "Active Possession / ASB Order or Undischarged " +
                    " Debt, You May Not be Eligible";
            }

        }

        public static string Relative
        {
            get { return _relative = "Friend"; }
        }

        public static string TimeAtTheAddress
        {
            get { return _timeAtAddress = "5"; }
        }

        public static string CustomerNorminee
        {
            get { return _normineeName = "Sarah Williams"; }

        }

        public static string CommentInput
        {
            get
            {
                var userComment = "Automation testing";
                return userComment;
            }
        }

        public static string Date { get; private set; } = "10";

        public static bool CustomerInformationSummary(string email, string dob)
        {
            if (CustomerDetails.DateOfBirth.Equals(dob) 
                && CustomerDetails.EmailAddress.Equals(email))
            {
                return true;
            }
            return false;
        }

       

    }
}

