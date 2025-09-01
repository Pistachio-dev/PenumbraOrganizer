using Dalamud.Plugin;
using Dalamud.Plugin.Ipc;
using Dalamud.Plugin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenumbraOrganizer.IPC
{

    public class PenumbraIPC : IDisposable
    {
        private ICallGateSubscriber<Dictionary<string, string>> BaseGetModListSubscriber { get; init; }
        private readonly IPluginLog pluginLog;

        public PenumbraIPC(IDalamudPluginInterface pluginInterface, IPluginLog pluginLog)
        {
            this.pluginLog = pluginLog;
            BaseGetModListSubscriber = pluginInterface.GetIpcSubscriber<Dictionary<string, string>>("Penumbra.GetModList");
        }

        public void GetModList()
        {
            var modList = BaseGetModListSubscriber.InvokeFunc();
            foreach (var kvp in modList)
            {
                pluginLog.Info($"{kvp.Key}: {kvp.Value}");
            }
        }

        public void Dispose()
        {
            
        }
    }
}
