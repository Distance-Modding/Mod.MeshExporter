using Centrifuge.Distance.Game;
using Centrifuge.Distance.GUI.Controls;
using Centrifuge.Distance.GUI.Data;
using Events.MainMenu;
using Events.QuitLevelEditor;
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
using Reactor.API.Logging;
using Reactor.API.Runtime.Patching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Reactor.API.Storage;

namespace Mod.MeshExporter
{
    [ModEntryPoint("com.github.PredatoryBalloon/Distance.MeshExporter")]
    public class Mod : MonoBehaviour
    {
        public static Mod Instance;

        public IManager Manager { get; set; }

        public static Log Logger { get; private set; }

        public static ConfigurationLogic Config { get; private set; }

        public static bool ModEnabled { get; set; }

        public static FileSystem FileSystem_ { get; set; }


        public void Initialize(IManager manager)
        {
            Instance = this;
            Logger = LogManager.GetForCurrentAssembly();
            Manager = manager;
            Config = gameObject.AddComponent<ConfigurationLogic>();
            FileSystem_ = new FileSystem();
            //Events.MainMenu.Initialized.Subscribe(OnMainMenuInitialized);
            //Events.QuitLevelEditor.Quit.Subscribe(OnMainMenuInitialized2);
            //Events.MainMenu.Initialized.Unsubscribe(OnMainMenuInitialized);
            //Events.MainMenu.Initialized.Broadcast(new Initialized.Data());
            CreateSettingsMenu();
            //GameObject lamp = new GameObject();
            //Type lamptrans = System.Type.GetType("Transform");
            //lamp.AddComponent(lamptrans);
            RuntimePatcher.AutoPatch();
        }

        public void CreateSettingsMenu()
	    {
            
        }

        private void OnMainMenuInitialized(Initialized.Data data)
        {
            Resource.CreateLevelEditorPrefabDirInfo();
        }

        private void OnMainMenuInitialized2(Quit.Data data)
        {
            Resource.CreateResourceList();
        }
    }
}