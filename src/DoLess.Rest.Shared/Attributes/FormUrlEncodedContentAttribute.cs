﻿using System;

namespace DoLess.Rest
{
    /// <summary>
    /// Identifies a parameter as a form url encoded content ot the request.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class FormUrlEncodedContentAttribute : Attribute
    {
    }
}
