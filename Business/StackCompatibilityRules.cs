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

        private static bool IsLanguageCompatibleWithAppTypeAndFrontend(string language, string appType, string frontend)
        {
            if (language == "C#")
            {
                if (appType == "Desktop")
                {
                    return frontend == "Windows Forms";
                }
                else if (appType == "Web")
                {
                    return frontend == "Blazor" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
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
                    return frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
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
                    return frontend == "CSS";
                }
                else if (appType == "Console")
                {
                    return frontend == "Console";
                }
            }

            if (language == "HTML")
            {
                if (appType == "Desktop")
                {
                    return false;
                }
                else if (appType == "Web")
                {
                    return frontend == "CSS" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS";
                }
                else if (appType == "Console")
                {
                    return false;
                }
            }

            return false;
        }

        private static bool IsLanguageCompatibleWithBackendAndDatabase(string language, string appType, string frontend)
        {
            if (language == "C#")
            {
                if (appType == "Desktop")
                {
                    return frontend == "Windows Forms";
                }
                else if (appType == "Web")
                {
                    return frontend == "Blazor" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
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
                    return frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS" || frontend == "CSS";
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
                    return frontend == "CSS";
                }
                else if (appType == "Console")
                {
                    return frontend == "Console";
                }
            }

            if (language == "HTML")
            {
                if (appType == "Desktop")
                {
                    return false;
                }
                else if (appType == "Web")
                {
                    return frontend == "CSS" || frontend == "Angular" || frontend == "React" || frontend == "Tailwind" || frontend == "SASS";
                }
                else if (appType == "Console")
                {
                    return false;
                }
            }

            return false;
        }
    }
}
