using STH.BiometricServices.Domain;

namespace STH.BiometricServices.Interface
{
    public interface IVerifyBiometricIdentityRecord
    {
        BirVerificationResult VerifyBiometricIdentityRecord(BirTemplateModel model);
    }
}