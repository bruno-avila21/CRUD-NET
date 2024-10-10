namespace ServiciosAPICore.Models
{
    public class AppSettings
    {
        private static IConfigurationRoot configuration;
        static AppSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Asegúrate de que estás en el directorio correcto
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
        }

        public static Dictionary<string, string> Value
        {
            get
            {
                // Obtiene la sección "AppSettings" desde el archivo appsettings.json
                var appSettingsSection = configuration.GetSection("AppSettings");

                if (appSettingsSection == null)
                {
                    throw new KeyNotFoundException("La sección 'AppSettings' no fue encontrada en el archivo appsettings.json.");
                }

                // Convierte la sección en un diccionario
                var settings = new Dictionary<string, string>();
                foreach (var setting in appSettingsSection.GetChildren())
                {
                    settings.Add(setting.Key, setting.Value);
                }

                return settings;
            }
        }
    }
}
