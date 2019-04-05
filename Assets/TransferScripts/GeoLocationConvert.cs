using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoLocationConvert : MonoBehaviour
{
    public static GeoLocationConvert Instance { set; get; }
    // Start is called before the first frame update
    private readonly float longitudeRange = -118.164840f - (-118.174238f);
    private readonly float latitudeRange = 34.072145f - 34.061223f;
    private readonly float mapLatitudeRange = (457 - (-350));
    private readonly float mapLongitudeRange = ((-350) - 231);

    public float latitude = 166.8f;
    public float longitude = -74.2f;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }

    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("User did not enable gps");
            yield break;
        }
        Input.location.Start();
        int maxWait = 20;
        while(Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if(maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }
        if(Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;
        }
        else
        {
                latitude = ConvertLatitude(Input.location.lastData.latitude);
                longitude = ConvertLogitude(Input.location.lastData.longitude);
                yield break;
        }
    }


    private float ConvertLogitude(float x)
    {
        float y = (((x - (-118.174238f)) * mapLongitudeRange) / longitudeRange) + 231; 
        return y;
    }

    private float ConvertLatitude(float x)
    {
        float y=((x - 34.061223f)*mapLatitudeRange)/latitudeRange -350;
        return y;
    }
}
