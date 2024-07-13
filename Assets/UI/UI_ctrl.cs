using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  TMPro;
using UnityEngine.UI;

public class UI_ctrl : MonoBehaviour
{
    public static UI_ctrl instance;

    //偵測tracker狀態
    public TextMeshProUGUI state;


    //下方拉桿內容
    public string tracker;
    public TextMeshProUGUI tracker_content;
    public TextMeshProUGUI tracker_title;


    //光線角度
    public Slider slider;
    public GameObject light;
    
    void Start() {
        state.text = "state : lost tracker";

        slider.onValueChanged.AddListener((value) =>{
            //Debug.Log(value);
            light.transform.rotation = Quaternion.Euler(20, 360f * value, 0);
        });
    }

    void Update(){
        TrackerContent();
    }

    void TrackerContent(){
        switch(tracker){
            case "01":
                tracker_title.text = "Seed 01 : 茄苳樹的由來";
                tracker_content.text = "一棵茄苳樹的種子從樹上墜落，被一隻鳥叼起飛向天空。在翅膀拍動過程中，獨自落下，最後掉入草叢中。經過日曬雨淋，長出枝枒，慢慢茁壯成一棵樹冠高大，枝繁葉茂的大樹。";
                break;

            case "02":
                tracker_title.text = "Seed 02 : 白猿批衣";
                tracker_content.text = "白猿正在與阿寶爭執該如何喬裝成人，藉此獲得劇組道具，然而雙方爭論不休，計畫遲遲未定。白猿決定離開拒絕餐與阿寶的計畫。此時，阿寶的姑姑現身拉住白猿，並替白猿披上縫好的衣服。";
                break;

            case "03":
                tracker_title.text = "[ 請掃描畫箱內的圖示 ]";
                tracker_content.text = "";
                break;

            case "04":
                tracker_title.text = "[ 請掃描畫箱內的圖示 ]";
                tracker_content.text = "";
                break;

            case "05":
                tracker_title.text = "[ 請掃描畫箱內的圖示 ]";
                tracker_content.text = "";
                break;
            
            default:
                tracker_title.text = "[ 請掃描畫箱內的圖示 ]";
                tracker_content.text = "";
                break;

        }
    }

    void Awake(){
        instance = this;
    }
}
