﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// States to determine the shares included with <see cref="FileServiceClient.GetSharesAsync"/>.
    /// operation.
    /// </summary>
    [Flags]
    public enum ShareStates
    {
        /// <summary>
        /// Default value specifying that no flags are set in <see cref="ShareStates"/>.
        /// </summary>
        None = 0,

        /// <summary>
        /// Flag specifying that the share's snapshots should be included.
        /// Snapshots are listed from oldest to newest.
        /// </summary>
        Snapshots = 1,

        /// <summary>
        /// Flag specifying that shares of all states should be included.
        /// </summary>
        All = ~None
    }
}
