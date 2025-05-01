using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]

public class SimpleTextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;

    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        textObj.text = "Score: 0";
    }

    // Update is called once per frame
    public void UpdateWithIntData()
    {
        textObj.text = "Score: " + dataObj.value.ToString(CultureInfo.InvariantCulture);
        textObj.GetComponent<Animator>().SetTrigger("Update");
    }
    
}
