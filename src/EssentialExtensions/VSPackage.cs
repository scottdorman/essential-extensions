using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace EssentialExtensions
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [Guid(PackageGuidString)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class EssentialExtensionsPackage : AsyncPackage
    {
        public const string PackageGuidString = "57D37F89-B73D-450A-AEB1-BFA20EF068A7";
    }
}
