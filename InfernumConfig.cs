using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Infernum
{
    [Label("Audio Config")]
    public class InfernumConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public class DiscordSFXData
        {
            [Header("With the option below enabled, the mod will play random Discord sound effects and themes at random times during gameplay. You can customise which sound effects, as well as their frequency and volume.")]

            [Label("Discord Sound Effect Toggle")]
            [Tooltip("Turns on and off Discord sound effects")]
            [DefaultValue(false)]
            public bool ToggleDiscordSFX
            {
                get => DiscordPingToggle != false || DiscordCallToggle != false || DiscordRareCallToggle != false;
                set
                {
                    if (value)
                    {
                        DiscordPingToggle = true;
                        DiscordCallToggle = true;
                        DiscordRareCallToggle = true;
                    }
                    else
                    {
                        DiscordPingToggle = false;
                        DiscordCallToggle = false;
                        DiscordRareCallToggle = false;
                    }
                }
            }

            [Header("Sound Effect Toggle")]

            [Label("Discord Ping Sound Effect Toggle")]
            [Tooltip("Controls whether Discord ping sound effects play during gameplay")]
            [DefaultValue(false)]
            public bool DiscordPingToggle
            {
                get => DiscordPingFrequency != 0f || DiscordPingVolume != 0f;
                set
                {
                    if (value)
                    {
                        DiscordPingFrequency = 5f;
                        DiscordPingVolume = 100f;
                    }
                    else
                    {
                        DiscordPingFrequency = 0f;
                        DiscordPingVolume = 0f;
                    }
                }
            }

            [Label("Discord Call Theme Toggle")]
            [Tooltip("Controls whether Discord call themes play during gameplay")]
            [DefaultValue(false)]
            public bool DiscordCallToggle
            {
                get => DiscordCallFrequency != 0f || DiscordCallVolume != 0f;
                set
                {
                    if (value)
                    {
                        DiscordCallFrequency = 5f;
                        DiscordCallVolume = 100f;
                    }
                    else
                    {
                        DiscordCallFrequency = 0f;
                        DiscordCallVolume = 0f;
                    }
                }
            }

            [Label("Discord Call (Rare) Theme Toggle")]
            [Tooltip("Controls whether Discord call themes (rare variant) play during gameplay")]
            [DefaultValue(false)]
            public bool DiscordRareCallToggle
            {
                get => DiscordRareCallFrequency != 0f || DiscordRareCallVolume != 0f;
                set
                {
                    if (value)
                    {
                        DiscordRareCallFrequency = 5f;
                        DiscordRareCallVolume = 100f;
                    }
                    else
                    {
                        DiscordRareCallFrequency = 0f;
                        DiscordRareCallVolume = 0f;
                    }
                }
            }

            [Header("Sound Effect Frequency")]

            [Range(0f, 10f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Discord Ping Sound Effect Frequency")]
            [Tooltip("Controls how often Discord pings play during gameplay")]
            public float DiscordPingFrequency { get; set; }

            [Range(0f, 10f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Discord Call Sound Effect Frequency")]
            [Tooltip("Controls how often Discord calls play during gameplay")]
            public float DiscordCallFrequency { get; set; }

            [Range(0f, 10f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Discord Call (Rare) Sound Effect Frequency")]
            [Tooltip("Controls how often Discord calls (rare variant) play during gameplay")]
            public float DiscordRareCallFrequency { get; set; }

            [Header("Sound Effect Volume")]

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Discord Ping Volume")]
            [Tooltip("Controls the volume of the Discord pings played")]
            public float DiscordPingVolume { get; set; }

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Discord Call Volume")]
            [Tooltip("Controls the volume of the Discord calls played")]
            public float DiscordCallVolume { get; set; }

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Discord Call (Rare) Volume")]
            [Tooltip("Controls the volume of the Discord calls (rare variant) played")]
            public float DiscordRareCallVolume { get; set; }
        }

        /*public class DeathSFXData
        {
            [Label("Death Sound Effect Toggle")]
            [Tooltip("Turns on and off death sound effects")]
            [DefaultValue(false)]
            public bool ToggleDeathSFX
            {
                get => LaughTrackToggle != false || CYEToggle != false || SeinfeldToggle != false || TBCToggle != false;
                set
                {
                    if (value)
                    {
                        LaughTrackToggle = true;
                        CYEToggle = true;
                        SeinfeldToggle = true;
                        TBCToggle = true;
                        LaughTrackVolume = 100f;
                        CYEThemeVolume = 100f;
                        SeinfeldThemeVolume = 100f;
                        TBCThemeVolume = 100f;
                    }
                    else
                    {
                        LaughTrackToggle = false;
                        CYEToggle = false;
                        SeinfeldToggle = false;
                        TBCToggle = false;
                        LaughTrackVolume = 0f;
                        CYEThemeVolume = 0f;
                        SeinfeldThemeVolume = 0f;
                        TBCThemeVolume = 0f;
                    }
                }
            }

            [Header("Sound Effect Toggle")]

            [Label("Laugh Track Sound Effect Toggle")]
            [Tooltip("Controls whether a laugh track plays after the player dies")]
            [DefaultValue(false)]
            public bool LaughTrackToggle { get; set; }

            [Label("Curb Your Enthusiasm Theme Toggle")]
            [Tooltip("Controls whether the CYE theme plays when the player dies instantly")]
            [DefaultValue(false)]
            public bool CYEToggle { get; set; }

            [Label("Seinfeld Theme Toggle")]
            [Tooltip("Controls whether the Seinfeld theme plays when the player dies instantly")]
            [DefaultValue(false)]
            public bool SeinfeldToggle { get; set; }

            [Label("To Be Continued Theme Toggle")]
            [Tooltip("Controls whether the TBC theme plays when the player dies instantly")]
            [DefaultValue(false)]
            public bool TBCToggle { get; set; }

            [Header("Sound Effect Volume")]

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Normal Death - Laugh Track Sound Effect Volume")]
            [Tooltip("Controls the volume of the laugh tracks (first variant) played")]
            public float LaughTrackVolume { get; set; }

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Instant Death - Curb Your Enthusiasm Theme Volume")]
            [Tooltip("Controls the volume of the CYE Theme played")]
            public float CYEThemeVolume { get; set; }

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Instant Death - Seinfeld Theme Volume")]
            [Tooltip("Controls the volume of the Seinfeld Theme played")]
            public float SeinfeldThemeVolume { get; set; }

            [Range(0f, 100f)]
            [Increment(1f)]
            [DefaultValue(0f)]
            [Label("Instant Death - To Be Continued Theme Volume")]
            [Tooltip("Controls the volume of the TBC Theme played")]
            public float TBCThemeVolume { get; set; }
        }*/

        [BackgroundColor(114, 137, 218)]
        [Label("Discord Sound Effect Config")]
        public DiscordSFXData DiscordSoundData = new DiscordSFXData();

        /*[BackgroundColor(114, 137, 218)]
        [Label("Death Sound Effect Config")]
        public DeathSFXData DeathSoundData = new DeathSFXData();*/

        public override bool Autoload(ref string name)
        {
            if (ModContent.GetInstance<DiscordSFXData>().DiscordPingFrequency == 0f)
            {
                ModContent.GetInstance<DiscordSFXData>().DiscordPingVolume = 0f;
            }
            return true;
        }
    }
}