using System;

namespace MuOnline.Infrastruture.Application.Core
{
    public class BusinessException : ArgumentException
    {
        public BusinessException(string message) : base(message) { }
    }
}