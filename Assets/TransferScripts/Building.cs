using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class Building : MonoBehaviour
{

    private List<string> classes = new List<string>();
    private Dropdown dropdown;
    private List<Dropdown.OptionData> dropdownOptions;

    
    public void Awake()
    {
        var file = Resources.Load("test") as TextAsset;
        StringBuilder fileText = new StringBuilder();
        fileText.Append(file.text);

        StringReader content = new StringReader(fileText.ToString());
        string line;
        
        while((line = content.ReadLine()) != null)
        {
            classes.Add(line);
            Debug.Log(line);
        }
        content.Close();
        dropdown = GetComponent<Dropdown>();
        dropdown.ClearOptions();
        dropdown.AddOptions(classes);
        
    }
    
}
