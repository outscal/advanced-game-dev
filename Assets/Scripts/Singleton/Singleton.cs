using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T: Singleton<T>
{
}
