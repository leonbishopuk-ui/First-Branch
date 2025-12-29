using UnityEngine;

public class animCurve : MonoBehaviour
{
    [SerializeField] private AnimationCurve _myAnimationCurve;
    private float _evaluationPosition;

    private float EvaluateCurve(AnimationCurve curve, float position)
    {
        return curve.Evaluate(position);
    }

    private void MyMethod()
    {
        float myValue = EvaluateCurve(_myAnimationCurve, _evaluationPosition);
    }
}