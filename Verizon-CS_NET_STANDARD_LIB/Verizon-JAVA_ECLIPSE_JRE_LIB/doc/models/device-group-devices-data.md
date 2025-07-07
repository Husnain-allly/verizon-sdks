
# Device Group Devices Data

Returns the name, description, and list of devices in a device group.

*This model accepts additional fields of type Object.*

## Structure

`DeviceGroupDevicesData`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Description` | `String` | Optional | The description of the device group. | String getDescription() | setDescription(String description) |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Optional | The devices in the device group. | List<AccountDeviceList> getDevices() | setDevices(List<AccountDeviceList> devices) |
| `HasMoreData` | `Boolean` | Optional | False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |
| `Name` | `String` | Optional | The name of the device group. | String getName() | setName(String name) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "name": "Nebraska Trucks",
  "description": "All service trucks in Nebraska.",
  "hasMoreData": false,
  "devices": [
    {
      "deviceIds": [
        {
          "id": "12345",
          "kind": "meid",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "54321",
          "kind": "mdn",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
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

