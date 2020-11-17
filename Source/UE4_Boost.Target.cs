// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE4_BoostTarget : TargetRules
{
	public UE4_BoostTarget(TargetInfo Target):base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.AddRange( new string[] { "UE4_Boost" } );
	}

}
