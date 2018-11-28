using STH.BiometricServices.Domain;

namespace STH.BiometricServices.Interface
{
    public interface IEnrollBiometricIdentityRecord
    {
        BirEnrollmentResult EnrollBiometricIdentityRecord(BirTemplateModel model);
    }
}