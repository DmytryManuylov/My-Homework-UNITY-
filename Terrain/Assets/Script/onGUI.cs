using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onGUI : MonoBehaviour
{
    public Texture2D icon;
    private string message;
    private bool toggleBool = true;

    private int toolbarInt = 0; // ���� ����� ������ ���  �������
    private string[] toolbarStrings = { "Item1", "Item2", "Item3" }; // ���� ����� ������ ���  �������

    private int selectionGridInt = 0;//���� ����� ����������
    private string[] selectionStrings = { "Skill 1", "Skill 2", "Skill 3", "Magic 1", "Magic 2", "Magic 3" }; //���� ����� ����������

    private float hSliderValue = 0.0f; // �������������� ������� ����� 

    private Vector2 scrollViewVector = Vector2.zero; // ���� ��������� ������
    private string innerText = "mission info and inventory or some text";// ���� ��������� ������
    private Rect windowRect = new Rect(Screen.width / 2 - 90, Screen.height / 2 - 100, 180, 175);// ���� ��������� ������

    //private Rect windowRect = new Rect(Screen.width / 2 - 90, Screen.height / 2 - 100, 180, 175);// ���� �����
    //private float sliderValue;// ��� ����������������




    //����������� ��������
    void OnGUI()
    {

        GUI.Box(new Rect(10, 10, 200, 50), "HP 9999/9999"); // ����� ����� ������
        if (GUI.Button(new Rect(10, 75, 200, 30), "Restart")) // ������ ������� ��� ���� ������� ��������� ������ 
            message = "Restarting level";
        GUI.Label(new Rect(220, 10, 100, 30), message);
        
        GUI.Box(new Rect(Screen.width - 400, Screen.height - 400, 400, 400), new GUIContent(icon));// �������� ����� ����� ������

        GUI.Box(new Rect(Screen.width - 400, Screen.height - 430, 400, 30), "Map"); // ���� �� ������ ����� ��� ���

        toggleBool = GUI.Toggle(new Rect(10, 125, 200, 50), toggleBool, "Super Chardge ON"); //������� ������ �����

        toolbarInt = GUI.Toolbar(new Rect(10, 150, 200, 50), toolbarInt, toolbarStrings);// ���� ����� ������ ���  �������

        selectionGridInt = GUI.SelectionGrid(new Rect((Screen.width / 2) - 200, Screen.height - 100, 200, 100), selectionGridInt, selectionStrings, 3); //���� �� ��� ������� � ������ ����� ���������� 

        hSliderValue = GUI.HorizontalSlider(new Rect(10, Screen.height - 50, 200, 50), hSliderValue, 0.0f, 255.0f); // �������������� ������� ����� 

        scrollViewVector = GUI.BeginScrollView(new Rect(10, 200, 200, 200), scrollViewVector, new Rect(10, 200, 200, 400)); // ���� ��������� ������
        innerText = GUI.TextArea(new Rect(10, 200, 200, 400), innerText);// ���� ��������� ������
        GUI.EndScrollView();// ���� ��������� ������

        //windowRect = GUI.Window(0, windowRect, WindowFunction, "Pause");// ���� �����
        //GUILayout.Button("Automatic Layout Button");//���� ������������ GUI
        // GUILayout.Button("I am not inside an Area");
        //GUILayout.BeginArea(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300));
        //GUILayout.Button("I am inside an Area");
        //GUILayout.EndArea();
       /*GUILayout.BeginArea(new Rect(10, 10, 200, 100));
        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();
        if (GUILayout.RepeatButton("Min"))
            sliderValue = 0.0f;
        if (GUILayout.RepeatButton("Max"))
            sliderValue = 10.0f;
        GUILayout.EndVertical();
        GUILayout.BeginVertical();
        GUILayout.Label("Some slider: ");
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 10.0f);
        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
       */

    }
    //���� ���� �����
    /*void WindowFunction(int windowID)
    {
        if (GUI.Button(new Rect(windowRect.width / 2 - 80, 30, 160, 30), "Continue"))
            print("Continue");
        if (GUI.Button(new Rect(windowRect.width / 2 - 80, 65, 160, 30), "Restart"))
            print("Restart");
        if (GUI.Button(new Rect(windowRect.width / 2 - 80, 100, 160, 30), "Settings"))
            print("Settings");
        if (GUI.Button(new Rect(windowRect.width / 2 - 80, 135, 160, 30), "Exit"))
            print("Exit");
    }
    */
    //������
    void Update()
    {

    }
    //������� � ����� �����������
    /*private float mySlider = 1.0f;
    void OnGUI()
    {
        mySlider = LabelSlider(new Rect(10, 10, 200, 20), mySlider, 5.0f, "Slider name");
    }
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText)
    {
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);
        GUI.Label(labelRect, labelText);
        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height);
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderMaxValue);
        return sliderValue;
    }
    */

}