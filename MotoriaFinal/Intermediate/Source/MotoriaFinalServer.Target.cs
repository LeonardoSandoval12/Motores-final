using UnrealBuildTool;

public class MotoriaFinalServerTarget : TargetRules
{
	public MotoriaFinalServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MotoriaFinal");
	}
}
