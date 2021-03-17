// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FALL_GUYS_RESEAUTarget : TargetRules
{
	public FALL_GUYS_RESEAUTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("FALL_GUYS_RESEAU");
	}
}
