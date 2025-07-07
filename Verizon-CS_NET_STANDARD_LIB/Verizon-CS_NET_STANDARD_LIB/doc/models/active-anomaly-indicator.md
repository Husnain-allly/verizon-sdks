
# Active Anomaly Indicator

Whether the anomaly detection is active or not.

*This model accepts additional fields of type object.*

## Structure

`ActiveAnomalyIndicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Active` | `bool?` | Optional | Indicates anomaly detection is active<br />True - Anomaly detection is active.<br />False - Anomaly detection is not active. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "active": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

