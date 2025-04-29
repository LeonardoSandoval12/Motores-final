using UnrealBuildTool;

public class MotoriaFinalClientTarget : TargetRules
{
	public MotoriaFinalClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MotoriaFinal");
	}
}
