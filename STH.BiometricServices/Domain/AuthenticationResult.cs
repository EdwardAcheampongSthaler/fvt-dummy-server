using System.Collections.Generic;
using STH.BiometricServices.Domain.Enum;

namespace STH.BiometricServices.Domain
{
    public class AuthenticationResult
    {
        public AuthenticationResultCode AuthenticationResultCode { get; set; }
        public int FvCoreReturnCode { get; set; }
        public IEnumerable<string> SUuids { get; set; }
        public string SUuid { get; set; }
        public string ReturnMessage { get; set; }
        public int NoOfMatches { get; set; }
    }
}