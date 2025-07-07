
# Speed Item

Defines the acceptable speed range for road users in m/s. Messages are triggered when:
1. The road user's speed is below the required minimum OR
2. The road user's speed is above the acceptable maximum AND
3. The associated TriggerConditions are met.

Example: For the speed range of 10-20 m/s and a TriggerCondition of 'user inside geofence', the message is sent if the user's speed is below 10 m/s or above 20 m/s while in the geofence area.

*This model accepts additional fields of type Any.*

## Structure

`SpeedItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `speed` | [`Speed`](../../doc/models/speed.md) | Required | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "speed": {
    "min": 64.76,
    "max": 138.18
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

