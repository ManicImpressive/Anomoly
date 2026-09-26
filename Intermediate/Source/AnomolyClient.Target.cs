using UnrealBuildTool;

public class AnomolyClientTarget : TargetRules
{
	public AnomolyClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Anomoly");
	}
}
