using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace EssentialExtensions.Web
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [Guid(PackageGuidString)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class EssentialExtensionsPackage : AsyncPackage
    {
        public const string PackageGuidString = "DDF8A340-7136-450C-AD36-6B00F6DB271A";
    }

}
