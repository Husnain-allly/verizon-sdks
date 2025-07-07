
# Esim Device List

## Structure

`EsimDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | [`List<EsimDeviceListDeviceIds>`](../../doc/models/containers/esim-device-list-device-ids.md) | Optional | This is List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` | List<EsimDeviceListDeviceIds> getDeviceIds() | setDeviceIds(List<EsimDeviceListDeviceIds> deviceIds) |

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

