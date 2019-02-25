//using LitJson;
//using System.Text;
//using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {//미사용 스크립트

    public MaterialListManager LoadMaterial;
    public HavePotionListManager LoadPotion;
    /*public StatusManager SaveStatus;
    public TimeManager SaveTime;
    public InfluenceManager SaveInfluProg;
    public FurnitureManager SaveFur;
    public SkillSetManager SaveSkill;
    */
    //--------스테이터스 변수
    public static bool isSaved;
    public static bool isLoaded;

    public static int HaveMoney;
    public static int HaveEva;
    public static float Diamonds;

    public static int SpawnCus;
    public static bool SaveSpawnBoss;


    public static int SaveDay;
    public static int SaveInflu;

    public static int SaveFur1Lev;
    public static int SaveFur2Lev;
    public static int SaveFur3Lev;

    public static int SaveSkill1Lev;
    public static int SaveSkill2Lev;
    public static int SaveSkill3Lev;

    public static bool SaveTuto;

    public static int SalingNumSave;

    public static float SaveSpawnTime;

    //--------보유한 재료 종류

    public static bool FirstItem1;

    public static bool FirstItem2;

    public static bool FirstItem3;

    public static bool FirstItem4;

    public static bool FirstItem5;

    public static bool FirstItem6;

    public static bool FirstItem7;

    public static bool FirstItem8;

    public static bool FirstItem9;

    public static bool FirstItem10;

    public static bool FirstItem11;

    public static bool FirstItem12;

    public static bool FirstItem13;

    public static bool FirstItem14;

    public static int[] SaveItems = new int[15] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

    public static int SaveItem1;

    public static int SaveItem2;

    public static int SaveItem3;

    public static int SaveItem4;

    public static int SaveItem5;

    public static int SaveItem6;

    public static int SaveItem7;

    public static int SaveItem8;

    public static int SaveItem9;

    public static int SaveItem10;

    public static int SaveItem11;

    public static int SaveItem12;

    public static int SaveItem13;

    public static int SaveItem14;

    public static int SaveNum;

    //--------보유한 포션 종류

    public static bool FirstPotion1;
    public static bool FirstPotion2;
    public static bool FirstPotion3;
    public static bool FirstPotion4;
    public static bool FirstPotion5;
    public static bool FirstPotion6;
    public static bool FirstPotion7;
    public static bool FirstPotion8;
    public static bool FirstPotion9;
    public static bool FirstPotion10;
    public static bool FirstPotion11;

    public static int[] SavePotions = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    public static int SavePotion1;
    public static int SavePotion2;
    public static int SavePotion3;
    public static int SavePotion4;
    public static int SavePotion5;
    public static int SavePotion6;
    public static int SavePotion7;
    public static int SavePotion8;
    public static int SavePotion9;
    public static int SavePotion10;
    public static int SavePotion11;

    public static int SavePotionNum;

    public GameObject DropMat;
    public Transform DropPos;

    //--------보유한 도감 종류

    void Awake()
    {
        if (!isSaved)
        {
            FirstStartData();
        }
    }

    void Start()
    {
        if (isSaved)
        {
            StartLoadMat();
            StartLoadPotion();
        }
    }
    //-----------------------------------------------------------------
    public void StartLoadMat()
    {
        for (int index = 0; index <= SaveNum; index++)
        {
            LoadMatList(index);
        }
    }

    public void LoadMatList(int index)
    {
        switch (SaveItems[index])
        {
                case 1:
                    LoadMaterial.HarbListUpdate();
                    break;
                case 2:
                    LoadMaterial.TomatoListUpdate();
                    break;
                case 3:
                    LoadMaterial.Item3ListUpdate();
                    break;
                case 4:
                    LoadMaterial.Item4ListUpdate();
                    break;
                case 5:
                    LoadMaterial.Item5ListUpdate();
                    break;
                case 6:
                    LoadMaterial.Item6ListUpdate();
                    break;
                case 7:
                    LoadMaterial.Item7ListUpdate();
                    break;
                case 8:
                    LoadMaterial.Item8ListUpdate();
                    break;
                case 9:
                    LoadMaterial.Item9ListUpdate();
                    break;
                case 10:
                    LoadMaterial.Item10ListUpdate();
                    break;
                case 11:
                    LoadMaterial.Item11ListUpdate();
                    break;
                case 12:
                    LoadMaterial.Item12ListUpdate();
                    break;
                case 13:
                    LoadMaterial.Item13ListUpdate();
                    break;
                case 14:
                    LoadMaterial.Item14ListUpdate();
                    break;
                case 0:
                    break;
        }
    }

    public static void SaveItemType(int typeNum)
    {
        for(int index = 0; index <= 13; index++)
        {
            if(SaveItems[index] == 0)
            {
                SaveItems[index] = typeNum;
                SaveNum += 1;
                break;
            }
        }
    }
    //-------------------------------------------------
    public void StartLoadPotion()
    {
        for (int index = 0; index <= SavePotionNum; index++)
        {
            LoadPoList(index);
        }
    }

    public void LoadPoList(int index)
    {
        switch (SavePotions[index])
        {
            case 1:
                LoadPotion.Potion1ListUpdate();
                break;
            case 2:
                LoadPotion.Potion2ListUpdate();
                break;
            case 3:
                LoadPotion.Potion3ListUpdate();
                break;
            case 4:
                LoadPotion.Potion4ListUpdate();
                break;
            case 5:
                LoadPotion.Potion5ListUpdate();
                break;
            case 6:
                LoadPotion.Potion6ListUpdate();
                break;
            case 7:
                LoadPotion.Potion7ListUpdate();
                break;
            case 8:
                LoadPotion.Potion8ListUpdate();
                break;
            case 9:
                LoadPotion.Potion9ListUpdate();
                break;
            case 10:
                LoadPotion.Potion10ListUpdate();
                break;
            case 11:
                LoadPotion.Potion11ListUpdate();
                break;
            case 0:
                break;
        }
    }

    public static void SavePotionType(int typeNum)
    {
        for (int index = 0; index <= 10; index++)
        {
            if (SavePotions[index] == 0)
            {
                SavePotions[index] = typeNum;
                SavePotionNum += 1;
                break;
            }
        }
    }

    public void FirstStartData()
    {
        StatusManager.LoadPoint = 10000;

        Instantiate(DropMat, DropPos);
        Instantiate(DropMat, DropPos);
        Instantiate(DropMat, DropPos);

        //스테이터스매니저
        HaveMoney = 0;
        HaveEva = 0;
        Diamonds = 5000;
        //마첸트매니저
        SalingNumSave = 3;
        //타임매니저
        SaveDay = 0;

        SaveInflu = 50;//밸런스매니저

        SpawnCus = 2;
        SaveSpawnBoss = false;//손님매니저
        //가구매니저
        SaveFur1Lev = 0;
        SaveFur2Lev = 0;
        SaveFur3Lev = 0;
        //스킬셋매니저
        SaveSkill1Lev = 1;
        SaveSkill2Lev = 1;
        SaveSkill3Lev = 1;

        SaveTuto = false;
       

        SaveItem1 = 0;
        SaveItem2 = 0;
        SaveItem3 = 0;
        SaveItem4 = 0;
        SaveItem5 = 0;
        SaveItem6 = 0;
        SaveItem7 = 0;
        SaveItem8 = 0;
        SaveItem9 = 0;
        SaveItem10 = 0;
        SaveItem11 = 0;
        SaveItem12 = 0;
        SaveItem13 = 0;
        SaveItem14 = 0;

        SavePotion1 = 0;
        SavePotion2 = 0;
        SavePotion3 = 0;
        SavePotion4 = 0;
        SavePotion5 = 0;
        SavePotion6 = 0;
        SavePotion7 = 0;
        SavePotion8 = 0;
        SavePotion9 = 0;
        SavePotion10 = 0;
        SavePotion11 = 0;
    }
}
