using System;
using STH.BiometricServices.Interface;

namespace STH.BiometricServices.Domain
{
    public class BiometricIdentityRecordService :
        IEnrollBiometricIdentityRecord,
        IReEnrollBiometricIdentityRecord,
        IVerifyBiometricIdentityRecord,
        IIdentifyBiometricIdentityRecord,
        IRemoveBiometricIdentityRecord
    {
        public BiometricIdentityRecordService()
        {

        }

        public BirEnrollmentResult EnrollBiometricIdentityRecord(BirTemplateModel model)
        {
            throw new NotImplementedException();
        }

        public BirReEnrollmentResult ReEnrollBiometricIdentityRecord(BirTemplateModel model, Guid uuid)
        {
            throw new NotImplementedException();
        }

        public BirVerificationResult VerifyBiometricIdentityRecord(BirTemplateModel model)
        {
            throw new NotImplementedException();
        }

        public BirIdentificationResult IdentifyBiometricIdentityRecord(BirTemplateModel model)
        {
            throw new NotImplementedException();
        }

        public BirRemovalResult RemoveBiometricIdentityRecord(Guid uuid)
        {
            throw new NotImplementedException();
        }
    }
}