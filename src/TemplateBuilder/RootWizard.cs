using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;

namespace TemplateBuilder {
    public class RootWizard : WizardBase {
        /// <summary>
        /// Stores the "$safeprojectname$" for use in child projects.
        /// </summary>
        public override void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams) {
            GlobalDictionary["$saferootprojectname$"] = replacementsDictionary["$safeprojectname$"];
        }
    }
}