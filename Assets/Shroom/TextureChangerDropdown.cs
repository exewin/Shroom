using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureChangerDropdown : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private Texture2D[] textures;
    [SerializeField] private Texture2D[] normalMaps;
    private Dropdown dropdown;

    void OnValidate()
    {
        //material.EnableKeyword ("_NORMALMAP");


        if(!dropdown)
            dropdown = GetComponent<Dropdown>();

        if(material && textures.Length>0 && normalMaps.Length>0)
            SetTxt(0);
    }

    public void Action()
    {
        SetTxt(dropdown.value);
    }

    private void SetTxt(int index)
    {
        material.SetTexture("_BumpMap", normalMaps[index]);
        material.SetTexture("_MainTex", textures[index]);
    }

}
