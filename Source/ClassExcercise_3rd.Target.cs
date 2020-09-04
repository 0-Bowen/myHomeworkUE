// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ClassExcercise_3rdTarget : TargetRules
{
	public ClassExcercise_3rdTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ClassExcercise_3rd");
	}
}
