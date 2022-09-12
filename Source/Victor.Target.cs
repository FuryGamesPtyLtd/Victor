
using UnrealBuildTool;

public class VictorTarget : TargetRules
{
    public VictorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.AddRange( new string[] { "Hobart" } );
    }
}
