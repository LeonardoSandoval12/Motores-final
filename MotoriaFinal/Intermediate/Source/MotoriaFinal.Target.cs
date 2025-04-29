using UnrealBuildTool;

public class MotoriaFinalTarget : TargetRules
{
	public MotoriaFinalTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MotoriaFinal");
	}
}
