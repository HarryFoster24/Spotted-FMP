using UnrealBuildTool;

public class FMPTarget : TargetRules
{
	public FMPTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FMP");
	}
}
