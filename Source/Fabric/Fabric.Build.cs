//
//  Created by Derek van Vliet on 2014-12-10.
//  Copyright (c) 2015 Get Set Games Inc. All rights reserved.
//

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class Fabric : ModuleRules
	{
		private string ModulePath
		{
			get { return Path.GetDirectoryName( RulesCompiler.GetModuleFilename( this.GetType().Name ) ); }
		}
		
		public Fabric(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					"Developer/Fabric/Private",
					// ... add other private include paths required here ...
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine"
					// ... add other public dependencies that you statically link with here ...
				}
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
				
			PrivateIncludePathModuleNames.AddRange(
				new string[]
				{
					"Settings"
				}
				);
			
			if (Target.Platform == UnrealTargetPlatform.IOS) {
				PublicAdditionalFrameworks.Add(
					new UEBuildFramework(
						"Fabric",
						"../../lib/iOS/Fabric.embeddedframework.zip"
					)
				);
				PublicAdditionalFrameworks.Add(
					new UEBuildFramework(
						"Crashlytics",
						"../../lib/iOS/Crashlytics.embeddedframework.zip"
					)
				);					
				PublicAdditionalFrameworks.Add(
					new UEBuildFramework(
						"MoPub",
						"../../lib/iOS/MoPub.embeddedframework.zip"
					)
				);	
				
				PublicFrameworks.AddRange( 
					new string[] 
					{
						"Security",
						"AdSupport",
						"CoreGraphics",
						"CoreLocation",
						"CoreTelephony",
						"EventKit",
						"EventKitUI",
						"Foundation",
						"MediaPlayer",
						"QuartzCore",
						"StoreKit",
						"SystemConfiguration",
						"UIKit",
						"AudioToolbox",
						"AVFoundation",
						"iAd",
						"MessageUI",
						"MobileCoreServices",
						"PassKit",
						"Social",
					}
				);
												
			}
		}
	}
}
