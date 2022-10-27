using UnityEngine;

[CreateAssetMenu( fileName = "New DataContainer", menuName = "Data Container" )]
public class DataContainer: ScriptableObject{
    [SerializeField]
    private string key;
    public string Key { 
        get => key; 
    } // end movieData
    private string movieData;
    public string MovieData { 
        get => movieData; 
        set => movieData = value; 
    } // end movieData
}