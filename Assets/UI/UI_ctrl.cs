using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  TMPro;

public class UI_ctrl : MonoBehaviour
{
    public static UI_ctrl instance;

    //偵測tracker狀態
    public TextMeshProUGUI state;


    //下方拉桿內容
    public string tracker;
    public TextMeshProUGUI tracker_content;
    public TextMeshProUGUI tracker_title;
    
    void Start() {
        state.text = "state : lost tracker";
    }

    void Update(){
        TrackerContent();
    }

    void TrackerContent(){
        switch(tracker){
            case "01":
                tracker_title.text = "Seed 01 : 椅子";
                tracker_content.text = "這是一張衣子。";
                break;

            case "02":
                tracker_title.text = "Seed 02 : 白猿批衣";
                tracker_content.text = "白猿正在與阿寶爭執該如何喬裝成人藉此獲得劇組道具，然而雙方爭論不休，白猿決定離開部餐與阿寶的計畫，此時阿寶的姑姑現身拉住白猿，姑姑替白猿披上縫好的衣服。";
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
