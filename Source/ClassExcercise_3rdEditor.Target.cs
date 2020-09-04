// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ClassExcercise_3rdEditorTarget : TargetRules
{
	public ClassExcercise_3rdEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ClassExcercise_3rd");
	}
}
