using System;
using STH.BiometricServices.Domain;

namespace STH.BiometricServices.Interface
{
    public interface IReEnrollBiometricIdentityRecord
    {
        BirReEnrollmentResult ReEnrollBiometricIdentityRecord(BirTemplateModel model, Guid uuid);
    }

}
