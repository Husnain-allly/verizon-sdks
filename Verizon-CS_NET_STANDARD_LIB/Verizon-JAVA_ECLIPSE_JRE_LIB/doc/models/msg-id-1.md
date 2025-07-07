
# Msg Id 1

*This model accepts additional fields of type Object.*

## Structure

`MsgId1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RoadSignId` | [`RoadSignId`](../../doc/models/road-sign-id.md) | Required | It provide a precise location of one or more roadside signs. | RoadSignId getRoadSignId() | setRoadSignId(RoadSignId roadSignId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "roadSignID": {
    "position": {
      "lat": 14,
      "long": 172
    },
    "viewAngle": "`1101000100011010`B"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

