using UnrealBuildTool;

public class AnomolyTarget : TargetRules
{
	public AnomolyTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Anomoly");
	}
}
