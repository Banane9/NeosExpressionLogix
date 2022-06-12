using System;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ModuleInitializerAttribute : Attribute
    { }

    internal static class Initializer
    {
        [ModuleInitializer]
        internal static void Initialize()
        {
            Assembly.LoadFrom(@"C:\Program Files (x86)\Steam\steamapps\common\NeosVR\System.Numerics.Vectors.dll");
            Assembly.LoadFrom(@"C:\Program Files (x86)\Steam\steamapps\common\NeosVR\Tools\AdminX\Newtonsoft.Json.dll");
            Assembly.LoadFrom(@"C:\Program Files (x86)\Steam\steamapps\common\NeosVR\Neos_Data\Managed\FrooxEngine.dll");
        }
    }
}