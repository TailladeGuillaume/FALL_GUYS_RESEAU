// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FALL_GUYS_RESEAU : ModuleRules
{
	public FALL_GUYS_RESEAU(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
