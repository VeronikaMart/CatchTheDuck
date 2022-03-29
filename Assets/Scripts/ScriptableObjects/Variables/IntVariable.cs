using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "Scriptable Objects/Int Variable")]
public class IntVariable : ScriptableObject, IValue<int>
{
    [ContextMenuItem("Reset", "ResetValue")]
    [SerializeField] private int intValue;
    public int IntValue 
    { 
        get => intValue; 
        set => intValue = value; 
    }
    
    [SerializeField] private IntStates state;
    [TextArea]
    [SerializeField] private string description;

    private void Awake() 
    {
        ResetValue();
    }

    public void ApplyChange(int amount)
    {
        intValue += amount;
    }

    public void ResetValue()
    {
        switch (state)
        {
            case IntStates.TEMPORAL:
                intValue = 0;
                break;
            case IntStates.CONSTANT:
                Debug.Log($"High score ={intValue}");
                break;
            default:
                break;
        }
    }
}