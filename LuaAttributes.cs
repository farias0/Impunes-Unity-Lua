using System;

/// <summary>
/// Used to document lua apis
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class LuaApi : Attribute
{
    public string luaName = string.Empty;
    public string description = string.Empty;
    public string notes = string.Empty;
    public string docUrl = string.Empty;
}

/// <summary>
/// Used to document lua functions
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class LuaApiFunction : Attribute
{
    public string name = string.Empty;
    public string description = string.Empty;
    public string returns = string.Empty;
    public string notes = string.Empty;
    public string warning = string.Empty;
    public string success = string.Empty;
    public string codeExample = string.Empty;
    public string docUrl = string.Empty;
    public bool deprecated = false;
    public string seeAlso = string.Empty;
}

/// <summary>
/// Used to document lua variables
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class LuaApiVariable : Attribute
{
    public string name = string.Empty;
    public string description = string.Empty;
    public string docUrl = string.Empty;
}

/// <summary>
/// Used for generating lua counterparts to C# enums as well as document them
/// </summary>
[AttributeUsage(AttributeTargets.Enum)]
public class LuaApiEnum : Attribute
{
    public string name = string.Empty;
    public string description = string.Empty;
}

/// <summary>
/// Used to document enum values
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class LuaApiEnumValue : Attribute
{
    public string description = string.Empty;
    public bool hidden = false;
}

/// <summary>
/// Used to document Lua function parameters
/// </summary>
[AttributeUsage(AttributeTargets.Parameter)]
public class LuaApiParam : Attribute
{
    public string description = string.Empty;
}
