using STH.BiometricServices.Domain;

namespace STH.BiometricServices.Interface
{
    public interface IIdentifyBiometricIdentityRecord
    {
        BirIdentificationResult IdentifyBiometricIdentityRecord(BirTemplateModel model);
    }
}