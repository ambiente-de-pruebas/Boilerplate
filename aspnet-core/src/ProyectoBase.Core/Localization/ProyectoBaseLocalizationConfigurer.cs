using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProyectoBase.Localization
{
    public static class ProyectoBaseLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProyectoBaseConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProyectoBaseLocalizationConfigurer).GetAssembly(),
                        "ProyectoBase.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
