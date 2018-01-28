// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Building_Escape_GameEditorTarget : TargetRules
{
	public Building_Escape_GameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Building_Escape_Game" } );
	}
}
