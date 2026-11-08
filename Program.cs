// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Configuration.Assemblies;
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del Proyecto");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("  |-- Program.cs");
Console.WriteLine("  |-- Inventario.csproj");
Console.WriteLine("  |-- gitignore");
Console.WriteLine("  |-- README");
Console.WriteLine("  |--src/");
Console.WriteLine("     |--Models/(Proxima clase) ");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI y configuracion de repositorio en Github");
