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
        private string description;
        private int stackId;
        private int complexityId;
        private int platformId;
        private int styleId;
        private int industryId;

        public int Id { get { return id; } set {  id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int StackId { get {  return stackId; } set {  stackId = value; } }
        public int ComplexityId { get { return complexityId; } set {  complexityId = value; } }
        public int PlatformId { get { return platformId; } set {  platformId = value; } }
        public int StyleId { get { return styleId; } set {  styleId = value; } }
        public int IndustryId { get { return industryId; } set { industryId = value; } }

        public Project() { }

        public Project(int id, string name, string description, int stackId, int complexityId, int platformId, int styleId, int industryId)
        {
            Id = id;
            Name = name;
            Description = description;
            StackId = stackId;
            ComplexityId = complexityId;
            PlatformId = platformId;
            StyleId = styleId;
            IndustryId = industryId;
        }
    }
}
