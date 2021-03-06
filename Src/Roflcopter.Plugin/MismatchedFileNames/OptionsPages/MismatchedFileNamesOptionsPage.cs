using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using JetBrains.Application.UI.Options;
using JetBrains.Application.UI.Options.OptionsDialog;
using JetBrains.DataFlow;
using JetBrains.ReSharper.Feature.Services.Daemon.OptionPages;
using JetBrains.ReSharper.Feature.Services.Resources;

namespace Roflcopter.Plugin.MismatchedFileNames.OptionsPages
{
    [OptionsPage(
        OptionsPageId,
        "Mismatched file names",
        typeofIcon: typeof(AlteringFeatuThemedIcons.FileHeaderText),
        ParentId = CodeInspectionPage.PID)]
    [ExcludeFromCodeCoverage /* manually tested UI code */]
    public class MismatchedFileNamesOptionsPage : SimpleOptionsPage
    {
        private const string OptionsPageId = nameof(MismatchedFileNamesOptionsPage);

        public MismatchedFileNamesOptionsPage([NotNull] Lifetime lifetime, [NotNull] OptionsSettingsSmartContext optionsSettingsSmartContext) :
            base(lifetime, optionsSettingsSmartContext)
        {
            AddStringOption((MismatchedFileNamesSettings s) => s.AllowedFileNamePostfixRegex, "Allowed file name postfix regex: ");

            FinishPage();
        }
    }
}
