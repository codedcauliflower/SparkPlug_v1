using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug_v1.Business
{
    internal class StackCompatibilityRules
    {
        public static bool IsCompatible(string language, string frontend, string backend, string database, string appType)
        {
            // Check if the language is compatible with the selected appType
            if (!IsLanguageCompatibleWithAppType(language, appType, frontend))
            {
                return false;
            }

            // Check if the selected appType is compatible with the chosen frontend
            if (!IsAppTypeCompatibleWithFrontend(appType, frontend))
            {
                return false;
            }

            // Check if the language is compatible with the selected backend
            if (!IsLanguageCompatibleWithBackend(language, backend))
            {
                return false;
            }

            // Check if the selected backend is compatible with the chosen database
            if (!IsBackendCompatibleWithDatabase(backend, database))
            {
                return false;
            }

            // All compatibility checks passed, the stack is compatible
            return true;
        }

        private static bool IsLanguageCompatibleWithAppType(string language, string appType, string frontend)
        {
            if (language == "C#")
            {
                if (appType == "Desktop")
                {
                    return frontend == "Windows Forms";
                }
                else if (appType == "Web")
                {
                    return frontend == "Blazor" || frontend == "CSS" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
                }
                else if (appType == "Console")
                {
                    return frontend == "Console";
                }
            }

            if (language == "Java")
            {
                if (appType == "Desktop")
                {
                    return frontend == "JavaFX" || frontend == "Swing";
                }
                else if (appType == "Web")
                {
                    return frontend == "CSS" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
                }
                else if (appType == "Console")
                {
                    return frontend == "Console";
                }
            }

            if (language == "Python")
            {
                if (appType == "Desktop")
                {
                    return frontend == "PyQt";
                }
                else if (appType == "Web")
                {
                    return frontend == "CSS" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
                }
                else if (appType == "Console")
                {
                    return frontend == "Console";
                }
            }

            if (appType == "Desktop")
            {
                if( language == "C#")
                {
                    return (frontend == "Windows");
                }
                else if (language == "Java")
                {
                    return (frontend == "CSS");
                }
                else if (language == "Python")
                {
                    return (frontend == "");
                }
            }
            else if (appType == "Web")
            {
                return language == "C#" || language == "Java" || language == "Python" || language == "HTML, CSS, and JS";
            }
            else if (appType == "Console")
            {
                return language == "C#" || language == "Java" || language == "Python" || language == "HTML, CSS, and JS";
            }

            return false;
        }

        private static bool IsAppTypeCompatibleWithFrontend(string appType, string frontend)
        {
            // Define compatibility rules for appType and frontend
            // Return true if compatible, otherwise false

            // Example: If "Mobile" appType is compatible with all frontend technologies
            if (appType == "Desktop")
            {
                return true;
            }

            return false;
        }

        private static bool IsLanguageCompatibleWithBackend(string language, string backend)
        {
            // Define compatibility rules for language and backend
            // Return true if compatible, otherwise false

            // Example: If "Java" language is compatible with "SpringBoot" and "Flask" backends
            if (language == "Java")
            {
                return backend == "SpringBoot" || backend == "Flask";
            }

            // Add more compatibility rules for other languages and backends as needed

            // If no specific rules apply, return false by default
            return false;
        }

        private static bool IsBackendCompatibleWithDatabase(string backend, string database)
        {
            // Define compatibility rules for backend and database
            // Return true if compatible, otherwise false

            // Example: If "SpringBoot" backend is compatible with "MySQL" and "PostgreSQL" databases
            if (backend == "SpringBoot")
            {
                return database == "MySQL" || database == "PostgreSQL";
            }

            // Add more compatibility rules for other backends and databases as needed

            // If no specific rules apply, return false by default
            return false;
        }

    }
}
