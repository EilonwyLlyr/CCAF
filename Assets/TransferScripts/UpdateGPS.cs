using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPS : MonoBehaviour
{
    public float longitude = GeoLocationConvert.Instance.longitude;
    public float latitude = GeoLocationConvert.Instance.latitude;

    //z is longitude
    //x is latitude
    // Update is called once per frame
    private void Update()
    {
        longitude = GeoLocationConvert.Instance.longitude;
        latitude = GeoLocationConvert.Instance.latitude;
        transform.position = new Vector3(latitude,1f,longitude);
    }
}
