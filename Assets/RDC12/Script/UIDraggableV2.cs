using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

namespace RDC
{
    public class UIDraggableV2 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        private Vector3 deltaMouseAndTransform;
        private Vector3 startPosition;
        private bool bDragEnabled = true;

        public float restoreMovementSpeed = 0.4f;
        public bool allowMultipleDrags = false;
        public GameObject[] objectiveList;

        private void Start()
        {
            objectiveList = GameObject.FindGameObjectsWithTag("contenedor");
        }

        // al comenzar el drag setea la posicion inicial del objeto, la cual es en donde fue agarrado
        public void OnBeginDrag(PointerEventData eventData)
        {
            if (bDragEnabled)
            {
                deltaMouseAndTransform = Input.mousePosition - transform.position;
                startPosition = transform.position;

                //OnBeginDrag();
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (bDragEnabled)
            {
                transform.position = Input.mousePosition - deltaMouseAndTransform;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (bDragEnabled)
            {

                GameObject objectiveTargetted = null;

                bDragEnabled = false;

                for (int i = 0; i < objectiveList.Length; i++)
                {
                    if (UIUtility.Singleton.Contains(objectiveList[i].transform, UIUtility.Singleton.GetCorrectedMousePosition()))
                    {
                        
                        objectiveTargetted = objectiveList[i];
                        break;
                    }
                }

                if (objectiveTargetted != null)
                {
                    this.transform.position = objectiveTargetted.transform.position;
                    //Contenedor donde se pone la imagen.
                    ContenedorMarcador tmp_cont = objectiveTargetted.GetComponent<ContenedorMarcador>();
                    ChangeImage(tmp_cont);

                    OnDragEndCallback(gameObject, objectiveTargetted);

                    if (allowMultipleDrags)
                    {

                        bDragEnabled = true;
                    }
                }
                else
                {
                    RestorePosition();
                }
            }
        }

        private void ChangeImage(ContenedorMarcador cm) {
            // es el componente del actual objeto dragado
            MarcadorImagen tmp_imagen = GetComponent<MarcadorImagen>();
            cm.SwitchMarcador(tmp_imagen);
        }

        protected void RestorePosition()
        {

            Animations.UIAnimation.Singleton.StartAnimation(
                new Animations.UIAnimation.LinearMovement(
                    this.gameObject, 
                    restoreMovementSpeed,
                    delegate 
                    {
                        bDragEnabled = true;
                        OnDragEndCallback(gameObject, null);
                    },
                    startPosition,
                    true)
            );
        }

        public virtual void OnDragEndCallback(GameObject target, GameObject objectiveTargetted)
        {

        }

        public virtual void OnBeginDrag()
        {

        }

        protected void SetStartPosition(Vector3 newStartPosition)
        {
            startPosition = newStartPosition;
        }
    }
}


