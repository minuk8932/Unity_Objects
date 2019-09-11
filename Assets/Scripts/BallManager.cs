using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject ballPrefab;
    List<Dictionary<string, object>> data;
    public GameObject pitcher;
    public GameObject batter;

    void Awake()
    {

        data = CSVReader.Read("ballTrack");

        for (var i = 0; i < data.Count; i++)
        {
            print("pos_x" + data[i]["pos_x"] + " " +
                   "pos_y" + data[i]["pos_y"] + " " +
                   "pos_z" + data[i]["pos_z"]);
        }

    }

    // when script execute
    void Start()
    {
        Debug.Log("start!");

        float x = 22.01F;
        float y = 0;
        float z = 22.05F;

        // 40.73, 0.93, 41.04252

        for (var i = 0; i < data.Count; i++){
            print("pos_x" + data[i]["pos_x"] + " " +
                   "pos_y" + data[i]["pos_y"] + " " +
                   "pos_z" + data[i]["pos_z"]);

            float pos_x = x;
            float pos_y = 0;
            float pos_z = z;

            pos_x += float.Parse((data[i]["pos_x"]).ToString());
            pos_y = float.Parse(data[i]["pos_y"].ToString());
            pos_z += float.Parse(data[i]["pos_z"].ToString());

            Vector3 new_pos = pitcher.transform.position;

            Instantiate(ballPrefab, new Vector3(pos_x, pos_y, pos_z), Quaternion.identity);
        }

             // showing, place, rotate
    }

    // every frames
    void Update()
    {
        //Debug.Log("update!");
    }
}
