using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace EssentialExtensions.GitHub
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [Guid(PackageGuidString)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class EssentialExtensionsPackage : AsyncPackage
    {
        public const string PackageGuidString = "7C1F69E8-C878-4FEF-87B3-D979B24A6E96";
    }
}
