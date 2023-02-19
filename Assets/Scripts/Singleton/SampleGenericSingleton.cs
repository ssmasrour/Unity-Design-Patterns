using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGenericSingleton : Singleton<SampleGenericSingleton>
{
    public int TestValue = 10;
}
