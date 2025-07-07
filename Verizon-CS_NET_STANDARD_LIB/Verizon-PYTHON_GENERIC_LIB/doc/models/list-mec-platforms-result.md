
# List Mec Platforms Result

Response to return the optimal 5G Edge platforms for deployment based on a region, service profile of the service that you want to deploy or user equipment.

## Structure

`ListMecPlatformsResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mec_platforms` | [`List[MecPlatformResource]`](../../doc/models/mec-platform-resource.md) | Optional | A list of optimal MEC Platforms where you can register your deployed application.<br><br>**Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "MECPlatforms": [
    {
      "ern": "ern6",
      "zone": "zone0",
      "region": "region4",
      "status": "unknown",
      "properties": [
        {
          "type": "type8",
          "data": {
            "additionalInfo": "additionalInfo2",
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        }
      ]
    },
    {
      "ern": "ern6",
      "zone": "zone0",
      "region": "region4",
      "status": "unknown",
      "properties": [
        {
          "type": "type8",
          "data": {
            "additionalInfo": "additionalInfo2",
            "exampleAdditionalProperty": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        }
      ]
    }
  ]
}
```

