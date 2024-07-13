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
                tracker_content.text = "故事發生在很久很久以前。 一隻來自遠方的鳥，叼著茄苳樹種子在高空飛翔，鳥兒拍著翅膀自由自在地盤旋。一不小心，嘴裡的種子掉落，落入草叢中。日復一日、年復一年，經過日曬雨淋，種子慢慢長出枝枒，慢慢成長茁壯成一棵高大、枝繁葉茂的大樹。而故事就發生在這棵大樹下。 ";
                break;

            case "02":
                tracker_title.text = "Seed 01 : 白猿批衣";
                tracker_content.text = "頑皮男孩阿寶與白猿爭吵著，阿寶告訴白猿村民想要砍掉大樹，而白猿卻告訴阿寶一場即將來到的大地震，誰也逃不過，地震會保護大樹不被村民砍倒。他們爭吵不休，突然間，阿寶的姑姑出現，白猿嚇的想要逃跑卻被姑姑叫住。姑姑：「白猿啊！這件衣裳送給你，請好好與阿寶當朋友吧！」";
                break;

            case "03":
                tracker_title.text = "Seed 03 : 沒有人的戲曲";
                tracker_content.text = "阿寶想出了幫助村民躲過大地震的方法。他向黃牛與蒼鷺請求協助：「你們想辦法把戲班的道具戲偶偷到樹下架好就行。」黃牛與蒼鷺答應了阿寶，向著戲班的方向跑去。過不久，他們帶著一車的道具回到了大樹下，飛奔似的在樹下搭起了舞台。 ";
                break;

            case "04":
                tracker_title.text = "Seed 04 : 地震過後";
                tracker_content.text = "村民來到大樹下準備看戲。突然之間，天搖地動，彷彿一切都要被震垮，村民們慌張得抱住大樹想要避難。漸漸的地震停了下來，大家依然在樹下害怕的顫抖著。人群中一個村民跳了起來指著遠方大叫著：「不好啦!村子裡的房子全倒啦。」 ";
                break;

            case "05":
                tracker_title.text = "Seed 05 : 樹上的紅布";
                tracker_content.text = " 時序來到兩個月後，舞台場景仍在茄苳樹下，蒼鷺在樹旁盤旋，黃牛吃著草。一條紅布圍在大樹上，村民們帶著花來到樹下，他們開心地望著樹及村子，彼此笑著說到：「大樹保護了我們逃過地震，現在誰也不想要砍倒大樹了！」 到了今天，那棵茄苳大樹依然屹立著。";
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
