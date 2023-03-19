using TerrariaApi.Server;

namespace PluginTemplate
{
    [ApiVersion(2, 1)]
    public partial class Plugin : TerrariaPlugin
    {
        public override void Initialize()
        {
            // Initialize here
            // Hooks
            // ServerApi.Hooks
            // OTAPI.Hooks
            // On.Terraria Monomod hooks
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose here
            }
            base.Dispose(disposing);
        }
    }
}