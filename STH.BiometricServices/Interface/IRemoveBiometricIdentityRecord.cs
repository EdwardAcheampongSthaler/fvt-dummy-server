using System;
using STH.BiometricServices.Domain;

namespace STH.BiometricServices.Interface
{
    public interface IRemoveBiometricIdentityRecord
    {
        BirRemovalResult RemoveBiometricIdentityRecord(Guid uuid);
    }
}