using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlug_v1.Models
{
    internal class Project
    {
        private int id;
        private string name;
        private int complexityId;
        private int appTypeId;
        private int styleId;
        private int industryId;
        private int languageId;
        private int frontentId;
        private int backendId;
        private int databaseId;

        public int Id { get { return id; } set {  id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int ComplexityId { get { return complexityId; } set {  complexityId = value; } }
        public int AppTypeId { get { return appTypeId; } set {  appTypeId = value; } }
        public int StyleId { get { return styleId; } set {  styleId = value; } }
        public int IndustryId { get { return industryId; } set { industryId = value; } }
        public int LanguageId { get { return languageId; } set { languageId = value; } }
        public int FrontendId { get { return frontentId; } set { frontentId = value; } }
        public int BackendId { get { return backendId; } set { backendId = value; } }
        public int DatabaseId { get { return databaseId; } set { databaseId = value; } }

        public Project() { }

        public Project(int id, string name, int complexityId, int appTypeId, int styleId, int industryId, int languageId, int frontendId, int backendId, int databaseId)
        {
            Id = id;
            Name = name;
            ComplexityId = complexityId;
            AppTypeId = appTypeId;
            StyleId = styleId;
            IndustryId = industryId;
            LanguageId = languageId;
            FrontendId = frontendId;
            BackendId = backendId;
            DatabaseId = databaseId;
        }
    }
}
