using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[SerializeField]
	private List<TKey> _keys = new List<TKey>();
	[SerializeField]
	private List<TValue> _values = new List<TValue>();

	public void OnBeforeSerialize() {
		_keys.Clear();
		_values.Clear();
		_keys.Capacity = Count;
		_values.Capacity = Count;
		foreach(var kvp in this) {
			_keys.Add(kvp.Key);
			_values.Add(kvp.Value);
		}
	}

	public void OnAfterDeserialize() {
		Clear();
		int count = Mathf.Min(_keys.Count, _values.Count);
		for(int i = 0; i < count; ++i) {
			Add(_keys[i], _values[i]);
		}
	}
}