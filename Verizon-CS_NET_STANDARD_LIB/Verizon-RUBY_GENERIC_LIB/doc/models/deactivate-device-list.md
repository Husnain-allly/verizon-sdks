
# Deactivate Device List

## Structure

`DeactivateDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ids` | Array[[DeviceId](../../doc/models/device-id.md) \| [PropertyDeviceId](../../doc/models/property-device-id.md)] \| nil | Optional | This is Array of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "ids": [
    {
      "id": "id2",
      "kind": "kind0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id2",
      "kind": "kind0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

