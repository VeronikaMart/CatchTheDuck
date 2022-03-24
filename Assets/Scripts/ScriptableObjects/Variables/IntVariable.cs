using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "Scriptable Objects/Int Variable")]
public class IntVariable : ScriptableObject, IValue<int>
{
    [ContextMenuItem("Reset", "ResetValue")]
    public int value;
    public IntStates state;
    [TextArea]
    [SerializeField] private string description;

    private void Awake() 
    {
        ResetValue();
    }

    public void SetValue(int value) 
    { 
        this.value = value; 
    }

    public void ApplyChange(int amount)
    {
        value += amount;
    }

    public void ResetValue()
    {
        switch (state)
        {
            case IntStates.TEMPORAL:
                SetValue(0);
                break;
            case IntStates.CONSTANT:
                Debug.Log($"High score ={value}");
                break;
            default:
                break;
        }
    }
}