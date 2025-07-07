
# Find Device by Property Response List

A success response includes an array of all matching devices. Each device includes the full device resource definition.

*This model accepts additional fields of type Object.*

## Structure

`FindDeviceByPropertyResponseList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceProperty` | [`List<FindDeviceByPropertyResponse>`](../../doc/models/find-device-by-property-response.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<FindDeviceByPropertyResponse> getDeviceProperty() | setDeviceProperty(List<FindDeviceByPropertyResponse> deviceProperty) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "DeviceProperty": [
    {
      "billingaccountid": "billingaccountid4",
      "createdon": "createdon6",
      "eventretention": "eventretention2",
      "iccid": "iccid4",
      "id": "id8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "billingaccountid": "billingaccountid4",
      "createdon": "createdon6",
      "eventretention": "eventretention2",
      "iccid": "iccid4",
      "id": "id8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

