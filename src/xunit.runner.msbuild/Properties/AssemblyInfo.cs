using System.Reflection;

#if NET452
[assembly: AssemblyTitle("xUnit.net MSBuild Test Runner (.NET 4.5.2)")]
#elif NETCOREAPP2_0 || NETCOREAPP2_1
[assembly: AssemblyTitle("xUnit.net MSBuild for Test Runner (.NET Core 2.x)")]
#else
#error Unknown target platform
#endif
