using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace TemplateBuilder {
    public class ChildWizard : WizardBase {
        /// <summary>
        /// Adds the "$saferootprojectname$" from the global directory.
        /// </summary>
        public override void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams) {
            replacementsDictionary.Add("$saferootprojectname$", GlobalDictionary["$saferootprojectname$"]);
        }

        public override void ProjectFinishedGenerating(Project project) {
            GlobalProjects.Add(project);
        }
    }
}