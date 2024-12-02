// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SpotifyEditorTarget : TargetRules
{
	public SpotifyEditorTarget(TargetInfo Target) : base(Target)
	{
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Spotify" } );
	}
}
