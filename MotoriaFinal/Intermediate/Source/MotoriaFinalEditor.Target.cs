using UnrealBuildTool;

public class MotoriaFinalEditorTarget : TargetRules
{
	public MotoriaFinalEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MotoriaFinal");
	}
}
