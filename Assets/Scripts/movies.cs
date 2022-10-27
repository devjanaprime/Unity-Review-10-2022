using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movies : MonoBehaviour{
    public DataContainer dataContainer;

    void Start(){
        Debug.Log( "Key: " + dataContainer.Key );
    }

    // Update is called once per frame
    void Update(){
        
    }
}
