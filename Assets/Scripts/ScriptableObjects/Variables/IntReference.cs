using System;

[Serializable]
public class IntReference
{
    public IntVariable variable;
    public int Value => variable.value;

    public static implicit operator int(IntReference reference) => reference.Value; 
}