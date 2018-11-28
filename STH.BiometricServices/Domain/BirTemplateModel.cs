using System;
using STH.BiometricServices.Domain.Enum;

namespace STH.BiometricServices.Domain
{
    public class BirTemplateModel
    {
        public Guid UUID { get; set; }
        public string Template { get; set; }
        public DateTime CaptureDateTime { get; set; }
        public Hand Hand { get; set; }
        public Finger Finger { get; set; }
        public TemplateVersion Version { get; set; }

    }
}