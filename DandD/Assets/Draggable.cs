using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private GameObject draggingobject; // 드래그 중인 아이콘의 게임 오브젝트
    private RectTransform canvasRectTransform; // 캔버스의 렉트 트렌스폼

    private void UpdateDraggingobjectPos(PointerEventData pointerEventData) // 드래그 조작중인 아이콘의 위치를 갱신 및 설정하는 메소드
    {
        if(draggingobject != null) // 드래그 중일때
        {
            Vector3 ScreenPos = pointerEventData.position; // 드래그 중인 아이콘의 스크린좌표를 가져온다.

            Camera camera = pointerEventData.pressEventCamera;// 스크린 좌표를 월드 좌표로 변환

            Vector3 newPos;
            if(RectTransformUtility.ScreenPointToWorldPointInRectangle(canvasRectTransform, ScreenPos, camera, out newPos)) // 드래그 중인 아이콘의 위치를 설정
            {
                draggingobject.transform.position = newPos;
                draggingobject.transform.rotation = canvasRectTransform.rotation;
            }
        }
    }

    public void OnBeginDrag(PointerEventData pointerEventData)// 드래그 조작이 시작될때 발생하는 이벤트 메소드
    {
        if(draggingobject != null) // 만약 이전에 드래그하던 객체가 남아있을 경우 지운다
        {
            Destroy(draggingobject);
        }

        Image sourceImage = GetComponent<Image>(); // 드래그하는 본래 아이콘의 이미지 컴포넌트를 가져온다

        draggingobject = new GameObject("Dragging object"); // 드래그 중인 아이콘의 게임 오브젝트를 생성합니다

        draggingobject.transform.SetParent(sourceImage.canvas.transform); // 본래 아이콘의 켄버스의 자식요소로 종속시키고 화면 맨 앞쪽에 표시한다
        draggingobject.transform.SetAsLastSibling();
        draggingobject.transform.localScale = Vector3.one;

        // 캔버스 그룹 컴포넌트의 블록 레이캐스트 속성을 이용해서
        // 레이캐스트가 이동중에 막히지 않도록 설정
        CanvasGroup canvasGroup = draggingobject.AddComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = false;

        Image draggingImage = draggingobject.AddComponent<Image>(); // 드래그 중인 아이콘의 게임 오브젝트에 이미지 컴포넌트를 붙인다

        // 본래 아이콘과 동일한 이미지와 외양을 설정
        draggingImage.sprite = sourceImage.sprite;
        draggingImage.rectTransform.sizeDelta = sourceImage.rectTransform.sizeDelta;
        draggingImage.color = sourceImage.color;
        draggingImage.material = sourceImage.material;

        // 캔버스의 렉트 트렌스폼을 보존
        canvasRectTransform = draggingImage.canvas.transform as RectTransform;
        //드래그 중인 아이콘의 위치를 갱신
        UpdateDraggingobjectPos(pointerEventData);
    }

    public void OnDrag(PointerEventData pointerEventData) // 드래그 조작 중에 발생하는 이벤트 메소드
    {
        UpdateDraggingobjectPos(pointerEventData);
    }

    public void OnEndDrag(PointerEventData pointerEventData) // 드래그 조작이 끝났을때 발생하는 이벤트 메소드
    {
        Destroy(draggingobject);
    }
}
