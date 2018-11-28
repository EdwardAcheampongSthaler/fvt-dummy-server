using System;

namespace STH.BiometricServices.Domain
{
    public class BirEnrollmentResult : BiometricResult
    {
        public Guid Uuid { get; set; } // to be stored 
    }
}