// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE5SampleGame001 : ModuleRules
{
	public UE5SampleGame001(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UE5SampleGame001",
			"UE5SampleGame001/Variant_Platforming",
			"UE5SampleGame001/Variant_Platforming/Animation",
			"UE5SampleGame001/Variant_Combat",
			"UE5SampleGame001/Variant_Combat/AI",
			"UE5SampleGame001/Variant_Combat/Animation",
			"UE5SampleGame001/Variant_Combat/Gameplay",
			"UE5SampleGame001/Variant_Combat/Interfaces",
			"UE5SampleGame001/Variant_Combat/UI",
			"UE5SampleGame001/Variant_SideScrolling",
			"UE5SampleGame001/Variant_SideScrolling/AI",
			"UE5SampleGame001/Variant_SideScrolling/Gameplay",
			"UE5SampleGame001/Variant_SideScrolling/Interfaces",
			"UE5SampleGame001/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
