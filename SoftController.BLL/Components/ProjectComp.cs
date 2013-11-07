using System;
using System.Collections.Generic;
using SoftController.BLL.Entities;
using SoftController.DAL;

namespace SoftController.BLL.Components
{
    public class ProjectComp
    {
        public List<Project> Get()
        {
            List<Project> retVal = new List<Project>();

            foreach (string projectFile in ProjectDA.Get())
            {
                Project project = new Project(projectFile);
                retVal.Add(project);
            }

            return retVal;
        }
        private void Add(Project project)
        {
            ProjectDA da = new ProjectDA(project.FileName);
            da.Add(project.Name);
        }
        private void Update(Project project)
        {
        }

        public void Save(Project project)
        {
            if (!ProjectDA.ProjectExists(project.FileName)) Add(project);
            else Update(project);
        }
    }
}
