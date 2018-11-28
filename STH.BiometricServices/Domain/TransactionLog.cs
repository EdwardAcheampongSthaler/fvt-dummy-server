using STH.BiometricServices.Domain.Enum;

namespace STH.BiometricServices.Domain
{
    public class TransactionLog
    {
        public string TimeStamp { get; set; }
        public string UUID { get; set; }
        public string Message { get; set; }
        public OperationType OperationType { get; set; }
        public OperationalStatus OperationStatus { get; set; }
    }
}