using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int keys = 0;
    public int gold = 0;

    public TMP_Text keyText;
    public TMP_Text goldText;

    // 열쇠 획득
    public void AddKey()
    {
        keys++;
        keyText.text = "열쇠 " + keys;
    }

    // 골드 획득
    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = "골드 " + gold;
    }
}