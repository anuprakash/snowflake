using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;

//autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.EmulatorAdapter.RetroArch.Configuration
{
    /// <summary>
    /// Netplay mode will probably be handled by the core through a separate API.
    /// </summary>
    public class NetplayConfiguration : ConfigurationSection
    {
        [ConfigurationOption("netplay_client_swap_input", DisplayName = "Netplay Client Swap Input", Private = true)]
        public bool NetplayClientSwapInput { get; set; } = true;

        [ConfigurationOption("netplay_delay_frames", DisplayName = "Netplay Delay Frames", Private = true)]
        public int NetplayDelayFrames { get; set; } = 0;

        [ConfigurationOption("netplay_ip_address", DisplayName = "Netplay Ip Address", Private = true)]
        public string NetplayIpAddress { get; set; } = "";

        [ConfigurationOption("netplay_ip_port", DisplayName = "Netplay Ip Port", Private = true)]
        public int NetplayIpPort { get; set; } = 0;

        [ConfigurationOption("netplay_mode", DisplayName = "Netplay Mode", Private = true)]
        public bool NetplayMode { get; set; } = false;

        [ConfigurationOption("netplay_nickname", DisplayName = "Netplay Nickname", Private = true)]
        public string NetplayNickname { get; set; } = "";

        [ConfigurationOption("netplay_spectator_mode_enable", DisplayName = "Netplay Spectator Mode Enable")]
        public bool NetplaySpectatorModeEnable { get; set; } = false;

        public NetplayConfiguration() : base("netplay", "Netplay Options")
        {

        }

    }
}
