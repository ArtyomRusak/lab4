using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Questionnaire.WebFormsUI.Startup))]
namespace Questionnaire.WebFormsUI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
