//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MbedProject {
	
	
	internal partial class MbedDebugger {
		
		/// <summary>Backing field for deserialized rule.<see cref='Microsoft.Build.Framework.XamlTypes.Rule'/>.</summary>
		private static Microsoft.Build.Framework.XamlTypes.Rule deserializedFallbackRule;
		
		/// <summary>The name of the schema to look for at runtime to fulfill property access.</summary>
		internal const string SchemaName = "MbedDebugger";
		
		/// <summary>The ItemType given in the Rule.DataSource property.  May not apply to every Property's individual DataSource.</summary>
		internal const string PrimaryDataSourceItemType = null;
		
		/// <summary>The Label given in the Rule.DataSource property.  May not apply to every Property's individual DataSource.</summary>
		internal const string PrimaryDataSourceLabel = "";
		
		/// <summary>The debug command to execute. (The "MbedDebuggerCommand" property).</summary>
		internal const string MbedDebuggerCommandProperty = "MbedDebuggerCommand";
		
		/// <summary>The command line arguments to pass to the application. (The "MbedDebuggerCommandArguments" property).</summary>
		internal const string MbedDebuggerCommandArgumentsProperty = "MbedDebuggerCommandArguments";
		
		/// <summary>Base directory of the solution. (The "MbedDebuggerSolutionDirectory" property).</summary>
		internal const string MbedDebuggerSolutionDirectoryProperty = "MbedDebuggerSolutionDirectory";
		
		/// <summary>Name of the Mbed output binary. (The "MbedDebuggerOutputName" property).</summary>
		internal const string MbedDebuggerOutputNameProperty = "MbedDebuggerOutputName";
		
		/// <summary>Mbed SDK Path (The "MbedSDKPath" property).</summary>
		internal const string MbedSDKPathProperty = "MbedSDKPath";
		
		/// <summary>Mbed Output Bin (The "MbedOutputBin" property).</summary>
		internal const string MbedOutputBinProperty = "MbedOutputBin";
		
		/// <summary>The application's working directory. By default, the directory containing the project file. (The "MbedDebuggerWorkingDirectory" property).</summary>
		internal const string MbedDebuggerWorkingDirectoryProperty = "MbedDebuggerWorkingDirectory";
		
		/// <summary>Specifies whether the debugger should attempt to attach to an existing process when debugging starts. (The "MbedDebuggerDebuggerAttach" property).</summary>
		internal const string MbedDebuggerDebuggerAttachProperty = "MbedDebuggerDebuggerAttach";
		
		/// <summary>Mbed Py Ocd (The "MbedPyOcdPath" property).</summary>
		internal const string MbedPyOcdPathProperty = "MbedPyOcdPath";
		
		/// <summary>Mbed Py Ocd Args (The "MbedPyOcdArgs" property).</summary>
		internal const string MbedPyOcdArgsProperty = "MbedPyOcdArgs";
		
		/// <summary>Mbed Py Ocd (The "MbedOpenOcdPath" property).</summary>
		internal const string MbedOpenOcdPathProperty = "MbedOpenOcdPath";
		
		/// <summary>Mbed Py Ocd Args (The "MbedOpenOcdArgs" property).</summary>
		internal const string MbedOpenOcdArgsProperty = "MbedOpenOcdArgs";
		
		/// <summary>Mbed Flash Tool (The "MbedFlashToolPath" property).</summary>
		internal const string MbedFlashToolPathProperty = "MbedFlashToolPath";
		
		/// <summary>Mbed Flash Tool Args (The "MbedFlashToolArgs" property).</summary>
		internal const string MbedFlashToolArgsProperty = "MbedFlashToolArgs";
		
		/// <summary>ST-Link Utility Path (The "MbedSTLinkUtilityPath" property).</summary>
		internal const string MbedSTLinkUtilityPathProperty = "MbedSTLinkUtilityPath";
		
		/// <summary>ST-Link Utility Args for connecting to a board (The "MbedSTLinkUtilityConnectArgs" property).</summary>
		internal const string MbedSTLinkUtilityConnectArgsProperty = "MbedSTLinkUtilityConnectArgs";
		
		/// <summary>ST-Link Utility Args for erasing a chip (The "MbedSTLinkUtilityEraseArgs" property).</summary>
		internal const string MbedSTLinkUtilityEraseArgsProperty = "MbedSTLinkUtilityEraseArgs";
		
		/// <summary>ST-Link Utility Args for programming a chip (The "MbedSTLinkUtilityProgramArgs" property).</summary>
		internal const string MbedSTLinkUtilityProgramArgsProperty = "MbedSTLinkUtilityProgramArgs";
		
		/// <summary>Mbed GDB Path (The "MbedGdbPath" property).</summary>
		internal const string MbedGdbPathProperty = "MbedGdbPath";
		
		/// <summary>Mbed GDB Args (The "MbedGdbArgs" property).</summary>
		internal const string MbedGdbArgsProperty = "MbedGdbArgs";
		
		/// <summary>Drive To Copy Binary To (The "MbedDriveToCopyTo" property).</summary>
		internal const string MbedDriveToCopyToProperty = "MbedDriveToCopyTo";
		
		/// <summary>Which GDB server should be used for debugging (The "MbedGdbServerOption" property).</summary>
		internal const string MbedGdbServerOptionProperty = "MbedGdbServerOption";
		
		/// <summary>Which tool should be used for deploying (The "MbedDeployTool" property).</summary>
		internal const string MbedDeployToolProperty = "MbedDeployTool";
		
		/// <summary>Backing field for the <see cref='Microsoft.Build.Framework.XamlTypes.Rule'/> property.</summary>
		private Microsoft.VisualStudio.ProjectSystem.Properties.IRule rule;
		
		/// <summary>Backing field for the file name of the rule property.</summary>
		private string file;
		
		/// <summary>Backing field for the ItemType property.</summary>
		private string itemType;
		
		/// <summary>Backing field for the ItemName property.</summary>
		private string itemName;
		
		/// <summary>Configured Project</summary>
		private Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject;
		
		/// <summary>The dictionary of named catalogs.</summary>
		private System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs;
		
		/// <summary>Backing field for the <see cref='Microsoft.VisualStudio.ProjectSystem.Properties.IRule'/> property.</summary>
		private Microsoft.VisualStudio.ProjectSystem.Properties.IRule fallbackRule;
		
		/// <summary>Thread locking object</summary>
		private object locker = new object();
		
		/// <summary>Initializes a new instance of the MbedDebugger class.</summary>
		internal MbedDebugger(Microsoft.VisualStudio.ProjectSystem.Properties.IRule rule) {
			this.rule = rule;
		}
		
		/// <summary>Initializes a new instance of the MbedDebugger class.</summary>
		internal MbedDebugger(Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject, System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs, string context, string file, string itemType, string itemName) : 
				this(GetRule(System.Collections.Immutable.ImmutableDictionary.GetValueOrDefault(catalogs, context), file, itemType, itemName)) {
			if ((configuredProject == null)) {
				throw new System.ArgumentNullException("configuredProject");
			}
			this.configuredProject = configuredProject;
			this.catalogs = catalogs;
			this.file = file;
			this.itemType = itemType;
			this.itemName = itemName;
		}
		
		/// <summary>Initializes a new instance of the MbedDebugger class.</summary>
		internal MbedDebugger(Microsoft.VisualStudio.ProjectSystem.Properties.IRule rule, Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject) : 
				this(rule) {
			if ((rule == null)) {
				throw new System.ArgumentNullException("rule");
			}
			if ((configuredProject == null)) {
				throw new System.ArgumentNullException("configuredProject");
			}
			this.configuredProject = configuredProject;
			this.rule = rule;
			this.file = this.rule.File;
			this.itemType = this.rule.ItemType;
			this.itemName = this.rule.ItemName;
		}
		
		/// <summary>Initializes a new instance of the MbedDebugger class.</summary>
		internal MbedDebugger(Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject, System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs, string context, Microsoft.VisualStudio.ProjectSystem.Properties.IProjectPropertiesContext propertyContext) : 
				this(configuredProject, catalogs, context, GetContextFile(propertyContext), propertyContext.ItemType, propertyContext.ItemName) {
		}
		
		/// <summary>Initializes a new instance of the MbedDebugger class that assumes a project context (neither property sheet nor items).</summary>
		internal MbedDebugger(Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject, System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs) : 
				this(configuredProject, catalogs, "Project", null, null, null) {
		}
		
		/// <summary>Gets the IRule used to get and set properties.</summary>
		public Microsoft.VisualStudio.ProjectSystem.Properties.IRule Rule {
			get {
				return this.rule;
			}
		}
		
		/// <summary>The debug command to execute.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDebuggerCommand {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerCommandProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerCommandProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The command line arguments to pass to the application.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDebuggerCommandArguments {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerCommandArgumentsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerCommandArgumentsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Base directory of the solution.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDebuggerSolutionDirectory {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerSolutionDirectoryProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerSolutionDirectoryProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Name of the Mbed output binary.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDebuggerOutputName {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerOutputNameProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerOutputNameProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed SDK Path</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedSDKPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSDKPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSDKPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Output Bin</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedOutputBin {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedOutputBinProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedOutputBinProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The application&apos;s working directory. By default, the directory containing the project file.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDebuggerWorkingDirectory {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerWorkingDirectoryProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerWorkingDirectoryProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Specifies whether the debugger should attempt to attach to an existing process when debugging starts.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDebuggerDebuggerAttach {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerDebuggerAttachProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDebuggerDebuggerAttachProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Py Ocd</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedPyOcdPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedPyOcdPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedPyOcdPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Py Ocd Args</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedPyOcdArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedPyOcdArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedPyOcdArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Py Ocd</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedOpenOcdPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedOpenOcdPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedOpenOcdPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Py Ocd Args</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedOpenOcdArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedOpenOcdArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedOpenOcdArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Flash Tool</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedFlashToolPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedFlashToolPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedFlashToolPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed Flash Tool Args</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedFlashToolArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedFlashToolArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedFlashToolArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>ST-Link Utility Path</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedSTLinkUtilityPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>ST-Link Utility Args for connecting to a board</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedSTLinkUtilityConnectArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityConnectArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityConnectArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>ST-Link Utility Args for erasing a chip</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedSTLinkUtilityEraseArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityEraseArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityEraseArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>ST-Link Utility Args for programming a chip</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedSTLinkUtilityProgramArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityProgramArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedSTLinkUtilityProgramArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed GDB Path</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedGdbPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedGdbPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedGdbPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Mbed GDB Args</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedGdbArgs {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedGdbArgsProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedGdbArgsProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Drive To Copy Binary To</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDriveToCopyTo {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDriveToCopyToProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDriveToCopyToProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Which GDB server should be used for debugging</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedGdbServerOption {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedGdbServerOptionProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedGdbServerOptionProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Which tool should be used for deploying</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty MbedDeployTool {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDeployToolProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(MbedDeployToolProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Get the fallback rule if the current rule on disk is missing or a property in the rule on disk is missing</summary>
		private Microsoft.VisualStudio.ProjectSystem.Properties.IRule GeneratedFallbackRule {
			get {
				if (((this.fallbackRule == null) 
							&& (this.configuredProject != null))) {
					System.Threading.Monitor.Enter(this.locker);
					try {
						if ((this.fallbackRule == null)) {
							this.InitializeFallbackRule();
						}
					}
					finally {
						System.Threading.Monitor.Exit(this.locker);
					}
				}
				return this.fallbackRule;
			}
		}
		
		private static Microsoft.VisualStudio.ProjectSystem.Properties.IRule GetRule(Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog catalog, string file, string itemType, string itemName) {
			if ((catalog == null)) {
				return null;
			}
			return catalog.BindToContext(SchemaName, file, itemType, itemName);
		}
		
		private static string GetContextFile(Microsoft.VisualStudio.ProjectSystem.Properties.IProjectPropertiesContext propertiesContext) {
			if ((propertiesContext.IsProjectFile == true)) {
				return null;
			}
			else {
				return propertiesContext.File;
			}
		}
		
		private void InitializeFallbackRule() {
			if ((this.configuredProject == null)) {
				return;
			}
			Microsoft.Build.Framework.XamlTypes.Rule unboundRule = MbedDebugger.deserializedFallbackRule;
			if ((unboundRule == null)) {
				System.IO.Stream xamlStream = null;
				System.Reflection.Assembly thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
				try {
					xamlStream = thisAssembly.GetManifestResourceStream("XamlRuleToCode:MbedDebugger.xaml");
					Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode root = ((Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode)(System.Xaml.XamlServices.Load(xamlStream)));
					System.Collections.Generic.IEnumerator<System.Object> ruleEnumerator = root.GetSchemaObjects(typeof(Microsoft.Build.Framework.XamlTypes.Rule)).GetEnumerator();
					for (
					; ((unboundRule == null) 
								&& ruleEnumerator.MoveNext()); 
					) {
						Microsoft.Build.Framework.XamlTypes.Rule t = ((Microsoft.Build.Framework.XamlTypes.Rule)(ruleEnumerator.Current));
						if (System.StringComparer.OrdinalIgnoreCase.Equals(t.Name, SchemaName)) {
							unboundRule = t;
							unboundRule.Name = "8e66979f-2b59-4e0e-8d0c-971cd4d5dd0c";
							MbedDebugger.deserializedFallbackRule = unboundRule;
						}
					}
				}
				finally {
					if ((xamlStream != null)) {
						((System.IDisposable)(xamlStream)).Dispose();
					}
				}
			}
			this.configuredProject.Services.AdditionalRuleDefinitions.AddRuleDefinition(unboundRule, "FallbackRuleCodeGenerationContext");
			Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog catalog = this.configuredProject.Services.PropertyPagesCatalog.GetMemoryOnlyCatalog("FallbackRuleCodeGenerationContext");
			this.fallbackRule = catalog.BindToContext(unboundRule.Name, this.file, this.itemType, this.itemName);
		}
		
		/// <summary>Enum values for the MbedGdbServerOption property.</summary>
		internal class MbedGdbServerOptionValues {
			
			/// <summary>The  ("pyocd") value for the MbedGdbServerOption property.</summary>
			internal const string pyocd = "pyocd";
			
			/// <summary>The  ("openocd") value for the MbedGdbServerOption property.</summary>
			internal const string openocd = "openocd";
			
			/// <summary>Prevents automatic generation of a default constructor.</summary>
			private MbedGdbServerOptionValues() {
			}
		}
		
		/// <summary>Enum values for the MbedDeployTool property.</summary>
		internal class MbedDeployToolValues {
			
			/// <summary>The  ("pyocdflashtool") value for the MbedDeployTool property.</summary>
			internal const string pyocdflashtool = "pyocdflashtool";
			
			/// <summary>The  ("stlinkutility") value for the MbedDeployTool property.</summary>
			internal const string stlinkutility = "stlinkutility";
			
			/// <summary>The  ("copytodrive") value for the MbedDeployTool property.</summary>
			internal const string copytodrive = "copytodrive";
			
			/// <summary>The  ("gdbloadcommand") value for the MbedDeployTool property.</summary>
			internal const string gdbloadcommand = "gdbloadcommand";
			
			/// <summary>The  ("nodeploy") value for the MbedDeployTool property.</summary>
			internal const string nodeploy = "nodeploy";
			
			/// <summary>Prevents automatic generation of a default constructor.</summary>
			private MbedDeployToolValues() {
			}
		}
	}
	
	internal partial class ProjectProperties {
		
		private static System.Func<System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>>, object, MbedDebugger> CreateMbedDebuggerPropertiesDelegate = new System.Func<System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>>, object, MbedDebugger>(CreateMbedDebuggerProperties);
		
		private static MbedDebugger CreateMbedDebuggerProperties(System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>> namedCatalogs, object state) {
			ProjectProperties that = ((ProjectProperties)(state));
			return new MbedDebugger(that.ConfiguredProject, namedCatalogs.Result, "Project", that.File, that.ItemType, that.ItemName);
		}
		
		/// <summary>Gets the strongly-typed property accessor used to get and set MbedDebugger Description properties.</summary>
		internal System.Threading.Tasks.Task<MbedDebugger> GetMbedDebuggerPropertiesAsync() {
			System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>> namedCatalogsTask = this.GetNamedCatalogsAsync();
			return namedCatalogsTask.ContinueWith(CreateMbedDebuggerPropertiesDelegate, this, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously, System.Threading.Tasks.TaskScheduler.Default);
		}
	}
}
