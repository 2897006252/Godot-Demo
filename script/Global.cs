using Godot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

public partial class Global : Node
{
    public enum State
    {
        HUD,
        NUL
    }
    public static List<RoleBase> RoleTeam = new();
}
