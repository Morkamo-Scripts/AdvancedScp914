using System.ComponentModel;
using Exiled.API.Interfaces;

namespace AdvancedScp914
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}