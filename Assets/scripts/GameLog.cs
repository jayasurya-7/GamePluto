//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;

//public class GameLog : MonoBehaviour
//{
//    // public static GameLog instance;
//    GameObject Player, Target;
//    public static string aanProfile;
//    public static int[] startPerformace; //[start difficulty,start performace]
//    public static int[] endPerformace; // [end difficulty,end performace]
//    string _fname;
//    // dummy for testing
//    float time;
//    bool logged = false;
//    // AAN should be got from the game controller update 000 if active else data 
//    // Start is called before the first frame update


  
//    void Start()
//    {
       
//        _fname = AppData.GameRawDatafile(AppData.subjHospNum, AppData.plutoData.mechs[AppData.plutoData.mechIndex], AppData.game, AppData.regime);
//        Debug.Log(_fname);
//        AppData.StartGameDataLog(_fname);
//        AppData.gameLogFileName = _fname;




//        // 
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//        if (AppData.isGameLogging)
//        {
//            // Debug.Log(Time.timeScale +"logging");
//            Player = GameObject.FindGameObjectWithTag("Player");
//            Target = GameObject.FindGameObjectWithTag("Target");

//            if (AppData.game == "COMPENSATION")
//            {

//                AppData.PlayerPos = Player.transform.eulerAngles.z.ToString();
//                AppData.TargetPos = Target.transform.eulerAngles.z.ToString();
//            }
//            else
//            {

//                if (Player != null)
//                    AppData.PlayerPos = "\"" + Player.transform.position.x.ToString() + "," + Player.transform.position.y.ToString() + "\"";
//                else
//                    AppData.PlayerPos = "\"" + "XXX" + "," + "XXX" + "\"";
//                if (Target != null)
//                    AppData.TargetPos = "\"" + Target.transform.position.x.ToString() + "," + Target.transform.position.y.ToString() + "\"";
//                else
//                    AppData.TargetPos = "\"" + "XXX" + "," + "XXX" + "\"";

//            }
//            AppData.aanProfile = aanProfile;
//            AppData.LogGameData();

//        }
//        time += Time.deltaTime;

//        //Debug.Log(AppData.oldANN.profile[0]);
//        // if (time > 10)
//        // {
//        //     // 
//        //     if (!logged)
//        //     {
//        //         Debug.Log(_fname);
//        //         //  AppData.StopLogging();
//        //         logged = true;
//        //     }
//        // }
//    }
//}
