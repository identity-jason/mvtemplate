﻿
using System;
using Microsoft.MetadirectoryServices;

namespace Mms_Metaverse
{
    /// <summary>
    /// Summary description for MVExtensionObject.
    /// </summary>
    public partial class MVExtensionObject : IMVSynchronization
    {
        /// <summary>
        /// Add any cleanup logic here
        /// </summary>
        void IMVSynchronization.Terminate()
        {
        }
    }
}
