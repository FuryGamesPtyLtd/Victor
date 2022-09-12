

using UnrealBuildTool;

public class Hobart : ModuleRules
{
    public Hobart(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bEnforceIWYU = true;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "Wakefield" });
        
        PrivateDependencyModuleNames.AddRange(new string[] { "GoogleProtocolBuffers" });
    }
}
