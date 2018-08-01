using System.Reflection;

#if NET452
[assembly: AssemblyTitle("xUnit.net Runner for TestDriven.NET (.NET 4.5.2)")]
#elif NETCOREAPP2_0 || NETCOREAPP2_1
[assembly: AssemblyTitle("xUnit.net Runner for TestDriven.NET (.NET Core 2.x)")]
#else
#error Unknown target platform
#endif
