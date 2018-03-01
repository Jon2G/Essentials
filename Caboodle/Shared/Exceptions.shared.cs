﻿using System;

namespace Microsoft.Caboodle
{
    public class NotImplentedInReferenceAssemblyException : NotImplementedException
    {
        public NotImplentedInReferenceAssemblyException()
            : base("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.")
        {
        }
    }

    public class PermissionException : Exception
    {
        public PermissionException(string permission)
            : base($"API requires the {permission} permission to be set.")
        {
        }
    }
}
