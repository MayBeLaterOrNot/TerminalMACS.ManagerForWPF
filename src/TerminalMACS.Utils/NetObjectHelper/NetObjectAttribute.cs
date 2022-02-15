﻿using System;

namespace TerminalMACS.Utils.NetObjectHelper;

/// <summary>
///     可序列化类特性
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class NetObjectAttribute : Attribute
{
    private Type _Type;

    /// <summary>
    ///     获取或者设置 对象名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     get or set the type
    /// </summary>
    public Type Type
    {
        get => _Type;
        set
        {
            if (value != _Type)
            {
                _Type = value;
                if (value != null)
                    Name = value.Name;
                else
                    Name = string.Empty;
            }
        }
    }

    /// <summary>
    ///     获取或者设置对象版本号
    /// </summary>
    public int Version { get; set; }
}