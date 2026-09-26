using UnrealBuildTool;

public class AnomolyServerTarget : TargetRules
{
	public AnomolyServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Anomoly");
	}
}
