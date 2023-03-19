using Terraria;
using TerrariaApi.Server;

namespace PluginTemplate
{
    public partial class Plugin: TerrariaPlugin
    {
        public override string Name => "PluginTemplate";
        public override Version Version => new(1, 0, 0);
        public override string Author => "Dekay";
        public override string Description => "Template to create new Tshock Plugins";

        public Plugin(Main game) : base(game)
        {
        }
    }
}
