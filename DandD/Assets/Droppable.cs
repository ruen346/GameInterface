using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image iconeImage; // 드롭 영역에 표시되어있는 아이콘의 이미지를 가져옵니다
    [SerializeField] private Color highlightedColor; // 드롭 영역에 표시되어있는 아이콘의 하이라이트 색을 가져옵니다
    private Color normalColor; // 드롭 영역에 표시되어있는 아이콘의 원래 색

    void Start()
    {
        normalColor = iconeImage.color; // 드롭 영역에 표시되어있는 아이콘의 원래 색을 보존
    }

    public void OnPointerEnter(PointerEventData pointerEventData) // 마우스 커서가 드롭 영역에 들어왔을때 호출
    {
        if(pointerEventData.dragging)
        {
            // 드래그 중이며 드롭영역에 마우스 커서가 들어왔을때
            // 드롭 영역에 표시된 아이콘의 색을 하이라이트 색으로 변경
            iconeImage.color = highlightedColor; 
        }
    }

    public void OnPointerExit(PointerEventData pointerEventData) // 마우스 커서가 드롭 영역을 벗어날 때 호출
    {
        if (pointerEventData.dragging)
        {
            // 드래그 중이며 드롭영역에 마우스 커서가 벗어날때
            // 드롭 영역에 표시된 아이콘의 색을 원래 색으로 변경
            iconeImage.color = normalColor;
        }
    }

    public void OnDrop(PointerEventData pointerEventData) // 드래그 하던 아이콘이 드랍됐을때 호출
    {
        Image droppedImage = pointerEventData.pointerDrag.GetComponent<Image>(); // 드래그 하고 있던 아이콘의 이미지 컴포넌트를 가져온다.

        // 드롭 영역에 표시되어 있는 아이콘의 이미지를
        // 드롭된 아이콘과 동일한 이미지로 변경하고 색을 원래 색으로 되돌린다.
        iconeImage.sprite = droppedImage.sprite;
        iconeImage.color = normalColor;
    }
}
