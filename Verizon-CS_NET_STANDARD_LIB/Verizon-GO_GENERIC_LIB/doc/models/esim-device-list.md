
# Esim Device List

## Structure

`EsimDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`[]models.EsimDeviceListDeviceIds`](../../doc/models/containers/esim-device-list-device-ids.md) | Optional | This is Array of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` |

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

