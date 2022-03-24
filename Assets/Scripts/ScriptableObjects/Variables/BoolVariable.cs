using UnityEngine;

[CreateAssetMenu(fileName = "BoolVariable", menuName = "Scriptable Objects/Bool Variable")]
public class BoolVariable : ScriptableObject, IValue<bool>
{
    [ContextMenuItem("Reset", "ResetValue")]
    public bool state;
    [TextArea]
    [SerializeField] private string description;

    private void Awake() 
    {
        ResetValue(); 
    }

    public void SetValue(bool state) 
    { 
        this.state = state; 
    }

    public void ResetValue()
    {
        SetValue(false);
    }
}