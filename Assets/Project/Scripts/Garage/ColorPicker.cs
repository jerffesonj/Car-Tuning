using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] private Slider redSlider;
    [SerializeField] private Slider greenSlider;
    [SerializeField] private Slider blueSlider;

    private Material carMaterial;

    private void Start()
    {
        carMaterial = GameObject.FindGameObjectWithTag("CarMesh").GetComponent<MeshRenderer>().material;

        carMaterial.color = new Color(PlayerPrefs.GetFloat("Red"), PlayerPrefs.GetFloat("Green"), PlayerPrefs.GetFloat("Blue"));

        redSlider.value = PlayerPrefs.GetFloat("Red");
        greenSlider.value = PlayerPrefs.GetFloat("Green");
        blueSlider.value = PlayerPrefs.GetFloat("Blue");

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