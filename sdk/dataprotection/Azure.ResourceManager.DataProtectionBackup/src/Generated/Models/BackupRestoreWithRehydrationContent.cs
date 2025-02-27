// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> AzureBackup Restore with Rehydration Request. </summary>
    public partial class BackupRestoreWithRehydrationContent : BackupRecoveryPointBasedRestoreContent
    {
        /// <summary> Initializes a new instance of BackupRestoreWithRehydrationContent. </summary>
        /// <param name="restoreTargetInfo">
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="RestoreTargetInfo"/>.
        /// </param>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        /// <param name="recoveryPointId"></param>
        /// <param name="rehydrationPriority"> Priority to be used for rehydration. Values High or Standard. </param>
        /// <param name="rehydrationRetentionDuration"> Retention duration in ISO 8601 format i.e P10D . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restoreTargetInfo"/> or <paramref name="recoveryPointId"/> is null. </exception>
        public BackupRestoreWithRehydrationContent(RestoreTargetInfoBase restoreTargetInfo, SourceDataStoreType sourceDataStoreType, string recoveryPointId, BackupRehydrationPriority rehydrationPriority, TimeSpan rehydrationRetentionDuration) : base(restoreTargetInfo, sourceDataStoreType, recoveryPointId)
        {
            if (restoreTargetInfo == null)
            {
                throw new ArgumentNullException(nameof(restoreTargetInfo));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }

            RehydrationPriority = rehydrationPriority;
            RehydrationRetentionDuration = rehydrationRetentionDuration;
            ObjectType = "AzureBackupRestoreWithRehydrationRequest";
        }

        /// <summary> Priority to be used for rehydration. Values High or Standard. </summary>
        public BackupRehydrationPriority RehydrationPriority { get; }
        /// <summary> Retention duration in ISO 8601 format i.e P10D . </summary>
        public TimeSpan RehydrationRetentionDuration { get; }
    }
}
