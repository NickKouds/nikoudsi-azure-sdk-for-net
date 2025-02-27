// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Factory&apos;s GitHub repo information. </summary>
    public partial class FactoryGitHubConfiguration : FactoryRepoConfiguration
    {
        /// <summary> Initializes a new instance of FactoryGitHubConfiguration. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="repositoryName"/>, <paramref name="collaborationBranch"/> or <paramref name="rootFolder"/> is null. </exception>
        public FactoryGitHubConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder) : base(accountName, repositoryName, collaborationBranch, rootFolder)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (repositoryName == null)
            {
                throw new ArgumentNullException(nameof(repositoryName));
            }
            if (collaborationBranch == null)
            {
                throw new ArgumentNullException(nameof(collaborationBranch));
            }
            if (rootFolder == null)
            {
                throw new ArgumentNullException(nameof(rootFolder));
            }

            FactoryRepoConfigurationType = "FactoryGitHubConfiguration";
        }

        /// <summary> Initializes a new instance of FactoryGitHubConfiguration. </summary>
        /// <param name="factoryRepoConfigurationType"> Type of repo configuration. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="lastCommitId"> Last commit id. </param>
        /// <param name="hostName"> GitHub Enterprise host name. For example: `https://github.mydomain.com`. </param>
        /// <param name="clientId"> GitHub bring your own app client id. </param>
        /// <param name="clientSecret"> GitHub bring your own app client secret information. </param>
        internal FactoryGitHubConfiguration(string factoryRepoConfigurationType, string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId, string hostName, string clientId, GitHubClientSecret clientSecret) : base(factoryRepoConfigurationType, accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId)
        {
            HostName = hostName;
            ClientId = clientId;
            ClientSecret = clientSecret;
            FactoryRepoConfigurationType = factoryRepoConfigurationType ?? "FactoryGitHubConfiguration";
        }

        /// <summary> GitHub Enterprise host name. For example: `https://github.mydomain.com`. </summary>
        public string HostName { get; set; }
        /// <summary> GitHub bring your own app client id. </summary>
        public string ClientId { get; set; }
        /// <summary> GitHub bring your own app client secret information. </summary>
        public GitHubClientSecret ClientSecret { get; set; }
    }
}
