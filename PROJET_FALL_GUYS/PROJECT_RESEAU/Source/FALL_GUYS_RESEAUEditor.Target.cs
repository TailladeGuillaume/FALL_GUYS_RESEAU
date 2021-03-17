// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FALL_GUYS_RESEAUEditorTarget : TargetRules
{
	public FALL_GUYS_RESEAUEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("FALL_GUYS_RESEAU");
	}
}
