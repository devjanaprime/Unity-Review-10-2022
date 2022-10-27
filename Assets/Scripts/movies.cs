using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class movies : MonoBehaviour{
    public DataContainer dataContainer;

    void Start(){
        Debug.Log( "Key: " + dataContainer.Key );
        GetMovies();
    }

    // Update is called once per frame
    void GetMovies() => StartCoroutine( GetData_Coroutine() );


    
    IEnumerator GetData_Coroutine(){
        string uri = "https://www.omdbapi.com/?apikey=" + dataContainer.Key + "&s=Batman";
        using( UnityWebRequest request = UnityWebRequest.Get( uri ) ){
            yield return request.SendWebRequest();
            if( request.isNetworkError || request.isHttpError ){
                Debug.Log( request.error );
            }
            else{
                Debug.Log( request.downloadHandler.text );
            }
        }
    }
}



