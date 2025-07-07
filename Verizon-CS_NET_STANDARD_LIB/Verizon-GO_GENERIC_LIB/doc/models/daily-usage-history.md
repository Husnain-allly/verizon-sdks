
# Daily Usage History

*This model accepts additional fields of type interface{}.*

## Structure

`DailyUsageHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BytesUsed` | `*string` | Optional | the total data usage recorded in Bytes<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{1,32}$` |
| `ExtendedAttributes` | [`[]models.ExtendedAttribute`](../../doc/models/extended-attribute.md) | Optional | - |
| `ServicePlan` | `*string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `SmsUsed` | `*string` | Optional | The total number of SMS messages from and to the device<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{1,32}$` |
| `Source` | `*string` | Optional | Where the collected data is being gathered from<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Timestamp` | `*string` | Optional | Timestamp of when the retrieved record was completed ($datetime)<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "bytesUsed": "123456",
  "smsUsed": "5",
  "extendedAttributes": [
    {
      "key": "key8",
      "value": "value0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "key8",
      "value": "value0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "key8",
      "value": "value0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "servicePlan": "servicePlan6",
  "source": "source2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

