

using UnrealBuildTool;

public class VictorEditorTarget : TargetRules
{
    public VictorEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.AddRange( new string[] { "Hobart" } );
    }
}
