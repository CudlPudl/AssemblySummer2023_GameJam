using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Q4 Vector3", menuName = "Q4/Q4 Vector3", order = 51)]
public class Q4VarVector3 : Q4Variable<Vector3, AnimationCurve>
{
    public Q4VarVector3(Vector3 customValue, AnimationCurve animationCurve) : base(customValue, animationCurve) { }

    public override Vector3 Evaluate(float progress)
    {
        return Evaluatable.Evaluate(progress) * Value;
    }
}