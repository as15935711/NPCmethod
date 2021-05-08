using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 對話
    /// </summary>
    private void Dialogue()
    {
        print("對話的內容");
    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    private bool Shop()
    {
        return true;
    }
    /// <summary>
    ///道具價錢預設為100
    /// </summary>
    /// <returns>0</returns>
    private int Buy()
    {
        return 100;
    }
    /// <summary>
    /// 任務
    /// </summary>
    /// <param name="get">取得任務</param>
    /// <param name="up">任務更新</param>
    private void Task(string get, int up = 1)
    {
        print("任務編號" + get);
        print("獲得任務到佢數量預設為" + up);
    }
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <returns>否</returns>
    private bool Out()
    {
        return false;
    }




}