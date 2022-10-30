using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public interface ISpell
{
    public void Cast(Transform origin);
    public void SetOnEndEvent(OnEndEvent ev);
    public string UIName();
}
