using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class InstanceManager : MonoBehaviour
{
    public static InstanceManager instance;

    [SerializeField] internal ManagerSpecie managerSpecie;
    [SerializeField] internal ManagerUI managerUI;

    public bool isEnableInstance;
    [Space(15)]
    public List<GameObject> spawnAnimals;
    public int indexSpawnAnimals;

    private static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();
    private ARRaycastManager m_RaycastManager;
    private Pose hitPose;
    private GameObject referencePrefabInstance;

    private WaitForSeconds delayStopRayCast = new WaitForSeconds(2f);
    

    private void Awake()
    {
        if (!instance)
            instance = FindObjectOfType<InstanceManager>();
        else
            Destroy(gameObject);

        m_RaycastManager = GetComponent<ARRaycastManager>();
        isEnableInstance = false;
    }
    private void Start()
    {
        for (int i = 0; i < managerSpecie.prefabAnimals.Length; i++)
        {
            ControllerInstance(i);
        }

    }
    #region INSTANCE START ANIMALS
    private void ControllerInstance(int index)
    {
        referencePrefabInstance = Instantiate(managerSpecie.prefabAnimals[index]/*, hitPose.position, hitPose.rotation*/);
        referencePrefabInstance.transform.parent = managerSpecie.positionParentAnimals;
        referencePrefabInstance.gameObject.SetActive(false);

        spawnAnimals.Add(referencePrefabInstance);
    } 
    #endregion

    #region BUTTON ENABLE ANIMALS
    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            touchPosition = new Vector2(mousePosition.x, mousePosition.y);
            return true;
        }
#else
            if (Input.touchCount > 0)
            {
                touchPosition = Input.GetTouch(0).position;
                return true;
            }
#endif

        touchPosition = default;
        return false;
    }

    public void Update()
    {
        if (isEnableInstance)
        {
            if (!TryGetTouchPosition(out Vector2 touchPosition))
                return;

            if (m_RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
            {
                hitPose = s_Hits[0].pose;

                for (int i = 0; i < spawnAnimals.Count; i++)
                {
                    spawnAnimals[indexSpawnAnimals].gameObject.SetActive(true);
                    spawnAnimals[i].gameObject.SetActive(false);
                }
                
                spawnAnimals[indexSpawnAnimals].transform.position = hitPose.position;
                spawnAnimals[indexSpawnAnimals].transform.rotation = Quaternion.Euler(0,-270,0);

                managerUI.panelTutorialPositionateAnimals.SetActive(false);
                managerUI.imageAnimationScanner.SetActive(false);
                managerUI.imageAnimationScanner.SetActive(false);

                managerUI.panelContentInfoAnimals.SetActive(true);
            }
        }
    }

    /*________________________________________________ CALL IN BUTTON __________________________________________________________________*/
    public void CallInformativeToInstance(int index)
    {
        indexSpawnAnimals = index;
        managerUI.panelInProject[2].SetActive(false);
        managerUI.imageAnimationScanner.SetActive(true);
        managerUI.panelTutorialPositionateAnimals.SetActive(true);
        managerUI.imageAnimationScanner.SetActive(true);
        managerUI.panelContentInfoAnimals.SetActive(false);
        managerUI.contentInfoTutorial.SetActive(false);

        for (int i = 0; i < spawnAnimals.Count; i++)
        {
            spawnAnimals[i].SetActive(false);
        }

        StartCoroutine(StopTimeRayCast());
    } 
    private IEnumerator StopTimeRayCast()
    {
        yield return delayStopRayCast;
        isEnableInstance = true;
    }
    #endregion



}
