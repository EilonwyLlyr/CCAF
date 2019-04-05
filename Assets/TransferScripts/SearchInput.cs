using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchInput : MonoBehaviour
{

    [SerializeField] private InputField input;
    //[SerializeField] public Transform drop;

    [SerializeField] private Dropdown drop;

    private List<Dropdown.OptionData> dropOptions;

    // Start is called before the first frame update
    private void Start()
    {

    }
    public void FilterDrop(string input)
    {
        //find the selected index
        int menuIndex = drop.GetComponent<Dropdown>().value;
        //find all options available within the dropdown menu
        List<Dropdown.OptionData> menuOPs = drop.GetComponent<Dropdown>().options;
        //dropOptions = drop.options;
        //get the string value of the selected index
        string dropValue = menuOPs[menuIndex].text;

     //   if(Input.GetKeyDown(KeyCode.Return))
     //   {
      //      drop.Show();
      //  }
        
        if (input.Equals(dropValue))
        {
            drop.value = 1;
        }
        //Dropdown.options[Dropdown.value].text;
       //drop.options = dropOptions.FindAll(option => option.text.IndexOf(input) >= 0);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
