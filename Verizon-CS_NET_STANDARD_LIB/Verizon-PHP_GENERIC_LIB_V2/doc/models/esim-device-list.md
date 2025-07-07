
# Esim Device List

## Structure

`EsimDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceIds` | array<Esim[DeviceId](../../doc/models/device-id.md)\|[DeviceId](../../doc/models/device-id.md)2>\|null | Optional | This is Array of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` | getDeviceIds(): ?array | setDeviceIds(?array deviceIds): void |

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

