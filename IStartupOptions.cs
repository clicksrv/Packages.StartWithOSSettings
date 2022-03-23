﻿namespace Clicksrv.StartWithOSSettings
{
    [Obsolete("Use package 'Clicksrv.Packages.StartWithOSSettings' instead, current package will no longer be updated.")]
    public interface IStartupOptions
    {
        bool IsPlatformSupported { get; }
        void CheckPlatform();

        string Name { get; init; }
        string Address { get; init; }
        string[] Arguments { get; init; }
        bool Global { get; init; }

        bool Created { get; }
        void CreateStartupEntry();
        string? GetStartupEntryValue();
        void DeleteStartupEntry();

        bool Enabled { get; }
        void Enable();
        void Disable();
        string[] GetSavedArguments();
        string? GetSavedAddress();
    }
}