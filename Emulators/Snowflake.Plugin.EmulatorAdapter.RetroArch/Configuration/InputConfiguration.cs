using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;
using Snowflake.Plugin.EmulatorAdapter.RetroArch.Selections.InputConfiguration;

//autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.EmulatorAdapter.RetroArch.Configuration
{
    public class InputConfiguration : ConfigurationSection
    {
        [ConfigurationOption("auto_remaps_enable", DisplayName = "Auto Remaps Enable", Private = true)]
        public bool AutoRemapsEnable { get; set; } = false;
        //This is private because of Snowflake input API.
        [ConfigurationOption("input_autodetect_enable", DisplayName = "Enable RetroArch Input Profile Auto Detection", Private = true)]
        public bool InputAutodetectEnable { get; set; } = false;
        [ConfigurationOption("input_axis_threshold", DisplayName = "Input Axis Threshold")]
        public double InputAxisThreshold { get; set; } = 0.500000;
        [ConfigurationOption("input_descriptor_hide_unbound", DisplayName = "Input Descriptor Hide Unbound", Private = true)]
        public bool InputDescriptorHideUnbound { get; set; } = false;
        [ConfigurationOption("input_descriptor_label_show", DisplayName = "Input Descriptor Label Show", Private = true)]
        public bool InputDescriptorLabelShow { get; set; } = true;

        [ConfigurationOption("input_driver", DisplayName = "Input Driver", Private = true)]
        public InputDriver InputDriver { get; set; } = InputDriver.DirectInput;
        //todo check max
        [ConfigurationOption("input_duty_cycle", DisplayName = "Input Duty Cycle")]
        public int InputDutyCycle { get; set; } = 3;

        [ConfigurationOption("input_joypad_driver", DisplayName = "Input Joypad Driver", Private = true)]
        public InputJoypadDriver InputJoypadDriver { get; set; } = InputJoypadDriver.XInput;

        [ConfigurationOption("input_max_users", DisplayName = "Input Max Users", Private = true)]
        public int InputMaxUsers { get; set; } = 4;

        [ConfigurationOption("input_menu_toggle_gamepad_combo", DisplayName = "Input Menu Toggle Gamepad Combo", Private = true)]
        public int InputMenuToggleGamepadCombo { get; set; } = 0;

        #region InputOverlay
        // The input overlay is useless on desktops.
        [ConfigurationOption("input_osk_overlay", DisplayName = "Input Osk Overlay", Private = true)]
        public string InputOskOverlay { get; set; } = "";

        [ConfigurationOption("input_osk_overlay_enable", DisplayName = "Input Osk Overlay Enable", Private = true)]
        public bool InputOskOverlayEnable { get; set; } = false;

        [ConfigurationOption("input_overlay", DisplayName = "Input Overlay", Private = true)]
        public string InputOverlay { get; set; } = "";

        [ConfigurationOption("input_overlay_enable", DisplayName = "Input Overlay Enable", Private = true)]
        public bool InputOverlayEnable { get; set; } = false;

        [ConfigurationOption("input_overlay_enable_autopreferred", DisplayName = "Input Overlay Enable Autopreferred", Private = true)]
        public bool InputOverlayEnableAutopreferred { get; set; } = false;

        [ConfigurationOption("input_overlay_hide_in_menu", DisplayName = "Input Overlay Hide In Menu", Private = true)]
        public bool InputOverlayHideInMenu { get; set; } = true;

        [ConfigurationOption("input_overlay_opacity", DisplayName = "Input Overlay Opacity", Private = true)]
        public double InputOverlayOpacity { get; set; } = 0.700000;

        [ConfigurationOption("input_overlay_scale", DisplayName = "Input Overlay Scale", Private = true)]
        public double InputOverlayScale { get; set; } = 1.000000;
        #endregion
        
        [ConfigurationOption("input_poll_type_behavior", DisplayName = "Input Poll Type Behavior")]
        public InputPollType InputPollTypeBehavior { get; set; } = InputPollType.Normal;

        //disabled and private as core wrapper handles input
        [ConfigurationOption("input_remap_binds_enable", DisplayName = "Input Remap Binds Enable", Private = true)]
        public bool InputRemapBindsEnable { get; set; } = false;

        [ConfigurationOption("input_turbo_period", DisplayName = "Input Turbo Period")]
        public int InputTurboPeriod { get; set; } = 6;

        //It is unknown what these keyboard settings do.
        [ConfigurationOption("keyboard_gamepad_enable", DisplayName = "Keyboard Gamepad Enable", Private = true)]
        public bool KeyboardGamepadEnable { get; set; } = true;

        [ConfigurationOption("input_keyboard_layout", DisplayName = "Input Keyboard Layout", Private = true)]
        public string InputKeyboardLayout { get; set; } = "";

        //this is probably an enum but it's not exposed inside the retroarch gui.
        [ConfigurationOption("keyboard_gamepad_mapping_type", DisplayName = "Keyboard Gamepad Mapping Type", Private = true)]
        public int KeyboardGamepadMappingType { get; set; } = 1;

        public InputConfiguration() : base("input", "Input Options")
        {

        }

    }
}
