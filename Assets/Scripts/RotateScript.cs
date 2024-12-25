using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class RotateScript : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private Vector3 rotationAxis = new Vector3(0, 360, 0);
    [SerializeField] private float rotationDuration = 2f;
    [SerializeField] private Ease rotationEase = Ease.InOutQuad;

    [Header("Punch Settings")]
    [SerializeField] private Vector3 punchScale = new Vector3(0.5f, 0.5f, 0.5f);
    [SerializeField] private float punchDuration = 1f;
    [SerializeField] private Ease punchEase = Ease.InOutBounce;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RotateCube();
            LogMessage("Pressed button '1': Rotating the object", Color.green);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PunchScale();
            LogMessage("Pressed button '2': Punching scale animation", Color.blue);
        }
    }

    private void RotateCube()
    {
        transform.DORotate(rotationAxis, rotationDuration, RotateMode.LocalAxisAdd).SetEase(rotationEase);
    }

    private void PunchScale()
    {
        transform.DOPunchScale(punchScale, punchDuration).SetEase(punchEase);
    }

    private void LogMessage(string message, Color color)
    {
        Debug.Log($"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{message}</color>");
    }
}
