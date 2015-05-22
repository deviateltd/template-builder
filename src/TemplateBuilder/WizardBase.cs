using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace TemplateBuilder {
    public class WizardBase : IWizard {
        public static Dictionary<string, string> GlobalDictionary = new Dictionary<string, string>();
        public static List<Project> GlobalProjects = new List<Project>();

        public virtual void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams) {
            return;
        }

        public virtual bool ShouldAddProjectItem(string filePath) {
            return true;
        }

        public virtual void RunFinished() {
            return;
        }

        public virtual void BeforeOpeningFile(ProjectItem projectItem) {
            return;
        }

        public virtual void ProjectItemFinishedGenerating(ProjectItem projectItem) {
            return;
        }

        public virtual void ProjectFinishedGenerating(Project project) {
            return;
        }
    }
}