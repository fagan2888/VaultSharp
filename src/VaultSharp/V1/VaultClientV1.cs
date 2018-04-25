﻿using VaultSharp.V1.AuthMethods;
using VaultSharp.V1.Core;
using VaultSharp.V1.SecretEngines;
using VaultSharp.V1.SystemBackend;

namespace VaultSharp.V1
{
    internal class VaultClientV1 : IVaultClientV1
    {
        public VaultClientV1(Polymath polymath)
        { 
            SystemBackend = new SystemBackendProvider(polymath);
            AuthMethod = null;
            SecretEngine = null;
        }

        public ISecretEngine SecretEngine { get; }

        public IAuthMethod AuthMethod { get; }

        public ISystemBackend SystemBackend { get; }
    }
}
