
# Esim Device List

## Structure

`EsimDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | List[[eSIMDeviceId](../../doc/models/esim-device-id.md) \| [DeviceId2](../../doc/models/device-id-2.md)] \| None | Optional | This is List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` |

## Example (as JSON)

```json
{
  "deviceIds": [
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

