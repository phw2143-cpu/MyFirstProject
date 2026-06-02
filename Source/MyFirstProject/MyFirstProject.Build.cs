// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyFirstProject : ModuleRules
{
	public MyFirstProject(ReadOnlyTargetRules Target) : base(Target)
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
			"MyFirstProject",
			"MyFirstProject/Variant_Platforming",
			"MyFirstProject/Variant_Platforming/Animation",
			"MyFirstProject/Variant_Combat",
			"MyFirstProject/Variant_Combat/AI",
			"MyFirstProject/Variant_Combat/Animation",
			"MyFirstProject/Variant_Combat/Gameplay",
			"MyFirstProject/Variant_Combat/Interfaces",
			"MyFirstProject/Variant_Combat/UI",
			"MyFirstProject/Variant_SideScrolling",
			"MyFirstProject/Variant_SideScrolling/AI",
			"MyFirstProject/Variant_SideScrolling/Gameplay",
			"MyFirstProject/Variant_SideScrolling/Interfaces",
			"MyFirstProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
