
# Device List 2

## Structure

`DeviceList2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ids` | Array[[eSIMDeviceId](../../doc/models/esim-device-id.md) \| [DeviceId2](../../doc/models/device-id-2.md)] \| nil | Optional | This is Array of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "ids": [
    {
      "id": "id4",
      "kind": "kind2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id4",
      "kind": "kind2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

