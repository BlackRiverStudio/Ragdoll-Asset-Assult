using AOT;
#region using JetBrains;
using JetBrains;
using JetBrains.Annotations;
using JetBrains.Rider;
using JetBrains.Rider.Unity;
using JetBrains.Rider.Unity.Editor;
#endregion
#region using Microsoft;
using Microsoft;
using Microsoft.Unity;
using Microsoft.Unity.VisualStudio;
using Microsoft.Unity.VisualStudio.Editor;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
#endregion
#region using Packages;
using Packages;
using Packages.Rider;
using Packages.Rider.Editor;
using Packages.Rider.Editor.UnitTesting;
#endregion
#region using System;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
#endregion
#region using TMPro;
using TMPro;
using TMPro.EditorUtilities;
using TMPro.SpriteAssetUtilities;
#endregion
using TreeEditor;
#region using Unity;
using Unity;
using Unity.Burst;
using Unity.CodeEditor;
using Unity.Collections;
using Unity.Collections.LowLevel;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IO;
using Unity.IO.LowLevel;
using Unity.IO.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using Unity.Rendering;
using Unity.Rendering.HybridV2;
#endregion
using UnityChan;
#region using UnityEditor;
using UnityEditor;
using UnityEditor.Advertisements;
using UnityEditor.AI;
using UnityEditor.Analytics;
using UnityEditor.Android;
using UnityEditor.AnimatedValues;
using UnityEditor.Animations;
using UnityEditor.AssetImporters;
using UnityEditor.Audio;
using UnityEditor.Build;
using UnityEditor.Build.Content;
using UnityEditor.Build.Player;
using UnityEditor.Build.Reporting;
using UnityEditor.Callbacks;
using UnityEditor.Compilation;
using UnityEditor.Connect;
using UnityEditor.CrashReporting;
using UnityEditor.EditorTools;
using UnityEditor.Events;
using UnityEditor.EventSystems;
using UnityEditor.Experimental;
using UnityEditor.Experimental.Build;
using UnityEditor.Experimental.Build.AssetBundle;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Experimental.Licensing;
using UnityEditor.Experimental.Rendering;
using UnityEditor.Experimental.RestService;
using UnityEditor.Experimental.SceneManagement;
using UnityEditor.Experimental.TerrainAPI;
using UnityEditor.Hardware;
using UnityEditor.Il2Cpp;
using UnityEditor.IMGUI;
using UnityEditor.IMGUI.Controls;
using UnityEditor.Localization;
using UnityEditor.Localization.Editor;
using UnityEditor.Macros;
using UnityEditor.Media;
using UnityEditor.MemoryProfiler;
using UnityEditor.MPE;
using UnityEditor.Networking;
using UnityEditor.Networking.PlayerConnection;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager.UI;
using UnityEditor.Playables;
using UnityEditor.Presets;
using UnityEditor.ProBuilder;
using UnityEditor.Profiling;
using UnityEditor.Profiling.Memory;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEditor.ProjectWindowCallback;
using UnityEditor.Purchasing;
using UnityEditor.Rendering;
using UnityEditor.SceneManagement;
using UnityEditor.SceneTemplate;
using UnityEditor.Scripting;
using UnityEditor.SearchService;
using UnityEditor.ShortcutManagement;
using UnityEditor.Sprites;
using UnityEditor.Timeline;
using UnityEditor.Timeline.Actions;
using UnityEditor.U2D;
using UnityEditor.UI;
using UnityEditor.UIElements;
using UnityEditor.UnityLinker;
using UnityEditor.VersionControl;
using UnityEditor.VisualStudioIntegration;
using UnityEditor.XR;
#endregion
#region using UnityEditorInternal;
using UnityEditorInternal;
using UnityEditorInternal.Profiling;
using UnityEditorInternal.Profiling.Memory;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEditorInternal.VersionControl;
using UnityEditorInternal.VR;
#endregion
#region using UnityEngine;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.AI;
using UnityEngine.Analytics;
using UnityEngine.Android;
using UnityEngine.Animations;
using UnityEngine.Apple;
using UnityEngine.Apple.ReplayKit;
using UnityEngine.Apple.TV;
using UnityEngine.Assertions;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Assertions.Must;
using UnityEngine.Audio;
using UnityEngine.CrashReportHandler;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Experimental;
using UnityEngine.Experimental.AI;
using UnityEngine.Experimental.Animations;
using UnityEngine.Experimental.AssetBundlePatching;
using UnityEngine.Experimental.Audio;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Playables;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.TerrainAPI;
using UnityEngine.Experimental.Video;
using UnityEngine.Internal;
using UnityEngine.iOS;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;
using UnityEngine.Lumin;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.Networking.Types;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.Playables;
using UnityEngine.PlayerLoop;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.Profiling;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Profiling.Memory;
using UnityEngine.Profiling.Memory.Experimental;
using UnityEngine.Rendering;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.SearchService;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Sprites;
using UnityEngine.Subsystems;
using UnityEngine.SubsystemsImplementation;
using UnityEngine.SubsystemsImplementation.Extensions;
using UnityEngine.TestTools;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.Tilemaps;
using UnityEngine.Timeline;
using UnityEngine.tvOS;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using UnityEngine.VFX;
using UnityEngine.Video;
using UnityEngine.Windows;
using UnityEngine.Windows.Speech;
using UnityEngine.Windows.WebCam;
using UnityEngine.WSA;
using UnityEngine.XR;
using UnityEngine.XR.Provider;
using UnityEngine.XR.WSA;
#endregion
#region using UnityEngineInternal
using UnityEngineInternal;
using UnityEngineInternal.XR;
using UnityEngineInternal.XR.WSA;
#endregion
using VSCodeEditor;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
