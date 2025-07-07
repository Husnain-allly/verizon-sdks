
# Msg Id 1

*This model accepts additional fields of type Any.*

## Structure

`MsgId1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `road_sign_id` | [`RoadSignId`](../../doc/models/road-sign-id.md) | Required | It provide a precise location of one or more roadside signs. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

