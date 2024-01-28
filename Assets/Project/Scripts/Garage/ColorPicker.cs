using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Material carMaterial;

    private void Start()
    {
        carMaterial = GameObject.FindGameObjectWithTag("CarMesh").GetComponent<MeshRenderer>().material;

        redSlider.value = PlayerPrefs.GetFloat("Red");
        greenSlider.value = PlayerPrefs.GetFloat("Green");
        blueSlider.value = PlayerPrefs.GetFloat("Blue");

        carMaterial.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);

        UpdateColor();
    }

    public void UpdateColor()
    {
        float red = redSlider.value;
        float green = greenSlider.value;
        float blue = blueSlider.value;

        Color selectedColor = new Color(red, green, blue);

        carMaterial.color = selectedColor;

        PlayerPrefs.SetFloat("Red", red);
        PlayerPrefs.SetFloat("Green", green);
        PlayerPrefs.SetFloat("Blue", blue);
    }
}