using Dalamud.Interface.Windowing;
using System;
using System.Numerics;

namespace PenumbraOrganizer.Windows;

public class ConfigWindow : Window, IDisposable
{
    private Configuration configuration;

    public ConfigWindow(Plugin plugin) : base("Configuration")
    {
        Size = new Vector2(500, 500);

        configuration = plugin.Configuration;
    }

    public void Dispose()
    { }

    public override void Draw()
    {
    }
}
