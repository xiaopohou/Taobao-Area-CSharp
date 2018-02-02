﻿using System;

namespace Taobao.Area.Api.Exceptions
{

    /// <summary>
    /// 领域层异常
    /// </summary>
    public class TaobaoAreaDomainException : Exception
    {
        public TaobaoAreaDomainException()
        { }

        public TaobaoAreaDomainException(string message)
            : base(message)
        { }

        public TaobaoAreaDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}