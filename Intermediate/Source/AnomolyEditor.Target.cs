using UnrealBuildTool;

public class AnomolyEditorTarget : TargetRules
{
	public AnomolyEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Anomoly");
	}
}
