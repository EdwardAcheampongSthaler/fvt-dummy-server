namespace STH.BiometricServices.Domain
{
    public class BiometricResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}